using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting.Forms
{
    public partial class ContractsAll : Form
    {
        protected Organization Org;
        protected bool Changed;
        public ContractsAll(Organization org)
        {
            Org = org;
            InitializeComponent();
        }

        private void ContractsAll_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            companyContracts.Rows.Clear();
            var sql = new Model();
            var allContracts = sql.FindinTable<Contract>("Organization", Org.Id.ToString());

            foreach (var value in allContracts)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(companyContracts);

                row.Cells[0].Value = value.Id;
                row.Cells[1].Value = value.ContractNumber;
                row.Cells[2].Value = value.FromDate;
                row.Cells[3].Value = value.ToDate;
                row.Cells[4].Value = value.TargetVolume;
                row.Cells[5].Value = value.ProcessedVolume;

                companyContracts.Rows.Add(row);
            }
            companyContracts.Sort(companyContracts.Columns[0],ListSortDirection.Ascending);
        }

        private Contract SelectedContract()
        {
            var row = companyContracts.CurrentRow;
            if (row != null)
            {
                var sql = new Model();
                var id = (long)row.Cells[0].Value;
                var contract = sql.FindinTable<Contract>((int)id).FirstOrDefault();
                return contract;
            }
            return null;
        }

        private void newContract_Click(object sender, EventArgs e)
        {
            var form = new ContractSingle(Org);
            var result = form.ShowDialog();
            if (result == DialogResult.Yes || result == DialogResult.No)
            {
                UpdateTable();
                DialogResult = DialogResult.OK;
            }
            //DialogResult = result;
        }

        private void companyContracts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var form = new ContractSingle(SelectedContract());
            var result = form.ShowDialog();
            if (result == DialogResult.Yes || result == DialogResult.No)
            {
                UpdateTable();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
