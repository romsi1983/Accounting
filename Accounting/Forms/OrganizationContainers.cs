using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting.Forms
{
    public partial class OrganizationContainers : Form
    {
        protected Organization Org;

        public OrganizationContainers(Organization org)
        {
            Org = org;
            InitializeComponent();
        }

        private void OrganizationContainers_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void addContainer_Click(object sender, EventArgs e)
        {
            var form = new AddNewContainer(Org);
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            orgContData.Rows.Clear();
            var sql = new Model();
            var allContainers = sql.FindinTable<OrganizationContainer>("Organization",Org.Id.ToString());
            var allPlatforms = new List<Platform>();
            var allConTypes = sql.FindinTable<ContainerType>();

            foreach (var value in allContainers)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(orgContData);
                if (allPlatforms.All(pt => pt.Id != value.Platform))
                {
                    allPlatforms.Add(sql.FindinTable<Platform>((int)value.Platform).FirstOrDefault());
                }

                row.Cells[0].Value = value.Id;
                row.Cells[1].Value = allConTypes.Find(ac => ac.Id == value.Container).Name;
                row.Cells[2].Value = allPlatforms.Find(ap => ap.Id == value.Platform).Address;
                var scheduleValues = value.Schedule.Split(';');
                var schedulValue = String.Empty;
                foreach (var tempValue in scheduleValues)
                {
                    switch (tempValue)
                    {
                        case "1":
                            schedulValue = schedulValue + "ПН, ";
                            break;
                        case "2":
                            schedulValue = schedulValue + "ВТ, ";
                            break;
                        case "3":
                            schedulValue = schedulValue + "СР, ";
                            break;
                        case "4":
                            schedulValue = schedulValue + "ЧТ, ";
                            break;
                        case "5":
                            schedulValue = schedulValue + "ПТ, ";
                            break;
                        case "6":
                            schedulValue = schedulValue + "СБ, ";
                            break;
                        case "7":
                            schedulValue = schedulValue + "ВС, ";
                            break;

                    }
                }

                if (!String.IsNullOrEmpty(schedulValue))
                {
                    schedulValue = schedulValue.Substring(0, schedulValue.Length - 2);
                }

                row.Cells[3].Value = schedulValue;
                orgContData.Rows.Add(row);
            }
        }

        private void deleteContainer_Click(object sender, EventArgs e)
        {
            var sql = new Model();
            var correntRow = orgContData.CurrentRow;
            if (correntRow != null)
            {
                sql.DeleteFromTable<OrganizationContainer>((long)correntRow.Cells[0].Value);
                UpdateTable();
            }
        }
    }
}
