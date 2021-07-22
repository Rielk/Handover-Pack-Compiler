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
        private readonly ActivePack LoadedPack;
        private bool Complete
        {
            get { return LoadedPack.SummaryComplete; }
            set { LoadedPack.SummaryComplete = value; }
        }
        public SummaryInformation(ActivePack PS)
        {
            InitializeComponent();
            LoadedPack = PS;
            SystemSizeBox.Value = LoadedPack.SystemSize;
            PredictedOutputBox.Value = LoadedPack.PredictedOutput;
            DatePicker.Value = LoadedPack.InstallDate;
            AddressBox.Text = LoadedPack.Address;
            Complete = !LoadedPack.SummaryComplete;
            ConfirmButton_Click(null, null);
        }

        private void SystemSizeBox_ValueChanged(object sender, EventArgs e)
        {
            LoadedPack.SystemSize = SystemSizeBox.Value;
        }

        private void PredictedOutputBox_ValueChanged(object sender, EventArgs e)
        {
            LoadedPack.PredictedOutput = PredictedOutputBox.Value;
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadedPack.InstallDate = DatePicker.Value;
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            LoadedPack.Address = AddressBox.Text;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Complete)
            {
                SystemSizeBox.Enabled = true;
                PredictedOutputBox.Enabled = true;
                DatePicker.Enabled = true;
                AddressBox.Enabled = true;
                ConfirmButton.Text = "Confirm";
                Complete = false;
            }
            else
            {
                SystemSizeBox.Enabled = false;
                PredictedOutputBox.Enabled = false;
                DatePicker.Enabled = false;
                AddressBox.Enabled = false;
                ConfirmButton.Text = "Edit";
                Complete = true;
            }
        }
    }
}
