using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void Accounting_Load(object sender, EventArgs e)
        {

        }

        private void Organizations_Click(object sender, EventArgs e)
        {
            OrgForm form = new OrgForm();
            this.Hide();
            form.ShowDialog(this);
            this.Show();
        }
    }
}
