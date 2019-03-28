using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;

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
            var sql = new SqLiteHelper();
            var allContainers = sql.FindinTable<OrganizationContainer>((int) Org.Id);
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
                row.Cells[3].Value = value.Schedule;
                orgContData.Rows.Add(row);
            }
        }

        private void addContainer_Click(object sender, EventArgs e)
        {
            var form = new AddNewContainer(Org);
            form.ShowDialog();
        }
    }
}
