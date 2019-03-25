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
            OrgGridView.AllowUserToAddRows = false;
            
            var sql = new SqLiteHelper();
            var allOrg = sql.FindinTable<Organization>();

            OrgGridView.DataSource = allOrg;


            //foreach (var org in allOrg)
            //{   
            //    DataRow dr = dt.NewRow();
            //    dr["Id"] = "Select Student Name";
            //    dt.Rows.InsertAt(dr, 0);

            //}
        }

        private void OrgGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
