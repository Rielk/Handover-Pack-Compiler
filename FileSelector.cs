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
    public partial class FileSelector : UserControl
    {
        public string Value
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }
        public int? DefaultFolder = null;
        public string Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        public FileSelector()
        {
            InitializeComponent();
            Value = "";
        }
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Value updates")]
        public event EventHandler ValueUpdate;

        private void Button_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = Filter;
            file_dialog.FilterIndex = 0;
            file_dialog.InitialDirectory = DefaultPath.CustomerFile(Value, DefaultFolder);
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                Value = file_dialog.FileName;
                ValueUpdate?.Invoke(this, e);
            }
        }
    }
}
