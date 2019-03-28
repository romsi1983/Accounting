using System;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting.Forms
{
    public partial class OrganizationSingle : Form
    {
        protected Organization Org;
        protected bool Edit;
        public OrganizationSingle(Organization org = null)
        {
            Org = org;
            Edit = org != null;
            InitializeComponent();
        }

        private void NewOrg_Load(object sender, EventArgs e)
        {
            if (Edit)
            {
                Active.Checked = Org.Active;
                Address.Text = Org.Address;
                City.Text = Org.City;
                OrgName.Text = Org.Name;
                Phone.Text = Org.Phone;
                Comment.Text = Org.Comment;
            }
            else
            {
                contracts.Visible = false;
                containers.Visible = false;
            }
        }

        private void OrgAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            var org = new Organization
            {
                Active = Active.Checked,
                Address = Address.Text,
                City = City.Text,
                Name = OrgName.Text,
                Phone = Phone.Text,
                Comment = Comment.Text
            };

            if (Edit) org.Id = Org.Id;

            var sql = new SqLiteHelper();
            var tempOrg = new Organization
            {
                Name = org.Name
            };
            if (sql.FindinTable(tempOrg).Any())
            {
                // ReSharper disable once LocalizableElement
                MessageBox.Show($"Organization with name '{org.Name}' already exists");
                return;
            }
            int result = Edit ? sql.UpdateDb(org) : sql.WriteToDb(org);
            if (result != 1)
            {
                throw new Exception("Ошибка сохранения");
            }
            Close();
        }

        private void containers_Click(object sender, EventArgs e)
        {
            var form = new OrganizationContainers(Org);
            form.ShowDialog();
        }
    }
}
