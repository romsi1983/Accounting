using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting.Forms
{
    public partial class ViewCurrentPlatform : Form
    {
        protected long PlatformId;
        public ViewCurrentPlatform(long platformId)
        {
            PlatformId = platformId;
            InitializeComponent();
        }

        private void ViewCurrentPlatform_Load(object sender, EventArgs e)
        {

        }
    }
}
