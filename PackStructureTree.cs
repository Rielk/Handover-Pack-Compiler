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

        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = TreeView.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = TreeView.GetNodeAt(targetPoint);
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (!draggedNode.Equals(targetNode) && targetNode != null)
            {
                draggedNode.Remove();
                int newIndex = targetNode.Parent.Nodes.IndexOf(targetNode) + 1;
                targetNode.Parent.Nodes.Insert(newIndex, draggedNode);
            }
        }
    }
}
