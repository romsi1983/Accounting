using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;

namespace Accounting.SQLite
{
    public class Model : SqLiteHelper
    {
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
                        propValue = ((long)propValue).ToString();
                        if (propValue.Equals("0")) continue;
                        break;
                    case "Boolean":
                        propValue = (bool)propValue ? "1" : "0";
                        break;
                    case "Single":
                        propValue = ((float)propValue).ToString(CultureInfo.InvariantCulture);
                        //if (propValue.Equals("0")) continue;
                        break;
                    case "DateTime":
                        var dateTime = DateTime.Parse(propValue.ToString());
                        propValue = dateTime.ToString("yyyy-MM-dd");
                        //propValue = ((DateTime)propValue).ToString(CultureInfo.InvariantCulture);
                        break;
                }

                if (!String.IsNullOrEmpty((string)propValue))
                {
                    if (propName.Equals("Id"))
                    {
                        if (!write)
                        {
                            inProps.Add(propName);
                            inValues.Add((string)propValue);
                        }
                    }
                    else
                    {
                        inProps.Add(propName);
                        inValues.Add((string)propValue);
                    }
                }
            }

            return new List<List<string>> { inProps, inValues };
        }
        public bool CheckActive(long orgId)
        {
            var today = DateTime.Today;
            var todayString = today.ToString("yyyy-MM-dd");
            var sqlCommand = @"SELECT Organization FROM Contracts " +
                             $"WHERE '{todayString}' >= FromDate " +
                             $"AND '{todayString}' <= ToDate " +
                             @"AND ProcessedVolume < TargetVolume " +
                             $"AND Organization = '{orgId}'";

            return ExecuteTextCommand(sqlCommand).Any();
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
        public int UpdateRecord<T>(long id, string columnName, string columnValue)
        {
            var dataBase = GetDataBaseName<T>();

            string sqlCommand = $"UPDATE {dataBase} " +
                                $"SET {columnName} = '{columnValue}' " +
                                $"WHERE id = {id}";

            return ExecuteWriteCommand(sqlCommand);
        }
        public string GetRecord<T>(long id, string columnName)
        {
            var dataBase = GetDataBaseName<T>();
            var sqlCommand = $"SELECT {columnName} " +
                             $"FROM {dataBase} " +
                             $"WHERE Id = {id}";
            
            return ExecuteTextCommand(sqlCommand).FirstOrDefault()?.ToString();
        }
        public long GetRecordId<T>(string columnName, string columnValue)
        {
            var dataBase = GetDataBaseName<T>();
            var sqlCommand = $"SELECT Id " +
                             $"FROM {dataBase} " +
                             $"WHERE {columnName} = '{columnValue}'";

            var returnValue = ExecuteTextCommand(sqlCommand);
            if (!returnValue.Any()) return -1;

            // ReSharper disable once PossibleNullReferenceException
            return (long)returnValue.FirstOrDefault();
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
                    propsIn = propsIn + ", ";
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
        public List<T> FindinTable<T>(string sqlcommand) where T : new()
        {
            return GetTableValues<T>(sqlcommand);
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
                case "ContainerQueue":
                    dataBase = "ContainersQueue";
                    break;
            }

            return dataBase;
        }
    }
}
