using System;
using System.Windows.Forms;

namespace Accounting.Forms
{
    public partial class Generic<T> : Form where T : new()
    {
        public Generic()
        {
            InitializeComponent();
            InitializeDisplayControl();
            var columnHeader = "Неизвестный тип";
            var formName = "неизвестный тип данных";
            switch (typeof(T).Name)
            {
                case "Car":
                    formName = "Автомобили";
                    columnHeader = "Автомобиль";
                    commonData.Columns.Add("CarNumber", "Номер машины");
                    break;
                case "ContainerType":
                    formName = @"Типы контейнеров";
                    columnHeader = "Тип контейнера";
                    break;
                case "Driver":
                    formName = @"Водители";
                    columnHeader = "Водитель";
                    break;
                case "Platform":
                    formName = @"Платформы";
                    columnHeader = "Адрес платформы";
                    break;
            }

            Text = formName;
            commonData.Columns[1].HeaderText = columnHeader;
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        public T DisplayControl { get; private set; }

        private void InitializeDisplayControl()
        {
            DisplayControl = new T ();
        }

        private void Generic_Load(object sender, EventArgs e)
        {
            commonData.Rows.Clear();
            var sql = new SqLiteHelper();
            var allValues = sql.FindinTable<T>();

            foreach (var value in allValues)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(commonData);
                row.Cells[0].Value = value.GetType().GetProperty("Id")?.GetValue(value,null);
                switch (typeof(T).Name)
                {
                    case "Platform":
                        row.Cells[1].Value = value.GetType().GetProperty("Address")?.GetValue(value, null);
                        break;
                    case "Car":
                        row.Cells[1].Value = value.GetType().GetProperty("Name")?.GetValue(value, null);
                        row.Cells[2].Value = value.GetType().GetProperty("Number")?.GetValue(value, null);
                        break;
                    default:
                        row.Cells[1].Value = value.GetType().GetProperty("Name")?.GetValue(value, null);
                        break;
                }
                
                commonData.Rows.Add(row);
            }
        }

        private void commonData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var row = commonData.CurrentRow;
            if (row != null) row.Cells[0].Value = row.Index + 1;
        }

        private void Generic_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sql = new SqLiteHelper();
            for (var i = 0; i < commonData.RowCount; i++)
            {
                var row = commonData.Rows[i];

                var valueName = (string)row.Cells[1].Value;
                var valueId = Convert.ToInt32(row.Cells[0].Value);

                if (String.IsNullOrEmpty(valueName)) continue;
                var value = new T();
                value.GetType().GetProperty("Id")?.SetValue(value,valueId,null);
                switch (typeof(T).Name)
                {
                    case "Platform":
                        value.GetType().GetProperty("Address")?.SetValue(value, valueName, null);
                        break;
                    case "Car":
                        value.GetType().GetProperty("Name")?.SetValue(value, valueName, null);
                        value.GetType().GetProperty("Number")?.SetValue(value, (string)row.Cells[2].Value, null);
                        break;
                    default:
                        value.GetType().GetProperty("Name")?.SetValue(value, valueName, null);
                        break;
                }

                sql.UpdateDb(value);
            }

        }
    }
}
