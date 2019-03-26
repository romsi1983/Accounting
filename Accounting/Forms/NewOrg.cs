using System;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting.Forms
{
    public partial class NewOrg : Form
    {
        private readonly Organization _org;
        private readonly bool _edit;
        public NewOrg(Organization org = null)
        {
            _org = org;
            _edit = org != null;
            InitializeComponent();
        }

        private void NewOrg_Load(object sender, EventArgs e)
        {
            if (_edit)
            {
                Active.Checked = _org.Active;
                Address.Text = _org.Address;
                City.Text = _org.City;
                OrgName.Text = _org.Name;
                Phone.Text = _org.Phone;
                Comment.Text = _org.Comment;
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

            if (_edit) org.Id = _org.Id;

            var sql = new SqLiteHelper();
            int result = _edit ? sql.UpdateDb(org) : sql.WriteToDb(org);
            if (result != 1)
            {
                throw new Exception("Ошибка сохранения");
            }
            Close();
        }
    }
}
