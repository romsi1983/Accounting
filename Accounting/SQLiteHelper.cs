﻿using System;
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
                            tempValue = (float)Convert.ToDecimal(tempValue);
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
            var cmd = SqlLite.CreateCommand();
            cmd.CommandText = sqlCommand;
            int result = cmd.ExecuteNonQuery();
            tr.Commit();
            return result;
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
            }

            SqlLite = new SQLiteConnection($"Data Source={dbPath}");
            SqlLite.Open();

            List<string> sqlCommands = new List<string>
            {
                @"CREATE TABLE IF NOT EXISTS Organizations
                    (Id INTEGER PRIMARY KEY,
                    Name VARCHAR(255) NOT NULL,
                    City VARCHAR(255) NOT NULL,
                    Address VARCHAR(255),
                    Phone VARCHAR(255),
                    Active TINYINTEGER NOT NULL DEFAULT 1,
                    Comment VARCHAR(255))",
                @"CREATE TABLE IF NOT EXISTS Containers (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL,
                    Volume FLOAT NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Platforms (Id INTEGER NOT NULL PRIMARY KEY,Address VARCHAR(255) NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS OrganizationContainers (Id INTEGER NOT NULL PRIMARY KEY, 
                    Organization INTEGER NOT NULL, Container INTEGER NOT NULL, Platform INTEGER NOT NULL, 
                    Schedule VARCHAR(255))",
                @"CREATE TABLE IF NOT EXISTS Drivers (Id INTEGER NOT NULL PRIMARY KEY, Name VARCHAR(255) NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Cars (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL,
                    Number VARCHAR(255) NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Registry 
                    (Id INTEGER NOT NULL PRIMARY KEY,
                    Organization INTEGER NOT NULL,
                    OrganizationСontainer INTEGER NOT NULL,
                    Driver INTEGER NOT NULL,
                    Car INTEGER NOT NULL,
                    Date DATETIME NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Contracts(Id INTEGER NOT NULL PRIMARY KEY, 
                    ContractNumber VARCHAR(255) NOT NULL, 
                    Organization INTEGER NOT NULL,
                    FromDate DATETIME NOT NULL, 
                    ToDate DATETIME NOT NULL, 
                    TargetVolume FLOAT NOT NULL, 
                    ProcessedVolume FLOAT)"
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
            }

            if (currentVersion < 2)
            {
                ExecuteWriteCommand(@"DROP TABLE Сontract");
                ExecuteWriteCommand("PRAGMA user_version=2");
            }
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
