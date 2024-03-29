﻿using System;
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
        private readonly List<FileSelector> FileSelectors = new List<FileSelector>();
        private FileDropSelector DropSelector;
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
            DescriptionLabel.Text = f.Description;
            if (f.CSGenPaths.Count == 0)
            {
                AddFile();
            }
            else
            {
                if (!file.AllowMultiple && f.CSGenPaths.Count > 1)
                {
                    DropSelector = new FileDropSelector
                    {
                        Dock = DockStyle.Top,
                        Padding = new Padding(4, 0, 4, 0),
                        DefaultFolder = file.DefaultFolder
                    };
                    DropSelector.ValueUpdate += DropSelector_ValueUpdate;
                    GroupBox.Controls.Add(DropSelector);
                    this.MaximumSize = new Size(5000, this.MaximumSize.Height + 26);
                    this.MinimumSize = new Size(0, this.MinimumSize.Height + 26);
                    if (!file.AlwaysRequired)
                    {
                        DropSelector.AddOption("None");
                    }
                }
                foreach (string path in f.GenericPaths)
                {
                    AddFile(path);
                }
                if (file.AllowMultiple)
                {
                    AddFile();
                }
            }

            if (f.AlwaysRequired)
            {
                RequiredCheckBox.Enabled = false;
                RequiredCheckBox.Visible = true;
            }
            else
            {
                RequiredCheckBox.Enabled = true;
            }

            if (f.Complete)
            {
                f.Complete = false;
                ConfirmButton_Click(null, null);
            }

            GroupBox_Resize(null, null);
        }
        private void AddFile()
        {
            AddFile("");
        }
        private void AddFile(string name)
        {
            if (DropSelector == null)
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
            else
            {
                DropSelector.AddOption(name);
            }
        }

        private void UpdatePaths()
        {
            List<string> paths;
            if (DropSelector == null)
            {
                paths = new List<string>();
                foreach (FileSelector fs in FileSelectors)
                {
                    if (fs.Value != "")
                    {
                        paths.Add(fs.Value);
                    }
                }
            }
            else
            {
                paths = DropSelector.AllOptions;
            }
            file.GenericPaths = paths;
        }

        private void RequiredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in GroupBox.Controls)
            {
                c.Enabled = RequiredCheckBox.Checked;
            }
            file.Complete = RequiredCheckBox.Checked;
            ToggleComplete();
        }

        private void DropSelector_ValueUpdate(object sender, EventArgs e)
        {
            UpdatePaths();
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
            fs.Parent.Controls.Remove(fs);
            FileSelectors.Remove(fs);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height - 25);
            this.MinimumSize = new Size(0, this.MinimumSize.Height - 25);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            bool toggle;
            if (DropSelector == null)
            {
                toggle = true;
                //If a file is always needed and one isn't provided, prevent toggle.
                if (file.AlwaysRequired && FileSelectors[0].Value == "")
                {
                    toggle = false;
                }
                //If a file isn't always needed and one isn't provided, toggle required checkbox instead.
                if (!file.AlwaysRequired && FileSelectors[0].Value == "")
                {
                    RequiredCheckBox.Checked = false;
                    toggle = false;
                }
                //If not allowed multiple files and multiple are provided, prevent check.
                if (!file.AllowMultiple && FileSelectors.Count != 1)
                {
                    toggle = false;
                }
            }
            else
            {
                toggle = true;
                //If a file isn't always needed and isn't selected, toggle required checkbox instead.
                if (!file.AlwaysRequired && DropSelector.SelectedOption == "None")
                {
                    RequiredCheckBox.Checked = false;
                    toggle = false;
                }
            }
            if (toggle)
            {
                ToggleComplete();
            }
        }
        private void ToggleComplete()
        {
            if (DropSelector != null)
            {
                FileDropSelector tempDropSelector = DropSelector;
                GroupBox.Controls.Remove(DropSelector);
                DropSelector = null;
                if (tempDropSelector.Value == null)
                {
                    if (tempDropSelector.SelectedOption == "Other...")
                    {
                        file.Complete = true;
                    }
                }
                else
                {
                    AddFile(tempDropSelector.Value);
                }
                UpdatePaths();
            }
            if (file.Complete)
            {
                file.Complete = false;
                ConfirmButton.Text = "Confirm";
                foreach (FileSelector fs in FileSelectors.ToList())
                {
                    fs.ReadOnly = false;
                }
                if (file.AllowMultiple | FileSelectors.Count == 0)
                {
                    AddFile();
                }
            }
            else
            {
                file.Complete = true;
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
            GroupBox_Resize(this, null);
        }

        private void GroupBox_Resize(object sender, EventArgs e)
        {
            DescriptionLabel.MaximumSize = new Size(ConfirmButton.Location.X - 5, 5000);
            if (DropSelector == null)
            {
                this.MaximumSize = new Size(5000, Math.Max(DescriptionLabel.Height + 17, 40) + (FileSelectors.Count * 25));
                this.MinimumSize = new Size(0, Math.Max(DescriptionLabel.Height + 17, 40) + (FileSelectors.Count * 25));
            }
            else
            {
                this.MaximumSize = new Size(5000, Math.Max(DescriptionLabel.Height + 43, 66));
                this.MinimumSize = new Size(0, Math.Max(DescriptionLabel.Height + 43, 66));
            }
            DescriptionLabel.Top = Math.Min(this.Height - DescriptionLabel.Height - 3, this.Height - 26);
            ConfirmButton.Top = DescriptionLabel.Top;
        }
    }
}
