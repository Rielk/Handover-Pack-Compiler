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
    public partial class ModuleSelector : UserControl
    {
        public ModuleData Value
        {
            get
            {
                if (DropBox.SelectedItem is string)
                {
                    return null;
                }
                else
                {
                    return new ModuleData((ModuleData)DropBox.SelectedItem) { Quantity = this.Quantity };
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
                    DropBox.SelectedItem = value;
                }
            }
        }
        public int? Quantity
        {
            get
            {
                if (QuantityBox.Text == "Quantity")
                {
                    return null;
                }
                else
                {
                    return (int)QuantityBox.Value;
                }
            }
            set
            {
                QuantityBox.Value = (decimal)value;
            }
        }
        public bool enbld = false;
        public bool ReadOnly
        {
            get { return !enbld; }
            set
            {
                enbld = !value;
                QuantityBox.Enabled = !value;
                DropBox.Enabled = !value;
                RemoveButton.Enabled = !value;
            }
        }
        public ModuleSelector()
        {
            InitializeComponent();
            DropBox.Items.Add("Select Module...");
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
            foreach (ModuleData MD in PackCompiler.ModuleList)
            {
                DropBox.Items.Add(MD);
            }
            DropBox.Items.Insert(0, "Select Module...");
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
