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
using System.Xml;

namespace Handover_Pack_Compiler
{
    public partial class PackCompiler : Form
    {

        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        private readonly FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
        private readonly List<InverterData> InverterList = new List<InverterData>();
        private readonly List<ModuleData> ModuleList = new List<ModuleData>();

        public PackCompiler()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ProgramDataPath == "")
            {
                Properties.Settings.Default.ProgramDataPath = Application.UserAppDataPath;
            }
            LoadFilePaths();

            InverterList.Add(new InverterData());
            InverterDataSource.DataSource = InverterList;

            ModuleList.Add(new ModuleData());
            ModuleDataSource.DataSource = ModuleList;
        }
        //Setting Tab Start
        private void CommSiteButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CommSitePath == "")
            {
                Properties.Settings.Default.CommSitePath = Properties.Settings.Default.ProgramDataPath;
            }
            folder_dialog.SelectedPath = Properties.Settings.Default.CommSitePath;
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CommSitePath = folder_dialog.SelectedPath;
                Properties.Settings.Default.Save();
                CommSiteBox.Text = Properties.Settings.Default.CommSitePath;
            }
        }
        private void MPWarrantyButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (Properties.Settings.Default.MPWarrantyPath != "")
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.MPWarrantyPath;
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
                Properties.Settings.Default.MPWarrantyPath = file_dialog.FileName;
                Properties.Settings.Default.Save();
                MPWarrantyBox.Text = Properties.Settings.Default.MPWarrantyPath;
            }
        }
        private void SEWarrantButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (Properties.Settings.Default.SEWarrantyPath != "")
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.SEWarrantyPath;
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
                Properties.Settings.Default.SEWarrantyPath = file_dialog.FileName;
                Properties.Settings.Default.Save();
                SEWarrantyBox.Text = Properties.Settings.Default.SEWarrantyPath;
            }
        }
        private void ProgDataButton_Click(object sender, EventArgs e)
        {
            folder_dialog.SelectedPath = Properties.Settings.Default.ProgramDataPath;
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ProgramDataPath = folder_dialog.SelectedPath;
                Properties.Settings.Default.Save();
                ProgDataBox.Text = Properties.Settings.Default.ProgramDataPath;
            }
        }
        private void LoadFilePaths()
        {
            ProgDataBox.Text = Properties.Settings.Default.ProgramDataPath;
            CommSiteBox.Text = Properties.Settings.Default.CommSitePath;
            MPWarrantyBox.Text = Properties.Settings.Default.MPWarrantyPath;
            SEWarrantyBox.Text = Properties.Settings.Default.SEWarrantyPath;
        }
        //Setting Tab End
        //Inverter Tab Start
        private void AddInverterButton_Click(object sender, EventArgs e)
        {
            InverterValuesForm IVForm = new InverterValuesForm();
            IVForm.ShowDialog();
            InverterData data = new InverterData
            {
                Name = IVForm.NameVal,
                Datasheet = IVForm.DatasheetVal,
                SolarEdge = IVForm.SolarEdgeVal
            };
            if (InverterList.Contains(data))
            {
                //Ask if user wants to replace existing?
                InverterList.Remove(data);
                InverterList.Add(data);
            }
            else
            {
                InverterList.Add(data);
            }
            SortInverters();
        }

        private void DeleteInverterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InverterGridView.SelectedRows)
            {
                InverterList.Remove((InverterData)row.DataBoundItem);
            }
            SortInverters();
        }

        private void EditInverterButton_Click(object sender, EventArgs e)
        {
            InverterData IData = (InverterData)InverterGridView.SelectedRows[0].DataBoundItem;
            InverterValuesForm IVForm = new InverterValuesForm(IData.Name, IData.Datasheet, IData.SolarEdge);
            if (IVForm.ShowDialog() == DialogResult.OK)
            {
                InverterList.Remove(IData);
                IData.Name = IVForm.NameVal;
                IData.Datasheet = IVForm.DatasheetVal;
                IData.SolarEdge = IVForm.SolarEdgeVal;
                InverterList.Add(IData);
                SortInverters(IData.Name);
            }
        }

        private void SortInverters()
        {
            InverterData SelectedData = (InverterData)InverterGridView.SelectedRows[0].DataBoundItem;
            InverterList.Sort();
            InverterDataSource.ResetBindings(false);
            foreach (DataGridViewRow row in InverterGridView.Rows)
            {
                if (row.DataBoundItem == SelectedData) { row.Selected = true; }
                else { row.Selected = false; }
            }
            InverterDropBox.SelectedItem = SelectedData;
        }

        private void SortInverters(string selection)
        {
            InverterData SelectedData = new InverterData() { Name = selection };
            InverterList.Sort();
            InverterDataSource.ResetBindings(false);
            foreach (DataGridViewRow row in InverterGridView.Rows)
            {
                if (row.DataBoundItem == SelectedData) { row.Selected = true; }
                else { row.Selected = false; }
            }
            InverterDropBox.SelectedItem = SelectedData;
        }

        //Hides the null row when a new row is added
        private void InverterGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (InverterGridView.Rows.Count > 0)
            {
                CurrencyManager CM = (CurrencyManager)BindingContext[InverterGridView.DataSource];
                CM.SuspendBinding();
                InverterGridView.Rows[0].Visible = false;
                CM.ResumeBinding();
            }
        }

        //Hides the null row when a row is selected.
        private void InverterGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager CM = (CurrencyManager)BindingContext[InverterGridView.DataSource];
            CM.SuspendBinding();
            if (InverterGridView.Rows[0].Visible)
            {
                InverterGridView.Rows[0].Visible = false;
            }
            CM.ResumeBinding();
        }
        //Inverter Tab End
        //Module Tab Start
        private void AddModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void EditModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void SortModules()
        {

        }

        private void SortModules(string selection)
        {

        }

        private void ModuleGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (ModuleGridView.Rows.Count > 0)
            {
                CurrencyManager CM = (CurrencyManager)BindingContext[ModuleGridView.DataSource];
                CM.SuspendBinding();
                ModuleGridView.Rows[0].Visible = false;
                CM.ResumeBinding();
            }
        }

        private void ModuleGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyManager CM = (CurrencyManager)BindingContext[InverterGridView.DataSource];
            CM.SuspendBinding();
            if (ModuleGridView.Rows[0].Visible)
            {
                
                ModuleGridView.Rows[0].Visible = false;
            }
            CM.ResumeBinding();
        }
    }
}
