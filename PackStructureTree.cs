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
    public partial class PackStructureTree : UserControl
    {
        public PackStructure CurrentPack { get; set; } = null;
        private readonly ContextMenu RightClickMenu = new ContextMenu();
        private readonly ContextMenu SmallRightClickMenu = new ContextMenu();
        private TreeNode EditingNode = null;
        private readonly List<CheckBox> CheckBoxList = new List<CheckBox>();
        public PackStructureTree()
        {
            InitializeComponent();

            MenuItem RenameMenuItem = new MenuItem("Rename");
            RenameMenuItem.Click += RenameMenuItem_Click;
            RightClickMenu.MenuItems.Add(RenameMenuItem);
            MenuItem AddFileMenuItem = new MenuItem("Add File");
            AddFileMenuItem.Click += AddFileMenuItem_Click;
            RightClickMenu.MenuItems.Add(AddFileMenuItem);
            MenuItem AddFolderMenuItem = new MenuItem("Add Folder");
            AddFolderMenuItem.Click += AddFolderMenuItem_Click;
            RightClickMenu.MenuItems.Add(AddFolderMenuItem);
            MenuItem DeleteMenuItem = new MenuItem("Delete");
            DeleteMenuItem.Click += DeleteMenuItem_Click;
            RightClickMenu.MenuItems.Add(DeleteMenuItem);

            MenuItem AddFolderSmallMenuItem = new MenuItem("Add Folder");
            AddFolderSmallMenuItem.Click += AddFolderMenuItem_Click;
            SmallRightClickMenu.MenuItems.Add(AddFolderSmallMenuItem);

            CheckBoxList.Add(GenericCheckBox);
            CheckBoxList.Add(ConstantCheckBox);
            CheckBoxList.Add(SummaryCheckBox);
            CheckBoxList.Add(SEWarrantyCheckBox);
            CheckBoxList.Add(ModuleWarrantyCheckBox);
            CheckBoxList.Add(ModuleDataCheckBox);
            CheckBoxList.Add(InverterDataCheckBox);
            CheckBoxList.Add(OptimiserDataCheckBox);
        }

        //Start Tree
        public void FillPack(PackStructure NewStructure)
        {
            CurrentPack = NewStructure;
            FillPack();
        }

        public void FillPack()
        {
            TreeView.BeginUpdate();
            TreeView.Nodes.Clear();
            TreeView.Nodes.Add(CurrentPack.ToString());
            TreeNode RootNode = TreeView.Nodes[0];
            foreach (Folder folder in CurrentPack.Folders)
            {
                TreeNode FolderNode = new TreeNode(folder.Name){ Tag = folder };
                RootNode.Nodes.Add(FolderNode);
                foreach (Folder.File file in folder.Files)
                {
                    TreeNode FileNode = new TreeNode(file.Name) { Tag = file };
                    RootNode.Nodes[RootNode.Nodes.Count-1].Nodes.Add(FileNode);
                }
            }
            TreeView.ExpandAll();
            RootNode.EnsureVisible();
            TreeView.EndUpdate();
            TreeView.SelectedNode = RootNode;
        }

        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void TreeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void TreeView_DragOver(object sender, DragEventArgs e)
        {
            TreeNode DraggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            Point targetPoint = TreeView.PointToClient(new Point(e.X, e.Y));
            TreeNode TargetNode = TreeView.GetNodeAt(targetPoint);
            if (TargetNode != null)
            {
                if (DraggedNode.Tag is Folder.File)
                {
                    if (!(TargetNode.Tag is Folder.File | TargetNode.Tag is Folder))
                    {
                        TargetNode = TargetNode.Nodes[0];
                    }
                    TreeView.SelectedNode = TargetNode;
                }
                else if (DraggedNode.Tag is Folder)
                {
                    if (TargetNode.Tag is Folder.File)
                    {
                        TargetNode = TargetNode.Parent;
                    }
                    TreeView.SelectedNode = TargetNode;
                }
                else
                {
                    TreeView.SelectedNode = TreeView.Nodes[0];
                }
            }
        }

        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode DraggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            Point TargetPoint = TreeView.PointToClient(new Point(e.X, e.Y));
            TreeNode TargetNode = TreeView.GetNodeAt(TargetPoint);
            if (!DraggedNode.Equals(TargetNode) && TargetNode != null)
            {                
                if (DraggedNode.Tag is Folder.File DraggedFile)
                {
                    CurrentPack.Folders[CurrentPack.Folders.IndexOf((Folder)DraggedNode.Parent.Tag)].Files.Remove(DraggedFile);
                    DraggedNode.Remove();
                    if (TargetNode.Tag is Folder.File)
                    {
                        int NewIndex = TargetNode.Parent.Nodes.IndexOf(TargetNode) + 1;
                        TargetNode.Parent.Nodes.Insert(NewIndex, DraggedNode);
                        CurrentPack.Folders[CurrentPack.Folders.IndexOf((Folder)TargetNode.Parent.Tag)].Files.Insert(NewIndex, DraggedFile);
                    }
                    else if (TargetNode.Tag is Folder TargetFolder)
                    {
                        TargetNode.Nodes.Insert(0, DraggedNode);
                        CurrentPack.Folders[CurrentPack.Folders.IndexOf(TargetFolder)].Files.Insert(0, DraggedFile);
                    }
                    else
                    {
                        TargetNode.Nodes[0].Nodes.Insert(0, DraggedNode);
                        CurrentPack.Folders[0].Files.Insert(0, DraggedFile);
                    }
                    TreeView.SelectedNode = DraggedNode;
                }
                else if (DraggedNode.Tag is Folder DraggedFolder)
                {
                    CurrentPack.Folders.Remove(DraggedFolder);
                    DraggedNode.Remove();
                    if (TargetNode.Tag is Folder.File)
                    {
                        TargetNode = TargetNode.Parent;
                    }
                    if (TargetNode.Tag is Folder)
                    {
                        int NewIndex = TargetNode.Parent.Nodes.IndexOf(TargetNode) + 1;
                        TargetNode.Parent.Nodes.Insert(NewIndex, DraggedNode);
                        CurrentPack.Folders.Insert(NewIndex, DraggedFolder);
                    }
                    else
                    {
                        TargetNode.Nodes.Insert(0, DraggedNode);
                        CurrentPack.Folders.Insert(0, DraggedFolder);
                    }
                    TreeView.SelectedNode = DraggedNode;
                }
            }
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Tag is Folder | e.Node.Tag is Folder.File)
                {
                    RightClickMenu.Tag = e.Node;
                    RightClickMenu.Show(TreeView, e.Location);
                }
                else
                {
                    SmallRightClickMenu.Tag = e.Node;
                    SmallRightClickMenu.Show(TreeView, e.Location);
                }
            }
            TreeView.SelectedNode = e.Node;
        }

        private void RenameMenuItem_Click(object sender, EventArgs e)
        {
            if (((TreeNode)RightClickMenu.Tag).Tag is Folder)
            {
                ((TreeNode)RightClickMenu.Tag).Expand();
            }
            ((TreeNode)RightClickMenu.Tag).BeginEdit();

        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                if (e.Node.Tag is Folder)
                {
                    e.Node.Expand();
                }
                e.Node.BeginEdit();
            }
        }

        private void TreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Node.Tag is Folder folder)
                {
                    folder.Name = e.Label;
                }
                else if (e.Node.Tag is Folder.File file)
                {
                    file.Name = e.Label;
                }
                TreeView.SelectedNode = null;
                TreeView.SelectedNode = e.Node;
            }
        }

        private void AddFileMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode Node = (TreeNode)RightClickMenu.Tag;
            if (Node.Tag is Folder folder)
            {
                Folder.File NewFile = CurrentPack.AddFile("New File", folder.Name);
                TreeNode FileNode = new TreeNode("New File") { Tag = NewFile };
                Node.Nodes.Add(FileNode);
                TreeView.SelectedNode = FileNode;
            }
            else if (Node.Tag is Folder.File)
            {
                Folder.File NewFile = CurrentPack.AddFile("New File", ((Folder)Node.Parent.Tag).Name);
                TreeNode NewNode = new TreeNode("New File") { Tag = NewFile };
                Node.Parent.Nodes.Add(NewNode);
                TreeView.SelectedNode = NewNode;
                NewNode.EnsureVisible();
            }
        }

        private void AddFolderMenuItem_Click(object sender, EventArgs e)
        {
            Folder NewFolder = CurrentPack.AddFolder("New Folder");
            TreeNode NewNode = new TreeNode("New Folder") { Tag = NewFolder };
            TreeView.Nodes[0].Nodes.Add(NewNode);
            TreeView.SelectedNode = NewNode;
            NewNode.EnsureVisible();
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode Node = (TreeNode)RightClickMenu.Tag;
            if (Node.Tag is Folder folder)
            {
                CurrentPack.Folders.Remove(folder);
                TreeView.SelectedNode = Node.Parent;
                Node.Remove();
            }
            else if (Node.Tag is Folder.File file)
            {
                ((Folder)Node.Parent.Tag).Files.Remove(file);
                TreeView.SelectedNode = Node.Parent;
                Node.Remove();
            }
        }
        //End Tree

        //Start Properties
        bool IgnoreTextChange = false;
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode Node = TreeView.SelectedNode;
            EditingNode = Node;
            IgnoreTextChange = true;
            if (Node.Tag is Folder folder)
            {
                NameTextBox.Text = folder.Name;
                NameTextBox.ReadOnly = false;
                DescriptionTextBox.Text = folder.Description;
                RequiredCheckBox.Visible = false;
                MultipleCheckBox.Visible = false;
                FileGroupBox.Visible = false;
                AddPropertiesGenGroupBox.Visible = false;
                AddPropertiesConPathButton.Visible = false;
            }
            else if (Node.Tag is Folder.File file)
            {
                NameTextBox.Text = file.Name;
                NameTextBox.ReadOnly = false;
                DescriptionTextBox.Text = file.Description;
                RequiredCheckBox.Visible = true;
                RequiredCheckBox.Checked = file.AlwaysRequired;
                MultipleCheckBox.Visible = true;
                MultipleCheckBox.Checked = file.AllowMultiple;
                FileGroupBox.Visible = true;
                FolderTextBox.Text = file.DefaultFolder.ToString();
                SearchTextBox.Text = file.SearchTerm;
                AddPropertiesConPathButton.Value = file.ConstantFile;
                AddProperties_Visability(file);
                foreach (CheckBox cb in CheckBoxList)
                {
                    cb.Checked = (string)cb.Tag == file.FileType;
                }
            }
            else
            {
                NameTextBox.Text = CurrentPack.ToString();
                NameTextBox.ReadOnly = true;
                DescriptionTextBox.Text = CurrentPack.Description;
                RequiredCheckBox.Visible = false;
                MultipleCheckBox.Visible = false;
                FileGroupBox.Visible = false;
                AddPropertiesGenGroupBox.Visible = false;
                AddPropertiesConPathButton.Visible = false;
            }
            IgnoreTextChange = false;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IgnoreTextChange)
            {
                if (EditingNode.Tag is Folder folder)
                {
                    folder.Name = NameTextBox.Text;
                    EditingNode.Text = NameTextBox.Text;
                }
                else if (EditingNode.Tag is Folder.File file)
                {
                    file.Name = NameTextBox.Text;
                    EditingNode.Text = NameTextBox.Text;
                }
                Refresh();
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IgnoreTextChange)
            {
                if (EditingNode.Tag is Folder folder)
                {
                    folder.Description = DescriptionTextBox.Text;
                }
                else if (EditingNode.Tag is Folder.File file)
                {
                    file.Description = DescriptionTextBox.Text;
                }
                else
                {
                    CurrentPack.Description = DescriptionTextBox.Text;
                    Parent.Parent.Refresh();
                }
            }
        }

        private void RequiredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!IgnoreTextChange)
            {
                if (EditingNode.Tag is Folder.File file)
                {
                    file.AlwaysRequired = RequiredCheckBox.Checked;
                }
            }
        }

        private void MultipleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!IgnoreTextChange)
            {
                if (EditingNode.Tag is Folder.File file)
                {
                    file.AllowMultiple = MultipleCheckBox.Checked;
                }
            }
        }

        private void FolderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IgnoreTextChange)
            {
                if (EditingNode.Tag is Folder.File file)
                {
                    file.DefaultFolder = int.TryParse(FolderTextBox.Text, out int x) ? (int?)x : null;
                }
            }
        }

        private void FolderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IgnoreTextChange)
            {
                if (EditingNode.Tag is Folder.File file)
                {
                    file.SearchTerm = SearchTextBox.Text;
                }
            }
        }

        bool IgnoreFileCheckChange = false;
        private void FileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!IgnoreTextChange & !IgnoreFileCheckChange)
            {
                if (EditingNode.Tag is Folder.File file)
                {
                    file.FileType = (string)((CheckBox)sender).Tag;
                    AddProperties_Visability(file);
                }
                IgnoreFileCheckChange = true;
                foreach (CheckBox cb in CheckBoxList)
                {
                    cb.Checked = false;
                }
                ((CheckBox)sender).Checked = true;
                IgnoreFileCheckChange = false;
            }
        }
        private void AddProperties_Visability(Folder.File file)
        {
            if (file.FileType == "Gen")
            {
                AddPropertiesGenGroupBox.Visible = true;
                AddPropertiesConPathButton.Visible = false;
            }
            else if (file.FileType == "Con" | file.FileType == "SEW")
            {
                AddPropertiesGenGroupBox.Visible = false;
                AddPropertiesConPathButton.Visible = true;
            }
            else
            {
                AddPropertiesGenGroupBox.Visible = false;
                AddPropertiesConPathButton.Visible = false;
            }
        }

        private void AddPropertiesConPathButton_ValueUpdate(object sender, EventArgs e)
        {
            if (EditingNode.Tag is Folder.File file)
            {
                file.ConstantFile = AddPropertiesConPathButton.Value;
            }
        }
        //End Properties
    }
}
