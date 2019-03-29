using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;


namespace Accounting.SQLite
{
    public class SqLiteHelper : IDisposable
    {
        // ReSharper disable once InconsistentNaming
        internal static SQLiteConnection SqlLite;
        public SqLiteHelper()
        {
            var dbPath = AppDomain.CurrentDomain.BaseDirectory + "Main.db";

            if (File.Exists(dbPath))
            {
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
            }
        }
        internal int ExecuteWriteCommand(string sqlCommand)
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
        internal object[] ExecuteTextCommand(string commandText)
        {
            var cmd = SqlLite.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = commandText;
            var reader = cmd.ExecuteReader();
            var values = new List<object>();
            //object[] values = { };
            //int i = 0;
            if (reader.HasRows)
            {
                //values = new object[reader.FieldCount];
                //values = new object[reader.StepCount];
                while (reader.Read())
                {
                    object[] subValues = new object[reader.FieldCount];
                    reader.GetValues(subValues);
                    values.Add(subValues.Length == 1 ? subValues[0] : subValues);
                }
            }

            if (values.Count == 0)
            {
                return values.ToArray();
            }

            Type valueType = values[0].GetType();
            if (values.Count == 1 && valueType.IsArray) return (object[]) values[0];
            return values.ToArray();
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
