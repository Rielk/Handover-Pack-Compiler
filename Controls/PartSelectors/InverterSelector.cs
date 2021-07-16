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
    public partial class InverterSelector : UserControl
    {
        public InverterData Value
        {
            get
            {
                if (DropBox.SelectedItem is string)
                {
                    return null;
                }
                else
                {
                    return new InverterData((InverterData)DropBox.SelectedItem) { SerialNumber = this.SerialNumber };
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
                    bool NonSelected = true;
                    foreach (InverterData ID in PackCompiler.InverterList)
                    {
                        if (ID.Name == value.Name)
                        {
                            DropBox.SelectedItem = ID;
                            NonSelected = false;
                            break;
                        }
                    }
                    if (NonSelected)
                    {
                        DropBox.SelectedIndex = 0;
                    }
                }
            }
        }
        public string SerialNumber
        {
            get
            {
                if (SerialNumberBox.Text == "Serial Number...")
                {
                    return "";
                }
                else
                {
                    return SerialNumberBox.Text;
                }
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    SerialNumberBox.Text = "";
                    SerialNumberBox_Leave(null, null);
                }
                else
                {
                    SerialNumberBox_Enter(null, null);
                    SerialNumberBox.Text = value;
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
                SerialNumberBox.Enabled = !value;
                DropBox.Enabled = !value;
                RemoveButton.Enabled = !value;
            }
        }
        public InverterSelector()
        {
            InitializeComponent();
            DropBox.Items.Clear();
            foreach (InverterData ID in PackCompiler.InverterList)
            {
                DropBox.Items.Add(ID);
            }
            DropBox.Items.Insert(0, "Select Inverter...");
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
            foreach (InverterData ID in PackCompiler.InverterList)
            {
                DropBox.Items.Add(ID);
            }
            DropBox.Items.Insert(0, "Select Inverter...");
            DropBox.SelectedItem = selected_save;
        }

        private void SerialNumberBox_Enter(object sender, EventArgs e)
        {
            if (SerialNumberBox.Text == "Serial Number...")
            {
                SerialNumberBox.Text = "";
                SerialNumberBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void SerialNumberBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SerialNumberBox.Text))
            {
                SerialNumberBox.Text = "Serial Number...";
                SerialNumberBox.ForeColor = SystemColors.GrayText;
            }
            ValueUpdate?.Invoke(this, null);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveThis?.Invoke(this, null);
        }

        private void DropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueUpdate?.Invoke(this, null);
        }
    }
}
