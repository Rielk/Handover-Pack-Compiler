using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handover_Pack_Compiler
{
    public partial class OptimiserValuesForm : Form
    {
        public string NameVal;
        public string DatasheetVal;
        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        public OptimiserValuesForm()
        {
            InitializeComponent();
            NameBox.Text = NameVal = "";
            DatasheetBox.Text = DatasheetVal = "";
        }

        public OptimiserValuesForm(string name, string datasheetPath)
        {
            InitializeComponent();
            NameBox.Text = NameVal = name;
            DatasheetBox.Text = DatasheetVal = datasheetPath;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            NameVal = NameBox.Text;
            DatasheetVal = DatasheetBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DatasheetButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (DatasheetVal != "")
            {
                file_dialog.InitialDirectory = Path.GetDirectoryName(DatasheetVal);
            }
            else if (Properties.Settings.Default.CommSitePath != "")
            {
                string path = Path.Combine(PackPaths.TechnicalArea, "SOLAR PV", "Optimisers");
                file_dialog.InitialDirectory = path;
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
