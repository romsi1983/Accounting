using System;
using System.Linq;
using System.Windows.Forms;
using Accounting.DataTable;
using Accounting.Models;
using Accounting.SQLite;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

namespace Accounting.Forms
{
    public partial class Generic<T> : Form where T : new()
    {
        protected DataTableModel<T> GenericTableData;
        protected int GenericBehavior;
        protected object ReturnData;
        public Generic(int genericBehavior = 0)
        {
            InitializeComponent();
            InitializeDisplayControl();
            GenericBehavior = genericBehavior;
            var formName = "неизвестный тип данных";
            switch (typeof(T).Name)
            {
                case "Car":
                    formName = "Автомобили";
                    break;
                case "ContainerType":
                    formName = @"Типы контейнеров";
                    break;
                case "Driver":
                    formName = @"Водители";
                    break;
                case "Platform":
                    formName = @"Платформы";
                    break;
            }
            Text = formName;
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
            GenericTableData = new DataTableModel<T>(null);
            commonData.DataSource = GenericTableData.GetDataTable();

            foreach (DataGridViewColumn col in commonData.Columns)
            {
                col.HeaderText = GenericTableData.GetDataTable().Columns[col.HeaderText].Caption;
            }
            commonData.Columns[0].Visible = false;
        }

        private void commonData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //var row = commonData.CurrentRow;
            //if (row != null) row.Cells[0].Value = row.Index + 1;
        }

        private void Generic_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void saveData_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            switch (typeof(T).Name)
            {
                case "Platform":
                    GenericTableData.GetDataTable().DefaultView.RowFilter = $"Address LIKE '%{filter.Text}%'";
                    break;
                default:
                    GenericTableData.GetDataTable().DefaultView.RowFilter = $"Name LIKE '%{filter.Text}%'";
                    break;
            }
        }

        private void commonData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GenericBehavior == 1)
            {
                Close();
                return;
            }

            if (typeof(T).Name.Equals("Platform"))
            {
                var sql = new Model();
                var form = new ViewCurrentPlatform(sql.FindinTable<Platform>("Address",commonData.SelectedCells[0].Value.ToString()).FirstOrDefault());
                form.ShowDialog();
            }
        }

        private void commonData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveRow(commonData.CurrentRow.Index);
        }

        private void SaveRow(int rowIndex)
        {
            var sql = new Model();
            var row = commonData.Rows[rowIndex];

            var valueName = (string)row.Cells[1].Value;
            if (String.IsNullOrEmpty(valueName)) return;

            int valueId = 0;
            if (!DBNull.Value.Equals(row.Cells[0].Value)) valueId = Convert.ToInt32(row.Cells[0].Value);

            //if (String.IsNullOrEmpty(valueName)) continue;
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
                    var parseResult = Single.TryParse(row.Cells[2].Value.ToString(), out var testValue);
                    if (!parseResult)
                    {
                        string floatValueString = floatValue.ToString().Contains(".") ? floatValue.ToString().Replace(".", ",") : floatValue.ToString().Replace(",", ".");
                        parseResult = Single.TryParse(floatValueString, out testValue);
                        if (!parseResult)
                        {
                            MessageBox.Show(@"не удалось конвертировать дробь");
                            return;
                        }
                    }
                    value.GetType().GetProperty("Volume")?.SetValue(value, testValue, null);
                    var multibool = false;
                    if (!DBNull.Value.Equals(row.Cells[3].Value)) multibool = (bool)row.Cells[3].Value;
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

            if (valueId != 0)
            {
                if (sql.FindinTable(value).Any()) return;
            }

            var result = sql.UpdateDb(value);

            if (result != 1)
            {
                MessageBox.Show(@"Ошибка сохранения", @"Ошибка", OK, Warning);
            }

            if (valueId == 0)
            {
                GenericTableData.RenewDataTable();
            }
        }
    }
}
