using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handover_Pack_Compiler
{
    public partial class ModuleUI : UserControl
    {
        private readonly ActivePackStructure ActivePackStructure;
        private List<ModuleData> Modules { get { return ActivePackStructure.Modules; } }
        private bool Complete
        {
            get { return ActivePackStructure.ModuleComplete; }
            set { ActivePackStructure.ModuleComplete = value; }
        }
        private readonly List<ModuleSelector> ModuleSelectors = new List<ModuleSelector>();
        public ModuleUI(ActivePackStructure ps)
        {
            InitializeComponent();
            ActivePackStructure = ps;
            if (Modules.Count == 0)
            {
                AddModule();
            }
            else
            {
                foreach (ModuleData MD in Modules)
                {
                    AddModule(MD);
                }
                AddModule();

            }
            GroupBox_Resize(null, null);
        }

        public void AddModule()
        {
            AddModule(null, 0);
        }

        public void AddModule(ModuleData MD)
        {
            AddModule(MD, MD.Quantity);
        }

        public void AddModule(ModuleData module, int? quant)
        {
            ModuleSelector MS = new ModuleSelector
            {
                Value = module,
                Dock = DockStyle.Top,
                Padding = new Padding(4, 0, 4, 0),
                Quantity = quant
            };
            MS.ValueUpdate += ModuleSelector_ValueUpdate;
            MS.RemoveThis += ModuleSelector_RemoveThis;
            MS.MaximumSize = new Size(5000, MS.Height + 5);
            MS.MinimumSize = new Size(0, MS.Height + 5);
            GroupBox.Controls.Add(MS);
            ModuleSelectors.Add(MS);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height + 26);
            this.MinimumSize = new Size(0, this.MinimumSize.Height + 26);
        }

        private void UpdateModules()
        {
            Modules.Clear();
            foreach (ModuleSelector MS in ModuleSelectors)
            {
                if (MS.Value != null)
                {
                    Modules.Add(MS.Value);
                }
            }
        }

        private void ModuleSelector_ValueUpdate(object sender, EventArgs e)
        {
            if (ModuleSelectors[ModuleSelectors.Count - 1].Value != null)
            {
                AddModule();
            }
            UpdateModules();
        }

        private void ModuleSelector_RemoveThis(object sender, EventArgs e)
        {
            Remove_ModuleSelector((ModuleSelector)sender);
            if (ModuleSelectors.Count == 0 || ModuleSelectors[ModuleSelectors.Count - 1].Value != null)
            {
                AddModule();
            }
            UpdateModules();
        }

        private void Remove_ModuleSelector(ModuleSelector MS)
        {
            MS.Parent.Controls.Remove(MS);
            ModuleSelectors.Remove(MS);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height - 26);
            this.MinimumSize = new Size(0, this.MinimumSize.Height - 26);
            this.Height = 0;
        }

        private void GroupBox_Resize(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(5000, 40 + (ModuleSelectors.Count * 26));
            this.MinimumSize = new Size(0, 40 + (ModuleSelectors.Count * 26));
            ConfirmButton.Top = Math.Min(this.Height - 3, this.Height - 26);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            bool toggle = true;
            foreach (ModuleData MD in Modules)
            {
                if (MD.Quantity == 0 | Modules.Count == 0)
                {
                    toggle = false;
                }
            }
            if (toggle)
            {
                if (Complete)
                {
                    Complete = false;
                    ConfirmButton.Text = "Confirm";
                    foreach (ModuleSelector MS in ModuleSelectors.ToList())
                    {
                        MS.ReadOnly = false;
                    }
                    AddModule();

                }
                else
                {
                    Complete = true;
                    ConfirmButton.Text = "Edit";
                    foreach (ModuleSelector MS in ModuleSelectors.ToList())
                    {
                        if (MS.Value == null)
                        {
                            Remove_ModuleSelector(MS);
                        }
                        else
                        {
                            MS.ReadOnly = true;
                        }
                    }
                }
            }
        }
    }
}
