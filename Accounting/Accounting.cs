using System;
using System.Windows.Forms;
using Accounting.Forms;
using Accounting.Models;

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
            Hide();
            form.ShowDialog(this);
            Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Containers_Click(object sender, EventArgs e)
        {
            var form = new Generic<ContainerType>();
            form.ShowDialog();
        }

        private void platforms_Click(object sender, EventArgs e)
        {
            var form = new Generic<Platform>();
            form.ShowDialog();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            var form = new Generic<Driver>();
            form.ShowDialog();
        }

        private void Cars_Click(object sender, EventArgs e)
        {
            var form = new Generic<Car>();
            form.ShowDialog();
        }
    }
}
