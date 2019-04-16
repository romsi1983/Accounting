using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting.Forms
{
    public partial class ViewCurrentPlatform : Form
    {
        protected Platform Platform;
        protected System.Data.DataTable PfDataTable = new System.Data.DataTable();
        public ViewCurrentPlatform(Platform platform)
        {
            Platform = platform;
            InitializeComponent();
        }

        private void ViewCurrentPlatform_Load(object sender, EventArgs e)
        {   
            PfDataTable.Columns.Add("Id", typeof(long));
            PfDataTable.Columns.Add("Организация", typeof(string));
            PfDataTable.Columns.Add("Тип Контейнера", typeof(string));
            PfDataTable.Columns.Add("Объем", typeof(float));
            PfDataTable.Columns.Add("Расписание", typeof(string));
            pfContData.DataSource = PfDataTable;
            pfContData.Columns[0].Visible = false;
            ReloadPfDataTable();

            Text = $"Детализация по площадке {Platform.Address}";
        }

        [Localizable(false)]
        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void ReloadPfDataTable()
        {
            PfDataTable.Rows.Clear();

            var sql = new Model();
            var orgs = new List<Organization>();
            var contypes = sql.FindinTable<ContainerType>();
            var allOrgConts = sql.FindinTable<OrganizationContainer>("Platform", Platform.Id.ToString());

            foreach (var value in allOrgConts)
            {
                if (orgs.All(org => org.Id != value.Organization)) orgs.AddRange(sql.FindinTable<Organization>((int)value.Organization));
                
                DataRow row = PfDataTable.NewRow();
                row[0] = value.Id;
                row[1] = orgs.Find(x => x.Id == value.Organization).Name;
                var tempCont = contypes.Find(x => x.Id == value.Container);
                row[2] = tempCont.Name;
                row[3] = tempCont.Volume;
                row[4] = ParseShedule(value.Schedule);
                PfDataTable.Rows.Add(row);
            }
        }

        private string ParseShedule(string shedule)
        {
            var ps = String.Empty;
            if (shedule == null) return ps;
            foreach (var value in shedule.Split(';'))
            {
                switch (int.Parse(value))
                {
                    case 1:
                        ps = ps + "ПН,";
                        break;
                    case 2:
                        ps = ps + "ВТ,";
                        break;
                    case 3:
                        ps = ps + "СР,";
                        break;
                    case 4:
                        ps = ps + "ЧТ,";
                        break;
                    case 5:
                        ps = ps + "ПТ,";
                        break;
                    case 6:
                        ps = ps + "СБ,";
                        break;
                    case 7:
                        ps = ps + "ВС,";
                        break;
                }
            }

            ps = ps.Substring(0, ps.Length - 1);
            return ps;
        }
    }
}
