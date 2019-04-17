using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Accounting.SQLite
{
    public class SqLiteHelper : IDisposable
    {
        // ReSharper disable once InconsistentNaming
        internal static SQLiteConnection SqlLite;
        internal static SQLiteTransaction TsqLiteTransaction;
        public SqLiteHelper()
        {
            var dbPath = AppDomain.CurrentDomain.BaseDirectory + "Main.db";
            //var regResult = Regex.Match(dbPath, @"^(?:([\\]{2})|(\w:\\))\w.*\\$");

            //MessageBox.Show(dbPath+$@" regresult: {regResult.Success}");
            //if (regResult.Groups[1].Length > 0) dbPath = "\\\\" + dbPath + "Main.db";
            //else dbPath = dbPath + "Main.db";
            if (File.Exists(dbPath))
            {
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
            }
        }

        public void StartTransaction()
        {
            TsqLiteTransaction = SqlLite.BeginTransaction();
        }

        public void EndTransaction(bool commit)
        {
            if (commit)
            {
                TsqLiteTransaction.Commit();
            }
            else
            {
                TsqLiteTransaction.Rollback();
            }

        }

        public int ExecuteWriteCommandWithTrans(string sqlCommand)
        {
            try
            {
                var cmd = SqlLite.CreateCommand();
                cmd.CommandText = sqlCommand;
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SQLiteException)
            {
                return -1;
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
