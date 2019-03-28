using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting.Forms
{
    public partial class AddNewContainer : Form
    {
        protected Organization Org;
        protected List<Platform> AllPlatforms;
        public AddNewContainer(Organization org)
        {
            Org = org;
            InitializeComponent();
        }

        private void AddNewContainer_Load(object sender, EventArgs e)
        {
            var sql = new SqLiteHelper();
            AllPlatforms = sql.FindinTable<Platform>();
            string[] temp = AllPlatforms.Select(ap => ap.Address).ToArray();
            // ReSharper disable once CoVariantArrayConversion
            selectPlatform.Items.AddRange(temp);
        }

        private void selectPlatform_DropDown(object sender, EventArgs e)
        {
            selectPlatform.Items.Clear();
            var tempAllPlatforms = AllPlatforms.Where(ap => ap.Address.ToLowerInvariant().Contains(selectPlatform.Text.ToLowerInvariant())).ToList();
            // ReSharper disable once CoVariantArrayConversion
            selectPlatform.Items.AddRange(tempAllPlatforms.Select(ap => ap.Address).ToArray());
        }
    }
}
