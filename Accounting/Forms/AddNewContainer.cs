using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting.Forms
{
    public partial class AddNewContainer : Form
    {
        protected Organization Org;
        protected List<Platform> AllPlatforms;
        protected List<ContainerType> AllContainers;
        public AddNewContainer(Organization org)
        {
            Org = org;
            InitializeComponent();
        }

        private void AddNewContainer_Load(object sender, EventArgs e)
        {
            var sql = new Model();
            AllPlatforms = sql.FindinTable<Platform>();
            string[] temp = AllPlatforms.Select(ap => ap.Address).ToArray();
            // ReSharper disable once CoVariantArrayConversion
            selectPlatform.Items.AddRange(temp);
            AllContainers = sql.FindinTable<ContainerType>();
            // ReSharper disable once CoVariantArrayConversion
            selectContainerType.Items.AddRange(AllContainers.Select(ac => ac.Name).ToArray());

        }

        private void selectPlatform_DropDown(object sender, EventArgs e)
        {
            selectPlatform.Items.Clear();
            var tempAllPlatforms = AllPlatforms.Where(ap => ap.Address.ToLowerInvariant().Contains(selectPlatform.Text.ToLowerInvariant())).ToList();
            // ReSharper disable once CoVariantArrayConversion
            selectPlatform.Items.AddRange(tempAllPlatforms.Select(ap => ap.Address).ToArray());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var sql = new Model();
            var selectedPlatform = selectPlatform.Text;
            var selectedContainer = selectContainerType.Text;
            var pf = sql.FindinTable<Platform>("Address", selectedPlatform).FirstOrDefault();

            if (pf == null)
            {
                MessageBox.Show(@"Платформа не выбрана");
                return;
            }
            var ct = sql.FindinTable<ContainerType>("Name", selectedContainer).FirstOrDefault();

            if (ct == null)
            {
                MessageBox.Show(@"Контейнер не выбран");
                return;
            }

            string schedule = string.Empty;
            if (monday.Checked) schedule = "1;";
            if (tuesday.Checked) schedule = schedule + "2;";
            if (wednesday.Checked) schedule = schedule + "3;";
            if (thersday.Checked) schedule = schedule + "4;";
            if (friday.Checked) schedule = schedule + "5;";
            if (satuday.Checked) schedule = schedule + "6;";
            if (sunday.Checked) schedule = schedule + "7;";
            if (!String.IsNullOrEmpty(schedule))
            {
                schedule = schedule.TrimEnd(';');
            }

            

            Debug.Assert(ct != null, nameof(ct) + " != null");
            Debug.Assert(pf != null, nameof(pf) + " != null");
            var orgCont = new OrganizationContainer
            {
                Organization = Org.Id,
                Container = ct.Id,
                Platform = pf.Id,
                Schedule = schedule
            };

            sql.WriteToDb(orgCont);

            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
