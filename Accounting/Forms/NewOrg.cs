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
    public partial class NewOrg : Form
    {
        public NewOrg()
        {
            InitializeComponent();
        }

        private void NewOrg_Load(object sender, EventArgs e)
        {

        }

        private void OrgAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            var org = new Organization
            {
                Active = this.Active.Checked,
                Address = this.Address.Text,
                City = this.City.Text,
                Name = this.OrgName.Text,
                Phone = this.Phone.Text,
                Comment = this.Comment.Text
            };

            var sql = new SqLiteHelper();
            var result = sql.WriteToDb(org);

            this.Close();
        }
    }
}
