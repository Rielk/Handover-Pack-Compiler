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
        public PackStructureTree()
        {
            InitializeComponent();
        }
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
                if (DraggedNode.Tag is Folder.File)
                {
                    DraggedNode.Remove();
                    if (TargetNode.Tag is Folder.File)
                    {
                        int NewIndex = TargetNode.Parent.Nodes.IndexOf(TargetNode) + 1;
                        TargetNode.Parent.Nodes.Insert(NewIndex, DraggedNode);
                    }
                    else if (TargetNode.Tag is Folder)
                    {
                        TargetNode.Nodes.Insert(0, DraggedNode);
                    }
                    else
                    {
                        TargetNode.Nodes[0].Nodes.Insert(0, DraggedNode);
                    }
                    TreeView.SelectedNode = DraggedNode;
                }
                else if (DraggedNode.Tag is Folder)
                {
                    DraggedNode.Remove();
                    if (TargetNode.Tag is Folder.File)
                    {
                        TargetNode = TargetNode.Parent;
                    }
                    if (TargetNode.Tag is Folder)
                    {
                        int NewIndex = TargetNode.Parent.Nodes.IndexOf(TargetNode) + 1;
                        TargetNode.Parent.Nodes.Insert(NewIndex, DraggedNode);
                    }
                    else
                    {
                        TargetNode.Nodes.Insert(0, DraggedNode);
                    }
                    TreeView.SelectedNode = DraggedNode;
                }
            }
        }
    }
}
