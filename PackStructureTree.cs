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
                RootNode.Nodes.Add(folder.Name);
                foreach(Folder.File file in folder.Files)
                {
                    RootNode.Nodes[RootNode.Nodes.Count-1].Nodes.Add(file.Name);
                }
            }
            TreeView.ExpandAll();
            RootNode.EnsureVisible();
            TreeView.EndUpdate();
        }
    }
}
