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
    public partial class FileUI : UserControl
    {
        public override string Text
        {
            get { return GroupBox.Text; }
            set { GroupBox.Text = value; }
        }
        public FileUI(Folder.File f)
        {
            InitializeComponent();
            if (f.AlwaysRequired)
            {
                RequiredCheckBox.Visible = false;
            }
            if (!f.AllowMultiple)
            {
                AddFileButton.Visible = false;
            }
            if (f.CSGenPaths.Count == 0)
            {
                AddFile();
            }
            else
            {
                foreach (string path in f.GenericPaths)
                {
                    AddFile(path);
                }
            }
        }
        private void AddFile()
        {
            AddFile("");
        }
        private void AddFile(string name)
        {
            FileSelector fs = new FileSelector
            {
                Value = name,
                Dock = DockStyle.Top
            };
            GroupBox.Controls.Add(fs);
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            AddFile();
        }
    }
}
