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
    public partial class OptimiserSelector : UserControl
    {
        public OptimiserData Value
        {
            get
            {
                if (DropBox.SelectedItem is string)
                {
                    return null;
                }
                else
                {
                    return new OptimiserData((OptimiserData)DropBox.SelectedItem) { };
                }
            }
            set
            {
                if (value == null)
                {
                    DropBox.SelectedIndex = 0;
                }
                else
                {
                    bool NoneSelected = true;
                    foreach (OptimiserData OD in PackCompiler.OptimiserList)
                    {
                        if (OD.Name == value.Name)
                        {
                            DropBox.SelectedItem = OD;
                            NoneSelected = false;
                            break;
                        }
                    }
                    if (NoneSelected)
                    {
                        DropBox.SelectedIndex = 0;
                    }
                }
            }
        }
        public bool enbld = false;
        public bool ReadOnly
        {
            get { return !enbld; }
            set
            {
                enbld = !value;
                DropBox.Enabled = !value;
                RemoveButton.Enabled = !value;
            }
        }
        public OptimiserSelector()
        {
            InitializeComponent();
            DropBox.Items.Clear();
            foreach (OptimiserData OD in PackCompiler.OptimiserList)
            {
                DropBox.Items.Add(OD);
            }
            DropBox.Items.Insert(0, "Select Optimiser...");
            DropBox.SelectedIndex = 0;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Value updates")]
        public event EventHandler ValueUpdate;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Value updates")]
        public event EventHandler RemoveThis;

        private void DropBox_DropDown(object sender, EventArgs e)
        {
            object selected_save = DropBox.SelectedItem;
            DropBox.Items.Clear();
            foreach (OptimiserData OD in PackCompiler.OptimiserList)
            {
                DropBox.Items.Add(OD);
            }
            DropBox.Items.Insert(0, "Select Optimiser...");
            DropBox.SelectedItem = selected_save;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveThis?.Invoke(this, null);
        }

        private void DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueUpdate?.Invoke(this, null);
        }

        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            ValueUpdate?.Invoke(this, null);
        }
    }
}
