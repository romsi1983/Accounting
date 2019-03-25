using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting
{
    public partial class OrgForm : Form
    {
        public OrgForm()
        {
            InitializeComponent();
        }

        private void OrgForm_Load(object sender, EventArgs e)
        {
            this.Location = Owner.Location;
            this.Size = Owner.Size;
            OrgGridView.AllowUserToAddRows = false;
            OrgGridView.AllowUserToDeleteRows = false;
            OrgGridView.ReadOnly = true;

            var sql = new SqLiteHelper();
            var allOrg = sql.FindinTable<Organization>();
            
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            OrgGridView.Columns.Add(chk);
            chk.HeaderText = "Активный";
            chk.Name = "chk";

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

        private void OrgGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
