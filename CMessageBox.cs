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
            Text = title;
            MessageText.Text = message;
            YesButton.Text = YesButtonText;
            NoButton.Text = NoButtonText;
        }

        public static DialogResult Show(string title, string message, string YesButtonText, string NoButtonText)
        {
            CMessageBox MBox = new CMessageBox(title, message, YesButtonText, NoButtonText);
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
