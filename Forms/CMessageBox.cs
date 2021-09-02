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
    public partial class CMessageBox : Form
    {
        public CMessageBox(string title, string message, string YesButtonText, string NoButtonText)
        {
            InitializeComponent();
            this.Text = title;
            MessageText.Text = message;
            if (YesButtonText == null)
            {
                YesButton.Visible = false;
            }
            else
            {
                YesButton.Text = YesButtonText;
            }
            if (NoButtonText == null)
            {
                NoButton.Visible = false;
            }
            else
            {
                NoButton.Text = NoButtonText;
            }
            this.Size = new Size(297, MessageText.Height + 80);
        }

        public static DialogResult Show(string title, string message, string YesButtonText, string NoButtonText, Form OwnerForm)
        {
            CMessageBox MBox = new CMessageBox(title, message, YesButtonText, NoButtonText)
            {
                Owner = OwnerForm
            };
            MBox.ShowDialog();
            return MBox.DialogResult;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
