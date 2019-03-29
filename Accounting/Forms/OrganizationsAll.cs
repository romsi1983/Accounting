using System;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting.Forms
{
    public partial class OrganizationsAll : Form
    {
        public OrganizationsAll()
        {
            InitializeComponent();
        }

        private void OrgForm_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Size = Owner.Size;
            OrgGridView.AllowUserToAddRows = false;
            OrgGridView.AllowUserToDeleteRows = false;
            OrgGridView.ReadOnly = true;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            OrgGridView.Columns.Add(chk);
            // ReSharper disable once LocalizableElement
            chk.HeaderText = "Активный";
            chk.Name = "chk";
            RenewDataTable();
        }

        private void OrgGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new OrganizationSingle(SelectedOrganization());
            var result = form.ShowDialog();
            if (result == DialogResult.Yes) RenewDataTable();
        }

        private Organization SelectedOrganization()
        {
            var row = OrgGridView.CurrentRow;
            if (row != null)
            {
                var sql = new SqLiteHelper();
                var id = (long) row.Cells[0].Value;
                var org = sql.FindinTable<Organization>((int) id).FirstOrDefault();
                return org;
            }

            return null;
        }


        private void NewCompany_Click(object sender, EventArgs e)
        {
            OrganizationSingle form = new OrganizationSingle();
            var result = form.ShowDialog();
            Show();
            if (result == DialogResult.Yes) RenewDataTable();
        }


        private void RenewDataTable()
        {
            OrgGridView.Rows.Clear();
            var sql = new SqLiteHelper();
            var allOrg = sql.FindinTable<Organization>();
            foreach (var org in allOrg)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(OrgGridView);
                row.Cells[0].Value = org.Id;
                row.Cells[1].Value = org.Name;
                row.Cells[2].Value = org.City;
                row.Cells[3].Value = org.Address;
                row.Cells[4].Value = org.Phone;
                row.Cells[5].Value = org.Active;
                OrgGridView.Rows.Add(row);
            }

        }


        private void orgContainers_Click(object sender, EventArgs e)
        {
            var form = new OrganizationContainers(SelectedOrganization());
            form.ShowDialog();
        }

        private void OrgConracts_Click(object sender, EventArgs e)
        {
            var form = new ContractsAll(SelectedOrganization());
            form.Show();
            RenewDataTable();
        }
    }
}
