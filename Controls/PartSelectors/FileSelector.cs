using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            get { return CSPath.FullPath; }
            set
            {
                CSPath.FullPath = value;
                TextBox.Text = CSPath.FileName;
            }
        }
        public CommSitePath CSPath = new CommSitePath();
        public int? DefaultFolder = null;
        public string Filter = "All files (*.*)|*.*|PDF files (*.pdf)|*.pdf";
        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        public bool enbld = false;
        public bool ReadOnly
        {
            get { return !enbld; }
            set
            {
                enbld = !value;
                TextBox.Enabled = !value;
                Button.Enabled = !value;
                //OpenButton.Enabled = !value;
                RemoveButton.Enabled = !value;
            }
        }
        public FileSelector()
        {
            InitializeComponent();
            Value = "";
        }
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Value updates")]
        public event EventHandler ValueUpdate;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Value updates")]
        public event EventHandler RemoveThis;

        private void Button_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = Filter;
            file_dialog.FilterIndex = 0;
            file_dialog.InitialDirectory = DefaultPath.CustomerFile(Value, DefaultFolder);
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                Value = file_dialog.FileName;
                TextBox.Text = CSPath.FileName;
                ValueUpdate?.Invoke(this, null);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveThis?.Invoke(this, null);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Value))
            {
                Process.Start(Value);
            }
            else
            {
                MessageBox.Show("Can no longer find the file at \""+Value+"\". It may have been deleted or renamed.", "Something went wrong");
            }
        }
    }
}
