using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Accounting.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var rkey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            var myKey = rkey.OpenSubKey("Software")?.OpenSubKey("ContainerAccounting");

            if (myKey != null)
            {
                var rDbPath = myKey.GetValue("dbPath");
                if (rDbPath!=null)
                {
                    dbPath.Text = rDbPath.ToString();
                    return;
                }
            }

            dbPath.Text = "Путь к базе не задан";
        }

        private void changeDbPath_Click(object sender, EventArgs e)
        {
            findDB.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            findDB.DefaultExt = "db";
            findDB.Filter = "database files (*.db)|*.db";
            findDB.ShowDialog();
            dbPath.Text = findDB.FileName;
        }

        private void findDB_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            var rkey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            var myKey = rkey.OpenSubKey("Software",true)?.OpenSubKey("ContainerAccounting",true);
            if (myKey==null)
            {
                rkey.OpenSubKey("Software",true).CreateSubKey("ContainerAccounting");
                myKey = rkey.OpenSubKey("Software",true)?.OpenSubKey("ContainerAccounting",true);
            }
            myKey.SetValue("dbPath",dbPath.Text,RegistryValueKind.String);
        }
    }
}
