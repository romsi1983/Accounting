using System.Data;
using Accounting.SQLite;

namespace Accounting.DataTable
{
    public class CreateDataSource<T> where T : new()
    {
        protected System.Data.DataTable NewTable;
        public CreateDataSource(System.Data.DataTable inputData) 
        {
            if (inputData == null)
            {
                NewTable = new System.Data.DataTable();
                CreateColumns();
            }
            else
            {
                NewTable = inputData;
            }
        }

        public void RenewDataTable()
        {
            NewTable.Rows.Clear();
            var sql = new Model();
            var allValues = sql.FindinTable<T>();
            foreach (var value in allValues)
            {
                DataRow row = NewTable.NewRow();
                row[0] = value.GetType().GetProperty("Id")?.GetValue(value, null);
                switch (typeof(T).Name)
                {
                    case "Platform":
                        row[0] = value.GetType().GetProperty("Address")?.GetValue(value, null);
                        break;
                    case "Car":
                        row[1] = value.GetType().GetProperty("Name")?.GetValue(value, null);
                        row[2] = value.GetType().GetProperty("Number")?.GetValue(value, null);
                        break;
                    case "ContainerType":
                        row[1] = value.GetType().GetProperty("Name")?.GetValue(value, null);
                        row[2] = value.GetType().GetProperty("Volume")?.GetValue(value, null);
                        row[3] = value.GetType().GetProperty("Multiple")?.GetValue(value, null);
                        break;
                    case "Organization":
                        row[1] = value.GetType().GetProperty("Name")?.GetValue(value, null);
                        row[2] = value.GetType().GetProperty("City")?.GetValue(value, null);
                        row[3] = value.GetType().GetProperty("Address")?.GetValue(value, null);
                        row[4] = value.GetType().GetProperty("Phone")?.GetValue(value, null);
                        row[5] = value.GetType().GetProperty("Active")?.GetValue(value, null);
                        break;
                    default:
                        row[4] = value.GetType().GetProperty("Name")?.GetValue(value, null);
                        break;
                }
                NewTable.Rows.Add(row);
            }
        }

        private void CreateColumns()
        {
            switch (typeof(T).Name)
            {
                case "Platform":
                    CreateColumnsForPlatform();
                    break;
                case "Organization":
                    CreateColumnsForOrganization();
                    break;
                case "Driver":
                    CreateColumnsForDriver();
                    break;
                case "Car":
                    CreateColumnsForCar();
                    break;
                case "ContainerType":
                    CreateColumnsForContainerType();
                    break;
            }
        }

        private void CreateColumnsForContainerType()
        {
            var column = NewTable.Columns.Add("Id", typeof(long));
            column.Unique = true;
            column.Caption = "Id";
            column = NewTable.Columns.Add("Name", typeof(string));
            column.Unique = true;
            column.Caption = "Тип контейнера";
            column = NewTable.Columns.Add("Volume", typeof(float));
            column.Caption = "Объем";
            column.Caption = "Тип контейнера";
            column = NewTable.Columns.Add("Multiple", typeof(bool));
            column.Caption = "Несколько";
        }

        private void CreateColumnsForCar()
        {
            var column = NewTable.Columns.Add("Id", typeof(long));
            column.Unique = true;
            column.Caption = "Id";
            column = NewTable.Columns.Add("Name", typeof(string));
            //column.Unique = true;
            column.Caption = "Марка машины";
            column = NewTable.Columns.Add("Number", typeof(string));
            column.Unique = true;
        }

        private void CreateColumnsForDriver()
        {
            var column = NewTable.Columns.Add("Id", typeof(long));
            column.Unique = true;
            column.Caption = "Id";
            column = NewTable.Columns.Add("Name", typeof(string));
            column.Unique = true;
            column.Caption = "ФИО Водителя";
        }

        private void CreateColumnsForOrganization()
        {
            var column = NewTable.Columns.Add("Id", typeof(long));
            column.Unique = true;
            column.Caption = "Id";
            column = NewTable.Columns.Add("Name", typeof(string));
            column.Unique = true;
            column.Caption = "Наименование организации";
            column = NewTable.Columns.Add("City", typeof(string));
            column.Caption = "Город";
            column = NewTable.Columns.Add("Address", typeof(string));
            column.Caption = "Адрес";
            column = NewTable.Columns.Add("Phone", typeof(string));
            column.Caption = "Телефон";
            column = NewTable.Columns.Add("Active", typeof(bool));
            column.Caption = "Активная";
        }

        private void CreateColumnsForPlatform()
        {
            var column = NewTable.Columns.Add("Id", typeof(long));
            column.Unique = true;
            column.Caption = "Id";
            column = NewTable.Columns.Add("Address", typeof(string));
            column.Unique = true;
            column.Caption = "Адрес площадки";
        }
    }
}
