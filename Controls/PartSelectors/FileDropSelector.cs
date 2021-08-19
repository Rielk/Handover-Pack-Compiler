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
    public partial class FileDropSelector : UserControl
    {
        public string Value
        {
            get { return CSPath.FullPath; }
        }
        public List<string> AllOptions
        {
            get
            {
                List<string> ret = new List<string>();
                foreach (string ext in DropBox.Items)
                {
                    ret.Add(Path.Combine(PackPaths.CustomerFolder, ext));
                }
                return ret;
            }
        }
        public string SelectedOption
        {
            get { return (string)DropBox.SelectedItem; }
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
                DropBox.Enabled = !value;
                Button.Enabled = !value;
            }
        }
        public FileDropSelector()
        {
            InitializeComponent();
            DropBox.SelectedItem = "Other...";
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
                AddOption(file_dialog.FileName, true);
                ValueUpdate?.Invoke(this, null);
            }
        }

        public void AddOption(string option, bool select = false)
        {
            var item = DropBox.SelectedItem;
            string str = PackPaths.CustomerFolderExtension(option);
            DropBox.Items.Add(str);
            if (select)
            {
                DropBox.SelectedItem = str;
            }
            else
            {
                DropBox.SelectedItem = item;
            }
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

        private void DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)DropBox.SelectedItem == "Other...")
            {
                CSPath.FullPath = null;
                RemoveButton.Enabled = false;
            }
            else if ((string)DropBox.SelectedItem == "None")
            {
                CSPath.FullPath = null;
                RemoveButton.Enabled = false;
            }
            else
            {
                CSPath.FullPath = Path.Combine(PackPaths.CustomerFolder, (string)DropBox.SelectedItem);
                RemoveButton.Enabled = true;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if ((string)DropBox.SelectedItem != "Other..." | (string)DropBox.SelectedItem != "None")
            {
                DropBox.Items.Remove(DropBox.SelectedItem);
                DropBox.SelectedItem = "Other...";
                ValueUpdate?.Invoke(this, null);
            }
        }
    }
}
