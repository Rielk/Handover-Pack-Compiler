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
    public partial class InverterValuesForm : Form
    {
        public string NameVal;
        public string DatasheetVal;
        public bool SolarEdgeVal;
        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        public InverterValuesForm()
        {
            InitializeComponent();
        }

        public InverterValuesForm(string name, string path, bool SolarEdge)
        {
            InitializeComponent();
            NameBox.Text = name;
            DatasheetBox.Text = path;
            SolarEdgeBox.Checked = SolarEdge;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            NameVal = NameBox.Text;
            DatasheetVal = DatasheetBox.Text;
            SolarEdgeVal = SolarEdgeBox.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DatasheetButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (DatasheetVal != "")
            {
                file_dialog.InitialDirectory = DatasheetVal;
            }
            else if (Properties.Settings.Default.CommSitePath != "")
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.CommSitePath;
            }
            else
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.ProgramDataPath;
            }

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                DatasheetVal = file_dialog.FileName;
                DatasheetBox.Text = DatasheetVal;
            }
        }
    }
}
