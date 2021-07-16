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
    public partial class InverterUI : UserControl
    {
        private readonly ActivePack LoadedPack;
        private List<InverterData> Inverters { get { return LoadedPack.Inverters; } }
        private bool Complete
        {
            get { return LoadedPack.InverterComplete; }
            set { LoadedPack.InverterComplete = value; }
        }
        private readonly List<InverterSelector> InverterSelectors = new List<InverterSelector>();
        public InverterUI(ActivePack ps)
        {
            InitializeComponent();
            LoadedPack = ps;
            foreach (InverterData ID in Inverters)
            {
                AddInverter(ID);
            }
            AddInverter();
            if (Complete)
            {
                Complete = false;
                ConfirmButton_Click(null, null);
            }
            GroupBox_Resize(null, null);
        }

        public void AddInverter()
        {
            AddInverter(null, "");
        }

        public void AddInverter(InverterData ID)
        {
            AddInverter(ID, ID.SerialNumber);
        }

        public void AddInverter(InverterData inverter, string serial_number)
        {
            InverterSelector IS = new InverterSelector
            {
                Value = inverter,
                Dock = DockStyle.Top,
                Padding = new Padding(4, 0, 4, 0),
                SerialNumber = serial_number
            };
            IS.ValueUpdate += InverterSelector_ValueUpdate;
            IS.RemoveThis += InverterSelector_RemoveThis;
            IS.MaximumSize = new Size(5000, IS.Height + 5);
            IS.MinimumSize = new Size(0, IS.Height + 5);
            GroupBox.Controls.Add(IS);
            InverterSelectors.Add(IS);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height + 26);
            this.MinimumSize = new Size(0, this.MinimumSize.Height + 26);
        }

        private void UpdateInverters()
        {
            Inverters.Clear();
            foreach (InverterSelector IS in InverterSelectors)
            {
                if (IS.Value != null)
                {
                    Inverters.Add(IS.Value);
                }
            }
        }

        private void InverterSelector_ValueUpdate(object sender, EventArgs e)
        {
            if (InverterSelectors[InverterSelectors.Count - 1].Value != null)
            {
                AddInverter();
            }
            UpdateInverters();
        }

        private void InverterSelector_RemoveThis(object sender, EventArgs e)
        {
            Remove_InverterSelector((InverterSelector)sender);
            if (InverterSelectors.Count == 0 || InverterSelectors[InverterSelectors.Count - 1].Value != null)
            {
                AddInverter();
            }
            UpdateInverters();
        }

        private void Remove_InverterSelector(InverterSelector IS)
        {
            IS.Parent.Controls.Remove(IS);
            InverterSelectors.Remove(IS);
            this.MaximumSize = new Size(5000, this.MaximumSize.Height - 26);
            this.MinimumSize = new Size(0, this.MinimumSize.Height - 26);
            this.Height = 0;
        }

        private void GroupBox_Resize(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(5000, 40 + (InverterSelectors.Count * 26));
            this.MinimumSize = new Size(0, 40 + (InverterSelectors.Count * 26));
            ConfirmButton.Top = Math.Min(this.Height - 3, this.Height - 26);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            bool toggle = true;
            foreach (InverterData ID in Inverters)
            {
                if (ID.SerialNumber == "")
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
                    foreach (InverterSelector IS in InverterSelectors.ToList())
                    {
                        IS.ReadOnly = false;
                    }
                    AddInverter();

                }
                else
                {
                    Complete = true;
                    ConfirmButton.Text = "Edit";
                    foreach (InverterSelector IS in InverterSelectors.ToList())
                    {
                        if (IS.Value == null)
                        {
                            Remove_InverterSelector(IS);
                        }
                        else
                        {
                            IS.ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void PhotoButton_Click(object sender, EventArgs e)
        {
            Process.Start(PackPaths.CustomerFolderNumberN(2));
        }
    }
}
