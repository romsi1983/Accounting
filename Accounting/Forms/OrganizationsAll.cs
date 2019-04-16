using System;
using System.Linq;
using System.Windows.Forms;
using Accounting.DataTable;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting.Forms
{
    public partial class OrganizationsAll : Form
    {
        protected DataTableModel<Organization> OrganizationsData;
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

            OrganizationsData = new DataTableModel<Organization>(null);
            OrgGridView.DataSource = OrganizationsData.GetDataTable();

            foreach (DataGridViewColumn col in OrgGridView.Columns)
            {
                col.HeaderText = OrganizationsData.GetDataTable().Columns[col.HeaderText].Caption;
            }

            OrgGridView.Columns[0].Visible = false;

        }

        private void OrgGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new OrganizationSingle(SelectedOrganization());
            var result = form.ShowDialog();
            if (result == DialogResult.Yes) OrganizationsData.RenewDataTable();
        }

        private Organization SelectedOrganization()
        {
            var row = OrgGridView.CurrentRow;
            if (row != null)
            {
                var sql = new Model();
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
            if (result == DialogResult.Yes) OrganizationsData.RenewDataTable();
        }

        private void orgContainers_Click(object sender, EventArgs e)
        {
            var form = new OrganizationContainers(SelectedOrganization());
            form.ShowDialog();
        }

        private void OrgConracts_Click(object sender, EventArgs e)
        {
            var form = new ContractsAll(SelectedOrganization());
            var result = form.ShowDialog();
            if (result == DialogResult.OK) OrganizationsData.RenewDataTable();
        }

        private void orgFilter_TextChanged(object sender, EventArgs e)
        {
            OrganizationsData.GetDataTable().DefaultView.RowFilter = $"Name LIKE '%{orgFilter.Text}%'";
        }

        private void addressFilter_TextChanged(object sender, EventArgs e)
        {
            OrganizationsData.GetDataTable().DefaultView.RowFilter = $"Address LIKE '%{addressFilter.Text}%'";
        }
    }
}
