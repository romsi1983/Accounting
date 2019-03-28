using System;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

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
                    commonData.Columns.Add("Volume", "Объем");
                    DataGridViewCheckBoxColumn multiple = new DataGridViewCheckBoxColumn();
                    commonData.Columns.Add(multiple);
                    multiple.HeaderText = @"Несколько";
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
                    case "ContainerType":
                        row.Cells[1].Value = value.GetType().GetProperty("Name")?.GetValue(value, null);
                        row.Cells[2].Value = value.GetType().GetProperty("Volume")?.GetValue(value, null);
                        row.Cells[3].Value = value.GetType().GetProperty("Multiple")?.GetValue(value, null);
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


        }

        private void saveData_Click(object sender, EventArgs e)
        {
            var sql = new SqLiteHelper();
            for (var i = 0; i < commonData.RowCount; i++)
            {
                var row = commonData.Rows[i];

                var valueName = (string)row.Cells[1].Value;
                var valueId = Convert.ToInt32(row.Cells[0].Value);

                if (String.IsNullOrEmpty(valueName)) continue;
                var value = new T();
                value.GetType().GetProperty("Id")?.SetValue(value, valueId, null);
                
                switch (typeof(T).Name)
                {
                    case "Platform":
                        value.GetType().GetProperty("Address")?.SetValue(value, valueName, null);
                        break;
                    case "ContainerType":
                        value.GetType().GetProperty("Name")?.SetValue(value, valueName, null);
                        var floatValue = row.Cells[2].Value;
                        if (floatValue.GetType().Name.Equals("String"))
                        {
                            floatValue = floatValue.ToString().Contains(".") ? floatValue.ToString().Replace(".", ",") : floatValue.ToString().Replace(",", ".");
                        }
                        value.GetType().GetProperty("Volume")?.SetValue(value, Convert.ToSingle(floatValue), null);
                        var multibool = false;
                        if (row.Cells[3].Value != null) multibool = (bool)row.Cells[3].Value;
                        value.GetType().GetProperty("Multiple")?.SetValue(value, multibool, null);
                        break;
                    case "Car":
                        value.GetType().GetProperty("Name")?.SetValue(value, valueName, null);
                        value.GetType().GetProperty("Number")?.SetValue(value, (string)row.Cells[2].Value, null);
                        break;
                    default:
                        value.GetType().GetProperty("Name")?.SetValue(value, valueName, null);
                        break;
                }

                var result = sql.UpdateDb(value);
                if (result == 19)
                {
                    MessageBox.Show(@"Информация не уникальна", @"Ошибка", OK, Warning);
                    return;
                }
            }
        }
    }
}
