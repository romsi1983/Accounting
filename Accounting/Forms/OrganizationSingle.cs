using System;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;
using Accounting.SQLite;

namespace Accounting.Forms
{
    public partial class OrganizationSingle : Form
    {
        protected Organization Org;
        protected bool Edit;
        public OrganizationSingle(Organization org = null)
        {
            Org = org;
            if (org != null)
            {
                Edit = true;
                //Text = $@"Редактирование оргнаизации {org.Name}";
            }

            InitializeComponent();
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
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
                Text = $@"Редактирование организации '{Org.Name}'";
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

            var sql = new Model();

            if (!Edit&&sql.FindinTable<Organization>("Name",org.Name).Any())
            {
                // ReSharper disable once LocalizableElement
                MessageBox.Show($"Организация '{org.Name}' уже существует");
                return;
            }
            int result = Edit ? sql.UpdateDb(org) : sql.WriteToDb(org);
            if (result != 1)
            {
                throw new Exception("Ошибка сохранения");
            }

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void containers_Click(object sender, EventArgs e)
        {
            var form = new OrganizationContainers(Org);
            form.ShowDialog();
        }

        private void contracts_Click(object sender, EventArgs e)
        {
            var form = new ContractsAll(Org);
            form.ShowDialog();
        }
    }
}
