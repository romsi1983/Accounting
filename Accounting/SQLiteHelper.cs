using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Accounting
{
    public class SqLiteHelper : IDisposable
    {
        // ReSharper disable once InconsistentNaming
        private static SQLiteConnection SqlLite;
        public SqLiteHelper()
        {
            var dbPath = AppDomain.CurrentDomain.BaseDirectory + "Main.db";

            if (File.Exists(dbPath))
            {
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
            }
        }
        private List<List<string>> GetPropsAndValues<T>(T value, bool write)
        {
            var inProps = new List<string>();
            var inValues = new List<string>();

            var properties = value.GetType().GetProperties();

            foreach (var property in properties)
            {
                var propName = property.Name;
                var propValue = property.GetValue(value, null);

                switch (property.PropertyType.Name)
                {
                    case "Int64":
                        propValue = ((long) propValue).ToString();
                        if (propValue.Equals("0")) continue;
                        break;
                    case "Boolean":
                        propValue = (bool)propValue ? "1" : "0";
                        break;
                    case "Single":
                        propValue = ((float) propValue).ToString(CultureInfo.InvariantCulture);
                        if (propValue.Equals("0")) continue;
                        break;
                    case "DateTime":
                        var dateTime = DateTime.Parse(propValue.ToString());
                        propValue = dateTime.ToString("yyyy-MM-dd");
                        //propValue = ((DateTime)propValue).ToString(CultureInfo.InvariantCulture);
                        break;
                }

                if (!String.IsNullOrEmpty((string) propValue))
                {
                    if (propName.Equals("Id"))
                    {
                        if (!write)
                        {
                            inProps.Add(propName);
                            inValues.Add((string) propValue);
                        }
                    }
                    else
                    {
                        inProps.Add(propName);
                        inValues.Add((string) propValue);
                    }
                }
            }
            
            return new List<List<string>> { inProps, inValues };
        }
        public void PrepareDb()
        {
            var dbPath = AppDomain.CurrentDomain.BaseDirectory + "Main.db";
            CreateDb(dbPath);
            UpdateDb();
            SetRelevace();
            FillInTodaysContainers();
        }



        public int UpdateDb<T>(T value) where T : new()
        {
            var valueId = Convert.ToInt32(value.GetType().GetProperty("Id")?.GetValue(value, null));
            var exist = FindinTable<T>(valueId).Any();

            if (!exist)
            {
                return WriteToDb(value);
            }

            var dataBase = GetDataBaseName<T>();
            var propsAndValues = GetPropsAndValues(value, false);
            string set = string.Empty;
            for (var i = 1; i < propsAndValues[0].Count; i++)
            {
                set = set + $"{propsAndValues[0][i]} = '{propsAndValues[1][i]}'";
                if (i != propsAndValues[0].Count - 1)
                {
                    set = set + ", ";
                }
            }

            string sqlCommand = $"UPDATE {dataBase} " +
                                $"SET {set} " +
                                $"WHERE id = {valueId}";



            return ExecuteWriteCommand(sqlCommand);
        }
        public int UpdateRecord<T>(long id,string columnName, string columnValue)
        {
            var dataBase = GetDataBaseName<T>();

            string sqlCommand = $"UPDATE {dataBase} " +
                                $"SET {columnName} = '{columnValue}' " +
                                $"WHERE id = {id}";

            return ExecuteWriteCommand(sqlCommand);
        }
        public int WriteToDb<T>(T value)
        {
            var dataBase = GetDataBaseName<T>();
            var propsAndValues = GetPropsAndValues(value, true);

            var propsIn = String.Empty;
            var valuesIn = String.Empty;

            foreach (var propIn in propsAndValues[0])
            {
                propsIn = propsIn + propIn;
                if (propIn != propsAndValues[0].Last())
                {
                    propsIn =  propsIn + ", ";
                }
            }

            foreach (var valueIn in propsAndValues[1])
            {
                valuesIn = valuesIn + $"'{valueIn}'";
                if (valueIn != propsAndValues[1].Last())
                {
                    valuesIn = valuesIn + ", ";
                }
            }

            string sqlCommand = $"INSERT INTO {dataBase} ({propsIn}) " +
                         $"VALUES ({valuesIn})";

            return ExecuteWriteCommand(sqlCommand);
        }
        public int DeleteFromTable<T>(long id)
        {
            var dataBase = GetDataBaseName<T>();
            string sqlCommand = $"DELETE FROM {dataBase} " +
                                $"WHERE Id = '{id}'";
            return ExecuteWriteCommand(sqlCommand);
        }
        public List<T> FindinTable<T>() where T : new()
        {
            var dataBase = GetDataBaseName<T>();
            var command = $"SELECT * FROM {dataBase}";
            return GetTableValues<T>(command);
        }
        private List<T> GetTableValues<T>(string command) where T : new()
        {
            var values = new List<T>();

            SQLiteCommand cmd = new SQLiteCommand(command, SqlLite);
            SQLiteDataReader rdr = cmd.ExecuteReader();

            var properties = typeof(T).GetProperties();

            while (rdr.Read())
            {
                T tempObj = new T();
                var tp = tempObj.GetType();

                foreach (var prop in properties)
                {
                    string propertyName = prop.Name;
                    var tempValue = rdr[propertyName];

                    if (DBNull.Value != tempValue)
                    {
                        // ReSharper disable once PossibleNullReferenceException
                        if (tp.GetProperty(propertyName).PropertyType.Name.Equals("Boolean"))
                        {
                            tempValue = (long)tempValue != 0;
                        }

                        // ReSharper disable once PossibleNullReferenceException
                        if (tp.GetProperty(propertyName).PropertyType.Name.Equals("Single"))
                        {
                            tempValue = Convert.ToSingle(tempValue);
                            
                        }
                        tp.GetProperty(propertyName)?.SetValue(tempObj, tempValue, null);
                    }
                }

                values.Add(tempObj);
            }

            return values;
        }
        public List<T> FindinTable<T>(int id) where T : new()
        {
            var dataBase = GetDataBaseName<T>();
            var command = $"SELECT * FROM {dataBase} WHERE Id = '{id}'";
            return GetTableValues<T>(command);
        }
        public List<T> FindinTable<T>(string columnName, string value) where T : new()
        {
            var dataBase = GetDataBaseName<T>();
            var command = $"SELECT * FROM {dataBase} WHERE {columnName} = '{value}'";
            return GetTableValues<T>(command);
        }
        public List<T> FindinTable<T>(T value) where T : new()
        {
            //var values = new List<T>();
            var dataBase = GetDataBaseName<T>();
            var propsAndValues = GetPropsAndValues(value, false);

            var command = $"SELECT * FROM {dataBase} WHERE ";

            for (var i = 0; i < propsAndValues[0].Count; i++)
            {
                command = command + $"{propsAndValues[0][i]} = '{propsAndValues[1][i]}'";
                if (i != propsAndValues[0].Count - 1)
                {
                    command = command + "AND ";
                }
            }

            return GetTableValues<T>(command);
        }
        private int ExecuteWriteCommand(string sqlCommand)
        {
            var tr = SqlLite.BeginTransaction();
            try
            {
                var cmd = SqlLite.CreateCommand();
                cmd.CommandText = sqlCommand;
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SQLiteException sqle)
            {
                return sqle.ErrorCode;
            }
            finally
            {
                tr.Commit();
            }

        }
        private string GetDataBaseName<T>()
        {
            var dataBase = string.Empty;
            switch (typeof(T).Name)
            {
                case "Car":
                    dataBase = "Cars";
                    break;
                case "ContainerType":
                    dataBase = "Containers";
                    break;
                case "Driver":
                    dataBase = "Drivers";
                    break;
                case "Organization":
                    dataBase = "Organizations";
                    break;
                case "OrganizationContainer":
                    dataBase = "OrganizationContainers";
                    break;
                case "Platform":
                    dataBase = "Platforms";
                    break;
                case "Registry":
                    dataBase = "Registry";
                    break;
                case "Contract":
                    dataBase = "Contracts";
                    break;
            }

            return dataBase;
        }
        private void CreateDb(string dbPath)
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
                ExecuteWriteCommand("PRAGMA user_version=2");
                SqlLite.Close();
                SqlLite = null;
            }

            if (SqlLite == null)
            {
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
            }

            SqlLite = new SQLiteConnection($"Data Source={dbPath}");
            SqlLite.Open();

            List<string> sqlCommands = new List<string>
            {
                @"CREATE TABLE IF NOT EXISTS Organizations
                    (Id INTEGER PRIMARY KEY,
                    Name VARCHAR(255) NOT NULL UNIQUE,
                    City VARCHAR(255) NOT NULL,
                    Address VARCHAR(255),
                    Phone VARCHAR(255),
                    Active TINYINTEGER NOT NULL DEFAULT 1,
                    Comment VARCHAR(255))",
                @"CREATE TABLE IF NOT EXISTS Containers (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL UNIQUE,
                    Volume FLOAT NOT NULL, Multiple TINYINTEGER NOT NULL DEFAULT 1)",
                @"CREATE TABLE IF NOT EXISTS Platforms (Id INTEGER NOT NULL PRIMARY KEY,Address VARCHAR(255) NOT NULL UNIQUE)",
                @"CREATE TABLE IF NOT EXISTS OrganizationContainers (Id INTEGER NOT NULL PRIMARY KEY, 
                    Organization INTEGER NOT NULL, Container INTEGER NOT NULL, Platform INTEGER NOT NULL, 
                    Schedule VARCHAR(255))",
                @"CREATE TABLE IF NOT EXISTS Drivers (Id INTEGER NOT NULL PRIMARY KEY, Name VARCHAR(255) NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Cars (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL,
                    Number VARCHAR(255) NOT NULL UNIQUE)",
                @"CREATE TABLE IF NOT EXISTS Registry 
                    (Id INTEGER NOT NULL PRIMARY KEY,
                    Organization INTEGER NOT NULL,
                    OrganizationСontainer INTEGER NOT NULL,
                    Driver INTEGER NOT NULL,
                    Car INTEGER NOT NULL,
                    Date DATETIME NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Contracts(Id INTEGER NOT NULL PRIMARY KEY, 
                    ContractNumber VARCHAR(255) NOT NULL UNIQUE, 
                    Organization INTEGER NOT NULL,
                    FromDate DATETIME NOT NULL, 
                    ToDate DATETIME NOT NULL, 
                    TargetVolume FLOAT NOT NULL, 
                    ProcessedVolume FLOAT)",
                @"CREATE TABLE IF NOT EXISTS Relevance(Id INTEGER NOT NULL PRIMARY KEY,
                    Today DATETIME NOT NULL,
                    Processed TINYINTEGER NOT NULL DEFAULT 0)",
                @"CREATE TABLE IF NOT EXISTS NotProcessedContainers (Id INTEGER NOT NULL PRIMARY KEY, 
                    Organization INTEGER NOT NULL, Container INTEGER NOT NULL, Platform INTEGER NOT NULL, 
                    Schedule VARCHAR(255))"
            };

            foreach (var sqlCommand in sqlCommands)
            {
                ExecuteWriteCommand(sqlCommand);
            }
        }
        private void UpdateDb()
        {   
            var currentVersion = (long) ExecuteTextCommand("PRAGMA user_version")[0];

            if (currentVersion < 1)
            {
                ExecuteWriteCommand(@"ALTER TABLE Containers ADD Volume FLOAT");
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS OrganizationsNew
                    (Id INTEGER PRIMARY KEY,
                     Name VARCHAR(255) NOT NULL,
                     City VARCHAR(255) NOT NULL,
                     Address VARCHAR(255),
                     Phone VARCHAR(255),
                     Active TINYINTEGER NOT NULL DEFAULT 1,
                     Comment VARCHAR(255))");
                ExecuteWriteCommand(@"INSERT INTO OrganizationsNew (Id,Name,City,Address,Phone,Active)
                    SELECT Id,Name,City,Address,Phone,Active FROM Organizations");
                ExecuteWriteCommand(@"DROP TABLE Organizations");
                ExecuteWriteCommand(@"ALTER TABLE OrganizationsNew RENAME TO Organizations");
                
                ExecuteWriteCommand("PRAGMA user_version=1");
                currentVersion++;
            }

            if (currentVersion < 2)
            {
                ExecuteWriteCommand(@"DROP TABLE IF EXISTS Сontract");
                ExecuteWriteCommand("PRAGMA user_version=2");
                currentVersion++;
            }

            if (currentVersion < 3)
            {
                ExecuteWriteCommand(@"ALTER TABLE Containers ADD Multiple TINYINTEGER NOT NULL DEFAULT 1");
                ExecuteWriteCommand("PRAGMA user_version=3");
                currentVersion++;
            }

            if (currentVersion < 4)
            {
                //Organizations
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS OrganizationsNew
                    (Id INTEGER PRIMARY KEY,
                     Name VARCHAR(255) NOT NULL UNIQUE,
                     City VARCHAR(255) NOT NULL,
                     Address VARCHAR(255),
                     Phone VARCHAR(255),
                     Active TINYINTEGER NOT NULL DEFAULT 1,
                     Comment VARCHAR(255))");
                ExecuteWriteCommand(@"INSERT INTO OrganizationsNew (Id,Name,City,Address,Phone,Active)
                    SELECT DISTINCT Id,Name,City,Address,Phone,Active FROM Organizations");
                ExecuteWriteCommand(@"DROP TABLE Organizations");
                ExecuteWriteCommand(@"ALTER TABLE OrganizationsNew RENAME TO Organizations");
                //Containers
                ExecuteWriteCommand(
                    @"CREATE TABLE IF NOT EXISTS ContainersNew(Id INTEGER NOT NULL PRIMARY KEY, Name VARCHAR(255) NOT NULL UNIQUE,
                    Volume FLOAT NOT NULL,Multiple TINYINTEGER NOT NULL DEFAULT 1)");
                ExecuteWriteCommand(@"INSERT INTO ContainersNew (Id,Name,Volume,Multiple)
                    SELECT Id,Name,Volume,Multiple FROM Containers");
                ExecuteWriteCommand(@"DROP TABLE Containers");
                ExecuteWriteCommand(@"ALTER TABLE ContainersNew RENAME TO Containers");
                //Platforms
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS PlatformsNew (Id INTEGER NOT NULL PRIMARY KEY,Address VARCHAR(255) NOT NULL UNIQUE)");
                ExecuteWriteCommand(@"INSERT INTO PlatformsNew (Id,Address) SELECT Id,Address FROM Platforms");
                ExecuteWriteCommand(@"DROP TABLE Platforms");
                ExecuteWriteCommand(@"ALTER TABLE PlatformsNew RENAME TO Platforms");
                //Drivers
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS DriversNew (Id INTEGER NOT NULL PRIMARY KEY, Name VARCHAR(255) NOT NULL UNIQUE)");
                ExecuteWriteCommand(@"INSERT INTO DriversNew (Id,Name) SELECT Id, Name FROM Drivers");
                ExecuteWriteCommand(@"DROP TABLE Drivers");
                ExecuteWriteCommand(@"ALTER TABLE DriversNew RENAME TO Drivers");
                //Cars
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS CarsNew (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL,
                    Number VARCHAR(255) NOT NULL UNIQUE)");
                ExecuteWriteCommand(@"INSERT INTO CarsNew (Id,Name,Number) SELECT Id, Name, Number FROM Cars");
                ExecuteWriteCommand(@"DROP TABLE Cars");
                ExecuteWriteCommand(@"ALTER TABLE CarsNew RENAME TO Cars");
                //Contracts
                ExecuteWriteCommand(@"DROP TABLE IF EXISTS Contracts");
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS Contracts(Id INTEGER NOT NULL PRIMARY KEY, 
                    ContractNumber VARCHAR(255) NOT NULL UNIQUE, 
                    Organization INTEGER NOT NULL,
                    FromDate DATETIME NOT NULL, 
                    ToDate DATETIME NOT NULL, 
                    TargetVolume FLOAT NOT NULL, 
                    ProcessedVolume FLOAT)");
                ExecuteWriteCommand("PRAGMA user_version=4");
            }
        }
        private void SetRelevace()
        {
            var today = DateTime.Today;
            var todayString = today.ToString("yyyy-MM-dd");
            var releveance = ExecuteTextCommand("SELECT Today FROM Relevance").FirstOrDefault();
            if (releveance==null)
            {
                ExecuteWriteCommand(@"INSERT INTO Relevance (Today,Processed) " +
                                    $"VALUES ('{todayString}','0')");
            }
            else
            {
                if ((DateTime)releveance < today)
                    ExecuteWriteCommand(@"UPDATE Relevance " +
                                        $"SET Today = '{todayString}',Processed='0' " +
                                        @"WHERE Id = '1'");
            }
        }
        private void FillInTodaysContainers()
        {
            var processed = ExecuteTextCommand("SELECT Processed FROM Relevance").FirstOrDefault();
            if (processed != null && (long) processed != 0) return;

            var dayOfTheWeek = DateTime.Today.DayOfWeek.GetHashCode();
            var sqlCommand = $"SELECT OrganizationContainers.Id " +
                             $"FROM OrganizationContainers " +
                             $"INNER JOIN Organizations " +
                             $"ON Organizations.Id = OrganizationContainers.Organization " +
                             $"WHERE Organizations.Active = 1 " +
                             $"AND OrganizationContainers.Schedule LIKE '%{dayOfTheWeek}%'";

            var todaysContainers = ExecuteTextCommand(sqlCommand);
        }
        private object[] ExecuteTextCommand(string commandText)
        {
            var cmd = SqlLite.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = commandText;
            var reader = cmd.ExecuteReader();
            object[] values = { };
            if (reader.HasRows)
            {
                values = new object[reader.FieldCount];
                while (reader.Read())
                {
                    reader.GetValues(values);
                }
            }
            return values;
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                SqlLite.Close();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
