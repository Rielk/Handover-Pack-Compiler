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
    public partial class NewPackNumberRequest : Form
    {
        public string Result;
        public NewPackNumberRequest()
        {
            InitializeComponent();
            ActiveControl = NumberBox;
            Result = "0000";
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NumberBox.TextLength < 4)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (NumberBox.TextLength == 4)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void OkButt_Click(object sender, EventArgs e)
        {
            Result = NumberBox.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
