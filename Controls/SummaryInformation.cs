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
    public partial class SummaryInformation : UserControl
    {
        private readonly ActivePackStructure ActivePackStructure;
        private bool Complete
        {
            get { return ActivePackStructure.SummaryComplete; }
            set { ActivePackStructure.SummaryComplete = value; }
        }
        public SummaryInformation(ActivePackStructure PS)
        {
            InitializeComponent();
            ActivePackStructure = PS;
        }

        private void SystemSizeBox_ValueChanged(object sender, EventArgs e)
        {
            ActivePackStructure.SystemSize = SystemSizeBox.Value.ToString();
        }

        private void PredictedOutputBox_ValueChanged(object sender, EventArgs e)
        {
            ActivePackStructure.PredictedOutput = PredictedOutputBox.Value.ToString();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            ActivePackStructure.InstallDate = DatePicker.Value.ToString();
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            ActivePackStructure.Address = AddressBox.Text;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Complete)
            {
                SystemSizeBox.Enabled = true;
                PredictedOutputBox.Enabled = true;
                DatePicker.Enabled = true;
                AddressBox.Enabled = true;
                Complete = false;
            }
            else
            {
                SystemSizeBox.Enabled = false;
                PredictedOutputBox.Enabled = false;
                DatePicker.Enabled = false;
                AddressBox.Enabled = false;
                Complete = true;
            }
        }
    }
}
