using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting.Forms
{
    public partial class NewRegistry : Form
    {
        protected List<Organization> ActiveOrg;
        protected long SelectedOrg;
        protected Contract SelectedContract;
        protected List<ContainerType> AllContainerTypes;
        protected List<Platform> AllPlatforms = new List<Platform>();
        
        protected List<OrganizationContainer> OrganizationContainers = new List<OrganizationContainer>();
        protected Model Sql;
        
        
        public NewRegistry()
        {
            InitializeComponent();
        }

        private void NewRegistry_Load(object sender, EventArgs e)
        {
            Sql = new Model();
            ActiveOrg = Sql.FindinTable<Organization>("Active", "1").ToList();

            if (!ActiveOrg.Any())
            {
                MessageBox.Show(@"Нет активных организаций");
                DialogResult = DialogResult.Abort;
                Close();
            }
            string[] temp = ActiveOrg.Select(ao => ao.Name).ToArray();
            // ReSharper disable once CoVariantArrayConversion
            selectOrganization.Items.AddRange(temp);
            EnableControls(false);

            var alldrivers = Sql.FindinTable<Driver>().Select(dr => dr.Name).ToArray();
            // ReSharper disable once CoVariantArrayConversion
            selectDriver.Items.AddRange(alldrivers);

            var cars = Sql.FindinTable<Car>().Select(cr => cr.Name).ToArray();
            // ReSharper disable once CoVariantArrayConversion
            selectCar.Items.AddRange(cars);

            AllContainerTypes = Sql.FindinTable<ContainerType>();
        }

        private void selectOrganization_SelectedValueChanged(object sender, EventArgs e)
        {
            Organization first = null;
            foreach (var ao in ActiveOrg)
            {
                if (ao.Name.Equals(selectOrganization.Text))
                {
                    first = ao;
                    break;
                }
            }

            if (first != null) SelectedOrg = first.Id;
            UnlockContracts();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UnlockContracts();
        }

        private void UnlockContracts()
        {
            ResetControls();
            var pd = processDate.Value.Date;
            var pdString = pd.ToString("yyyy-MM-dd");
            var sqlCommand = @"SELECT ContractNumber FROM Contracts " +
                             $"WHERE '{pdString}' >= FromDate " +
                             $"AND '{pdString}' <= ToDate " +
                             $"AND Organization = {SelectedOrg} " +
                             @"AND ProcessedVolume < TargetVolume";

            var allContracts = Sql.ExecuteTextCommand(sqlCommand);
            if (allContracts.Any())
            {
                OrganizationContainers.Clear();
                contractSelect.Items.Clear();
                foreach (var value in allContracts)
                {   
                    contractSelect.Items.Add(value);
                }

                selectPlatform.Items.Clear();
                OrganizationContainers = Sql.FindinTable<OrganizationContainer>("Organization", SelectedOrg.ToString());

                var allAddresses = new List<string>();

                foreach (var cont in OrganizationContainers)
                {
                    if (!AllPlatforms.Any() || AllPlatforms.All(apt => apt.Id != cont.Platform))
                    {
                        AllPlatforms.AddRange(Sql.FindinTable<Platform>((int)cont.Platform));
                    }
                    allAddresses.Add(AllPlatforms.Find(ap => ap.Id == cont.Platform).Address);
                }

                // ReSharper disable once CoVariantArrayConversion
                selectPlatform.Items.AddRange(allAddresses.Distinct().ToArray());

                EnableControls(true);
            }
            else
            {
                EnableControls(false);
            }
        }

        private void ResetControls()
        {
            quantity.Visible = false;
            quntityLabel.Visible = false;
            selectPlatform.Items.Clear();
            selectPlatform.ResetText();
            selectContainer.Items.Clear();
            selectContainer.ResetText();
            selectDriver.ResetText();
            selectCar.ResetText();
            contractSelect.ResetText();
            processedVolume.ResetText();
            targetVolume.ResetText();
            container.ResetText();
            //platform.ResetText();
        }

        private void EnableControls(bool enable)
        {
            selectPlatform.Enabled = enable;
            selectContainer.Enabled = enable;
            selectDriver.Enabled = enable;
            selectCar.Enabled = enable;
            contractSelect.Enabled = enable;
            saveNewRegistry.Enabled = enable;

        }

        private void contractSelect_SelectedValueChanged(object sender, EventArgs e)
        {   
            SelectedContract = Sql.FindinTable<Contract>("ContractNumber", contractSelect.Text).FirstOrDefault();
            if (SelectedContract != null)
            {
                targetVolume.Text = SelectedContract.TargetVolume.ToString(CultureInfo.InvariantCulture);
                processedVolume.Text = SelectedContract.ProcessedVolume.ToString(CultureInfo.InvariantCulture);
            }
        }


        private void saveNewRegistry_Click(object sender, EventArgs e)
        {
            if (!CheckSave()) return;

            var tv = Single.Parse(targetVolume.Text, CultureInfo.InvariantCulture);
            var pv = Single.Parse(processedVolume.Text, CultureInfo.InvariantCulture);
            var av = Single.Parse(container.Text, CultureInfo.InvariantCulture);

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (av == 0)
            {
                MessageBox.Show(@"Нельзя вывести ничего");
                return;
            }

            if (pv + av > tv)
            {
                MessageBox.Show(@"Превышен запланированный объем");
                return;
            }

            long selectedCont = AllContainerTypes.Find(ac => ac.Name.Equals(selectContainer.Text)).Id;
            long selectedPlatform = AllPlatforms.Find(ap => ap.Address.Equals(selectPlatform.Text)).Id;
            long selectedDriver = Sql.FindinTable<Driver>().Find(dr => dr.Name.Equals(selectDriver.Text)).Id;
            long selectedCar = Sql.FindinTable<Car>().Find(cr => cr.Name.Equals(selectCar.Text)).Id;

            var newRecord = new Registry
            {
                Organization = SelectedOrg,
                Contract = SelectedContract.Id,
                Container = selectedCont,
                Platform = selectedPlatform,
                Driver = selectedDriver,
                Car = selectedCar,
                Volume = av,
                Entered = processDate.Value
            };

            var result = Sql.WriteToDb(newRecord);
            if (result != 1)
            {
                MessageBox.Show(@"Ошибка сохранения");
                return;
            }

            var tempOrgCont = new OrganizationContainer
            {
                Organization = SelectedOrg,
                Container = selectedCont,
                Platform = selectedPlatform
            };

            var orgConts = Sql.FindinTable(tempOrgCont);

            foreach (var orgCont in orgConts)
            {
                var sqlCommand = $"SELECT Id " +
                                 $"FROM ContainersQueue " +
                                 // ReSharper disable once PossibleNullReferenceException
                                 $"WHERE Container = '{orgCont.Id}' " +
                                 $"AND Dayspast = '0' " +
                                 $"AND Processed = '0'";

                var unprocessedCont = Sql.ExecuteTextCommand(sqlCommand);

                if (unprocessedCont.Any())
                {
                    result = Sql.UpdateRecord<ContainerQueue>((long)unprocessedCont[0], "Processed", "1");
                    if (result != 1) MessageBox.Show(@"Не получилось обновить очередь контейнеров");
                    break;
                }
            }

            result = Sql.UpdateRecord<Contract>(SelectedContract.Id, "ProcessedVolume",
                (pv + av).ToString(CultureInfo.InvariantCulture));

            if (result != 1) MessageBox.Show(@"Не получилось обновить договор");

            DialogResult = DialogResult.Yes;
            Close();
        }


        private bool CheckSave()
        {

            if (String.IsNullOrEmpty(selectOrganization.Text))
            {
                MessageBox.Show(@"Выберете организацию");
                return false;
            }

            if (String.IsNullOrEmpty(contractSelect.Text))
            {
                MessageBox.Show(@"Выберете договор");
                return false;
            }

            if (String.IsNullOrEmpty(selectPlatform.Text))
            {
                MessageBox.Show(@"Выберете площадку");
                return false;
            }

            if (String.IsNullOrEmpty(selectContainer.Text))
            {
                MessageBox.Show(@"Выберете контейнер");
                return false;
            }

            if (String.IsNullOrEmpty(selectDriver.Text))
            {
                MessageBox.Show(@"Выберете водителя");
                return false;
            }

            if (String.IsNullOrEmpty(selectCar.Text))
            {
                MessageBox.Show(@"Выберете машину");
                return false;
            }

            if (String.IsNullOrEmpty(selectCar.Text))
            {
                MessageBox.Show(@"Выберете машину");
                return false;
            }

            if (String.IsNullOrEmpty(selectCar.Text))
            {
                MessageBox.Show(@"Выберете машину");
                return false;
            }

            return true;
        }
        private void selectPlatform_SelectedValueChanged(object sender, EventArgs e)
        {
            selectContainer.Items.Clear();
            selectContainer.ResetText();
            container.ResetText();
            quantity.Visible = false;
            quantity.Text = 0.ToString();
            quntityLabel.Visible = false;

            var selectedPlatformId = AllPlatforms.Find(ap => ap.Address.Equals(selectPlatform.Text)).Id;
            var allContainer = OrganizationContainers.Where(oc => oc.Platform == selectedPlatformId)
                .Select(oc => oc.Container).Distinct();
            var allTypes = new List<string>();
            foreach (var cont in allContainer)
            {
                allTypes.Add(AllContainerTypes.Find(act=>act.Id==cont).Name);
            }
            // ReSharper disable once CoVariantArrayConversion
            selectContainer.Items.AddRange(allTypes.Distinct().ToArray());
        }

        private void selectContainer_SelectedValueChanged(object sender, EventArgs e)
        {
            var cont = AllContainerTypes.Find(act => act.Name.Equals(selectContainer.Text));
            if (cont.Multiple)
            {
                quantity.Visible = true;
                quntityLabel.Visible = true;
                container.Text = 0.ToString();
            }
            else
            {
                quantity.Visible = false;
                quntityLabel.Visible = false;
                container.Text = cont.Volume.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            if (quantity.Visible)
            {
                var volume = AllContainerTypes.Find(act => act.Name.Equals(selectContainer.Text)).Volume;
                Single.TryParse(quantity.Text, out float fResult);
                container.Text = (volume * fResult).ToString(CultureInfo.InvariantCulture);
            }

        }
    }
}
