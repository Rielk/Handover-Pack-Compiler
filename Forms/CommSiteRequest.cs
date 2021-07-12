using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handover_Pack_Compiler
{
    public partial class CommSiteRequest : Form
    {
        public CommSiteRequest(string message)
        {
            InitializeComponent();
            MessageText.Text = message;
            CommSiteButton.Value = Properties.Settings.Default.CommSitePath;
            CommSiteButton.InitialPathFunction = DefaultPath.CommSite;
        }

        private void CommSiteButton_ValueUpdate(object sender, EventArgs e)
        {
            Properties.Settings.Default.CommSitePath = CommSiteButton.Value;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
