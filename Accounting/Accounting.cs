using System;
using System.Timers;
using System.Windows.Forms;
using Accounting.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting
{
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();

            double interval = 150000.0;
            // ReSharper disable once UseObjectOrCollectionInitializer
            var aTimer = new System.Timers.Timer(interval)
            {
                AutoReset = false,
                Enabled = true
            };
            aTimer.Elapsed += OnTimedEvent;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            var sql = new PrepareAccounting();
            sql.PrepareDb(false);
        }

        private void Accounting_Load(object sender, EventArgs e)
        {
            var sql = new PrepareAccounting();
            sql.PrepareDb(true);

        }

        private void Organizations_Click(object sender, EventArgs e)
        {
            OrganizationsAll form = new OrganizationsAll();
            Hide();
            form.ShowDialog(this);
            Show();
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
