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
        public bool Complete = false;
        private readonly List<FileSelector> FileSelectors = new List<FileSelector>();
        private readonly Folder.File file;
        public override string Text
        {
            get { return GroupBox.Text.Trim(); }
            set { GroupBox.Text = "     " + value; }
        }
        public FileUI(Folder.File f)
        {
            InitializeComponent();
            file = f;
            if (f.AlwaysRequired)
            {
                RequiredCheckBox.Enabled = false;
                RequiredCheckBox.Visible = true;
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
                if (file.AllowMultiple)
                {
                    AddFile();
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
                Dock = DockStyle.Top,
                Padding = new Padding(4, 0, 4, 0),
                DefaultFolder = file.DefaultFolder
            };
            fs.ValueUpdate += FileSelector_ValueUpdate;
            fs.RemoveThis += FileSelector_RemoveThis;
            fs.MaximumSize = new Size(5000, fs.Height + 5);
            fs.MinimumSize = new Size(0, fs.Height + 5);
            GroupBox.Controls.Add(fs);
            FileSelectors.Add(fs);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height + 25);
            this.MinimumSize = new Size(0, this.MinimumSize.Height + 25);
        }

        private void UpdatePaths()
        {
            List<string> paths = new List<string>();
            foreach (FileSelector fs in FileSelectors)
            {
                if (fs.Value != "")
                {
                    paths.Add(fs.Value);
                }
            }
            file.GenericPaths = paths;
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            AddFile();
        }

        private void RequiredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in GroupBox.Controls)
            {
                c.Enabled = RequiredCheckBox.Checked;
            }
            Complete = !RequiredCheckBox.Checked;
        }

        private void FileSelector_ValueUpdate(object sender, EventArgs e)
        {
            if (FileSelectors[FileSelectors.Count - 1].Value != "" & file.AllowMultiple)
            {
                AddFile();
            }
            UpdatePaths();
        }

        private void FileSelector_RemoveThis(object sender, EventArgs e)
        {
            Remove_FileSelector((FileSelector)sender);
            if (FileSelectors.Count == 0 || FileSelectors[FileSelectors.Count - 1].Value != "")
            {
                AddFile();
            }
            UpdatePaths();
        }
        private void Remove_FileSelector(FileSelector fs)
        {
            (fs).Parent.Controls.Remove(fs);
            FileSelectors.Remove(fs);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height - 25);
            this.MinimumSize = new Size(0, this.MinimumSize.Height - 25);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Complete)
            {
                Complete = false;
                ConfirmButton.Text = "Confirm";
                foreach (FileSelector fs in FileSelectors.ToList())
                {
                    fs.ReadOnly = false;
                    if (file.AllowMultiple | FileSelectors.Count == 0)
                    {
                        AddFile();
                    }
                }
            }
            else
            {
                Complete = true;
                ConfirmButton.Text = "Edit";
                foreach (FileSelector fs in FileSelectors.ToList())
                {
                    if (fs.Value == "")
                    {
                        Remove_FileSelector(fs);
                    } 
                    else
                    {
                        fs.ReadOnly = true;
                    }
                }
            }
        }
    }
}
