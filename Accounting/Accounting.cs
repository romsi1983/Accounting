using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Accounting.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting
{
    public partial class Accounting : Form
    {
        //protected List<Registry>AllRegistryRecords =  new List<Registry>();
        protected DataTable RegistryTable = new DataTable();
        public Accounting()
        {
            InitializeComponent();

            double interval = 150000.0;
            // ReSharper disable once UseObjectOrCollectionInitializer
            var aTimer = new System.Timers.Timer(interval)
            {
                AutoReset = false,
                Enabled = true
            };
            aTimer.Elapsed += OnTimedEvent;
        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var sql = new PrepareAccounting();
            sql.PrepareDb(false);
        }
        private void Accounting_Load(object sender, EventArgs e)
        {
            RegistryTable.Columns.Add("Id", typeof(long));
            RegistryTable.Columns.Add("Организация", typeof(string));
            RegistryTable.Columns.Add("Номер договора", typeof(string));
            RegistryTable.Columns.Add("Тип Контейнера", typeof(string));
            RegistryTable.Columns.Add("Адрес платформы", typeof(string));
            RegistryTable.Columns.Add("Водитель", typeof(string));
            RegistryTable.Columns.Add("Автомобиль", typeof(string));
            RegistryTable.Columns.Add("Дата", typeof(DateTime));
            RegistryTable.Columns.Add("Объем", typeof(float));

            dataRegistry.DataSource = RegistryTable;

            var sql = new PrepareAccounting();
            sql.PrepareDb(true);
            dateFrom.Value = DateTime.Today.AddDays(-7);
            ReloadDataRegistry();
            ReloadQueueData();
        }

        #region Registry
        private void ReloadDataRegistry()
        {
            RegistryTable.Rows.Clear();

            var sql = new Model();
            var orgs = new List<Organization>();
            var contypes = sql.FindinTable<ContainerType>();
            var pf = new List<Platform>();
            var drs = sql.FindinTable<Driver>();
            var cars = sql.FindinTable<Car>();
            var conrs = new List<Contract>();


            var fromDataText = dateFrom.Value.ToString("yyyy-MM-dd");
            var toDataText = dateTo.Value.ToString("yyyy-MM-dd");
            var sqlCommand = $"SELECT * " +
                             $"FROM Registry " +
                             $"WHERE '{toDataText}' >= Entered " +
                             $"AND '{fromDataText}' <= Entered";

            var rgs = sql.FindinTable<Registry>(sqlCommand);

            foreach (var value in rgs)
            {   
                if (orgs.All(org => org.Id != value.Organization)) orgs.AddRange(sql.FindinTable<Organization>((int)value.Organization));
                if (pf.All(x => x.Id != value.Platform)) pf.AddRange(sql.FindinTable<Platform>((int)value.Platform));
                if (conrs.All(x => x.Id != value.Contract)) conrs.AddRange(sql.FindinTable<Contract>((int)value.Contract));
                //DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(dataRegistry);
                DataRow row = RegistryTable.NewRow();

                row[0] = value.Id;
                row[1] = orgs.Find(x=>x.Id== value.Organization).Name;
                row[2] = conrs.Find(x => x.Id == value.Contract).ContractNumber;
                row[3] = contypes.Find(x=>x.Id==value.Container).Name;
                row[4] = pf.Find(x=>x.Id==value.Platform).Address;
                row[5] = drs.Find(x=>x.Id==value.Driver).Name;
                var car = cars.Find(x => x.Id == value.Car);
                row[6] = car.Name + "; Номер: " + car.Number;
                row[7] = value.Entered;
                row[8] = value.Volume;

                RegistryTable.Rows.Add(row);
            }
        }
        private void Organizations_Click(object sender, EventArgs e)
        {
            OrganizationsAll form = new OrganizationsAll();
            Hide();
            form.ShowDialog(this);
            Show();
        }
        private void Containers_Click(object sender, EventArgs e)
        {
            var form = new Generic<ContainerType>();
            form.ShowDialog();
        }
        private void platforms_Click(object sender, EventArgs e)
        {
            var form = new Generic<Platform>();
            form.ShowDialog();
        }
        private void drivers_Click(object sender, EventArgs e)
        {
            var form = new Generic<Driver>();
            form.ShowDialog();
        }
        private void Cars_Click(object sender, EventArgs e)
        {
            var form = new Generic<Car>();
            form.ShowDialog();
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            var form = new NewRegistry();
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                ReloadDataRegistry();
                ReloadQueueData();
            }
        }
        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            ReloadDataRegistry();
        }
        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            ReloadDataRegistry();
        }
        private void orgFilter_TextChanged(object sender, EventArgs e)
        {
            RegistryTable.DefaultView.RowFilter = $"Организация LIKE '%{orgFilter.Text}%'";
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            var currentRow = dataRegistry.CurrentRow;
            if (currentRow == null)
            {
                MessageBox.Show(@"Сделайте свой выбор перед удалением");
                return;
            }

            var sql = new Model();
            
            

            //Contract
            var volume = (float)currentRow.Cells[8].Value;
            var currentContract = sql.FindinTable<Contract>("ContractNumber", (string) currentRow.Cells[2].Value).FirstOrDefault();
            Debug.Assert(currentContract != null, nameof(currentContract) + " != null");
            if (currentContract.ProcessedVolume - volume < 0)
            {
                MessageBox.Show(@"Если удалить, то будет отрицательный объем. Как так вышло?");
                return;
            }

            //Start Transaction
            sql.StartTransaction();

            //Update Contracts
            var newSqlCommand = $"UPDATE Contracts " +
                            $"SET ProcessedVolume = '{(currentContract.ProcessedVolume - volume).ToString(CultureInfo.InvariantCulture)}' " +
                            $"WHERE id = {currentContract.Id}";

            var result = sql.ExecuteWriteCommandWithTrans(newSqlCommand);
            if (result == -1)
            {
                MessageBox.Show(@"Не получилось обновить договор");
                sql.EndTransaction(false);
                return;
            }

            //Update Registry
            var registryId = (long)currentRow.Cells[0].Value;
            newSqlCommand = $"DELETE FROM Registry " +
                            $"WHERE Id = '{registryId}'";
            result = sql.ExecuteWriteCommandWithTrans(newSqlCommand);
            if (result == -1)
            {
                MessageBox.Show(@"Не получилось удалить запись из реестра");
                sql.EndTransaction(false);
                return;
            }

            //Commit Transaction
            sql.EndTransaction(true);

            //ContainersQueue
            var enteredDate = (DateTime) currentRow.Cells[7].Value;
            if (enteredDate == DateTime.Today)
            {
                var sqlCommand = $"SELECT Id FROM OrganizationContainers " +
                                 $"WHERE Organization = '{sql.GetRecordId<Organization>("Name", (string)currentRow.Cells[1].Value)}' " +
                                 $"AND Platform = '{sql.GetRecordId<Platform>("Address", (string)currentRow.Cells[4].Value)}' " +
                                 $"AND Container = '{sql.GetRecordId<ContainerType>("Name", (string)currentRow.Cells[3].Value)}'";

                var orgCont = sql.ExecuteTextCommand(sqlCommand);

                foreach (var value in orgCont)
                {
                    sqlCommand = $"SELECT Id " +
                                 $"FROM ContainersQueue " +
                                 // ReSharper disable once PossibleNullReferenceException
                                 $"WHERE Container = '{value}' " +
                                 $"AND Dayspast = '0' " +
                                 $"AND Processed = '1'";

                    var processedCont = sql.ExecuteTextCommand(sqlCommand);

                    if (processedCont.Any())
                    {
                        result = sql.UpdateRecord<ContainerQueue>((long)processedCont[0], "Processed", "0");
                        if (result != 1) MessageBox.Show(@"Не получилось обновить очередь контейнеров");
                        ReloadQueueData();
                        break;
                    }
                }
            }

            ReloadDataRegistry();


        }
        #endregion

        #region Queue
        private void ReloadQueueData()
        {
            containesQueueData.Rows.Clear();
            var sql = new Model();
            var queue = sql.FindinTable<ContainerQueue>();
            var orgs = new List<Organization>();
            var ogrConts = new List<OrganizationContainer>();
            var contypes = sql.FindinTable<ContainerType>();
            var pf = new List<Platform>();

            foreach (var value in queue)
            {
                if (ogrConts.All(x => x.Id != value.Container)) ogrConts.AddRange(sql.FindinTable<OrganizationContainer>((int)value.Container));
                var orgCont = ogrConts.Find(x => x.Id == value.Container);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(containesQueueData);
                row.Cells[0].Value = value.Id;
                row.Cells[1].Value = value.Container;
                
                if (orgs.All(org => org.Id != orgCont.Organization)) orgs.AddRange(sql.FindinTable<Organization>((int)orgCont.Organization));
                row.Cells[2].Value = orgs.Find(x => x.Id == orgCont.Organization).Name;

                if (pf.All(x => x.Id != orgCont.Platform)) pf.AddRange(sql.FindinTable<Platform>((int)orgCont.Platform));
                row.Cells[3].Value = pf.Find(x => x.Id == orgCont.Platform).Address;

                row.Cells[4].Value = contypes.Find(x => x.Id == orgCont.Container).Name;
                row.Cells[5].Value = contypes.Find(x => x.Id == orgCont.Container).Volume;

                row.Cells[6].Value = value.Dayspast;
                row.Cells[7].Value = value.Processed;

                containesQueueData.Rows.Add(row);
            }
        }

        private void DeleteFromQueue_Click(object sender, EventArgs e)
        {
            var sql = new Model();
            var correntRow = containesQueueData.CurrentRow;
            if (correntRow != null)
            {
                sql.DeleteFromTable<ContainerQueue>((long)correntRow.Cells[0].Value);
                ReloadQueueData();
            }
        }

        private void MakeProccesed_Click(object sender, EventArgs e)
        {
            MakeProccesedUnProccesed(true);
        }

        private void MakeUnProccesed_Click(object sender, EventArgs e)
        {
            MakeProccesedUnProccesed(false);
        }

        private void MakeProccesedUnProccesed(bool check)
        {
            string value = check ? "1": "0";
            var sql = new Model();
            var correntRow = containesQueueData.CurrentRow;
            if (correntRow != null)
            {
                sql.UpdateRecord<ContainerQueue>((long)correntRow.Cells[0].Value, "Processed", value);
                ReloadQueueData();
            }
        }

        #endregion

        private void dataRegistry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = e.ColumnIndex;
            var correntRow = dataRegistry.CurrentRow;
            if (correntRow != null)
            {
                var value = correntRow.Cells[columnIndex].Value.ToString();
                var sql = new Model();
                switch (columnIndex)
                {
                    case 1:
                        //call organization
                        var org = sql.FindinTable<Organization>("Name", value).FirstOrDefault();
                        var form1 = new OrganizationSingle(org);
                        form1.ShowDialog();
                        break;
                    case 2:
                        //call contract
                        var contract = sql.FindinTable<Contract>("ContractNumber", value).FirstOrDefault();
                        var form2 = new ContractSingle(contract);
                        form2.ShowDialog();
                        break;
                }
            }
        }
    }

}
