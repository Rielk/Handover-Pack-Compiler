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
    public partial class ModuleValuesForm : Form
    {
        public string NameVal;
        public string DatasheetVal;
        public string WarrantyVal;
        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        public ModuleValuesForm()
        {
            InitializeComponent();
            NameBox.Text = NameVal = "";
            DatasheetBox.Text = DatasheetVal = "";
            WarrantyBox.Text = WarrantyVal = "";
        }

        public ModuleValuesForm(string name, string datasheetPath, string warrantyPath)
        {
            InitializeComponent();
            NameBox.Text = NameVal = name;
            DatasheetBox.Text = DatasheetVal = datasheetPath;
            WarrantyBox.Text = WarrantyVal = warrantyPath;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            NameVal = NameBox.Text;
            DatasheetVal = DatasheetBox.Text;
            WarrantyVal = WarrantyBox.Text;
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
                string path = Path.Combine(PackPaths.TechnicalArea,
                    "SOLAR PV", "PV Modules", "Hanwah Q Cells", "Datasheets");
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

        private void WarrantyButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (WarrantyVal != "")
            {
                file_dialog.InitialDirectory = WarrantyVal;
            }
            else if (Properties.Settings.Default.CommSitePath != "")
            {
                string path = Path.Combine(PackPaths.TechnicalArea,
                    "SOLAR PV", "PV Modules", "Hanwah Q Cells", "Warranties");
                file_dialog.InitialDirectory = path;
            }
            else
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.ProgramDataPath;
            }

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                WarrantyVal = file_dialog.FileName;
                WarrantyBox.Text = WarrantyVal;
            }
        }
    }
}
