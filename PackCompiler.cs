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
        private readonly List<InverterData> InverterList;
        private readonly List<ModuleData> ModuleList;
        private readonly List<PackStructure> PackStructureList;
        public PackCompiler()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ProgramDataPath == "")
            {
                Properties.Settings.Default.ProgramDataPath = Application.UserAppDataPath;
            }
            LoadFilePaths();

            InverterList = Utilities.IReadFromFile("Inverters.xml");
            InverterDataSource.DataSource = InverterList;
            SortInverters();

            ModuleList = Utilities.MReadFromFile("Modules.xml");
            ModuleDataSource.DataSource = ModuleList;
            SortModules();

            MPWarrantyButton.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            SEWarrantyButton.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

            ProgDataButton.InitialPathFunction = DefaultPath.ProgData;
            CommSiteButton.InitialPathFunction = DefaultPath.CommSite;
            MPWarrantyButton.InitialPathFunction = DefaultPath.MPWarranty;
            SEWarrantyButton.InitialPathFunction = DefaultPath.SEWarrant;

            PackStructureList = new List<PackStructure>();
            PackStructure DefaultPS = new PackStructure
            {
                Name = "Default",
                Description = "Default pack, nothing interesting."
            };
            PackStructureList.Add(DefaultPS);
            PackStructureTableSource.DataSource = PackStructureList;
            PackStructureDropSource.DataSource = PackStructureList;
        }
        //Setting Tab Start
        private void ProgDataButton_ValueUpdate(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProgramDataPath = ProgDataButton.Value;
            Properties.Settings.Default.Save();
        }

        private void CommSiteButton_ValueUpdate(object sender, EventArgs e)
        {
            Properties.Settings.Default.MPWarrantyPath = CommSiteButton.Value;
            Properties.Settings.Default.Save();
        }

        private void MPWarrantyButton_ValueUpdate(object sender, EventArgs e)
        {
            Properties.Settings.Default.MPWarrantyPath = MPWarrantyButton.Value;
            Properties.Settings.Default.Save();
        }

        private void SEWarrantyButton_ValueUpdate(object sender, EventArgs e)
        {
            Properties.Settings.Default.SEWarrantyPath = SEWarrantyButton.Value;
            Properties.Settings.Default.Save();
        }
        private void LoadFilePaths()
        {
            if (!Directory.Exists(Properties.Settings.Default.ProgramDataPath))
            {
                Properties.Settings.Default.ProgramDataPath = "";
            }
            if (!Directory.Exists(Properties.Settings.Default.CommSitePath))
            {
                Properties.Settings.Default.CommSitePath = "";
            }
            if (!File.Exists(Properties.Settings.Default.MPWarrantyPath))
            {
                Properties.Settings.Default.MPWarrantyPath = "";
            }
            if (!File.Exists(Properties.Settings.Default.SEWarrantyPath))
            {
                Properties.Settings.Default.SEWarrantyPath = "";
            }
            ProgDataButton.Value = Properties.Settings.Default.ProgramDataPath;
            CommSiteButton.Value = Properties.Settings.Default.CommSitePath;
            MPWarrantyButton.Value = Properties.Settings.Default.MPWarrantyPath;
            SEWarrantyButton.Value = Properties.Settings.Default.SEWarrantyPath;
        }
        //Setting Tab End
        //Inverter Tab Start
        private void AddInverterButton_Click(object sender, EventArgs e)
        {
            InverterValuesForm IVForm = new InverterValuesForm();
            if (IVForm.ShowDialog() == DialogResult.OK)
            {
                InverterData IData = new InverterData
                {
                    Name = IVForm.NameVal,
                    Datasheet = IVForm.DatasheetVal,
                    SolarEdge = IVForm.SolarEdgeVal
                };
                if (InverterList.Contains(IData))
                {
                    DialogResult Confirm = MessageBox.Show("An Inverter named \"" + IData +
                        "\"already exists. Do you want to replace it with the new one?", "Confirm Replace", MessageBoxButtons.YesNo);
                    if (Confirm == DialogResult.Yes)
                    {
                        InverterList.Remove(IData);
                        InverterList.Add(IData);
                    }
                }
                else
                {
                    InverterList.Add(IData);
                }
                SortInverters(IData.Name);
                Utilities.WriteToFile(InverterList, "Inverters.xml");
            }
        }

        private void DeleteInverterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InverterGridView.SelectedRows)
            {
                if (((InverterData)row.DataBoundItem).Name != null)
                {
                    InverterList.Remove((InverterData)row.DataBoundItem);
                }
            }
            SortInverters();
            Utilities.WriteToFile(InverterList, "Inverters.xml");
        }

        private void EditInverterButton_Click(object sender, EventArgs e)
        {
            InverterData IData = (InverterData)InverterGridView.SelectedRows[0].DataBoundItem;
            if (IData.Name != null)
            {
                InverterValuesForm IVForm = new InverterValuesForm(IData.Name, IData.Datasheet, IData.SolarEdge);
                if (IVForm.ShowDialog() == DialogResult.OK)
                {
                    InverterList.Remove(IData);
                    IData.Name = IVForm.NameVal;
                    IData.Datasheet = IVForm.DatasheetVal;
                    IData.SolarEdge = IVForm.SolarEdgeVal;
                    InverterList.Add(IData);
                    SortInverters(IData.Name);
                    Utilities.WriteToFile(InverterList, "Inverters.xml");
                }
            }
        }

        private void SortInverters()
        {
            InverterList.Sort();
            InverterDataSource.ResetBindings(false);
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
            ModuleValuesForm MVForm = new ModuleValuesForm();
            if (MVForm.ShowDialog() == DialogResult.OK)
            {
                ModuleData MData = new ModuleData
                {
                    Name = MVForm.NameVal,
                    Datasheet = MVForm.DatasheetVal,
                    Warranty = MVForm.WarrantyVal
                };
                if (ModuleList.Contains(MData))
                {
                    DialogResult Confirm = MessageBox.Show("A Module named \"" + MData +
                        "\"already exists. Do you want to replace it with the new one?", "Confirm Replace", MessageBoxButtons.YesNo);
                    if (Confirm == DialogResult.Yes)
                    {
                        ModuleList.Remove(MData);
                        ModuleList.Add(MData);
                    }
                }
                else
                {
                    ModuleList.Add(MData);
                }
                SortModules(MData.Name);
                Utilities.WriteToFile(ModuleList, "Modules.xml");
            }
        }

        private void DeleteModuleButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ModuleGridView.SelectedRows)
            {
                if (((ModuleData)row.DataBoundItem).Name != null)
                {
                    ModuleList.Remove((ModuleData)row.DataBoundItem);
                }
            }
            SortModules();
            Utilities.WriteToFile(ModuleList, "Modules.xml");
        }

        private void EditModuleButton_Click(object sender, EventArgs e)
        {
            ModuleData MData = (ModuleData)ModuleGridView.SelectedRows[0].DataBoundItem;
            if (MData.Name != null)
            {
                ModuleValuesForm MVForm = new ModuleValuesForm(MData.Name, MData.Datasheet, MData.Warranty);
                if (MVForm.ShowDialog() == DialogResult.OK)
                {
                    ModuleList.Remove(MData);
                    MData.Name = MVForm.NameVal;
                    MData.Datasheet = MVForm.DatasheetVal;
                    MData.Warranty = MVForm.WarrantyVal;
                    ModuleList.Add(MData);
                    SortModules(MData.Name);
                    Utilities.WriteToFile(ModuleList, "Modules.xml");
                }
            }
        }

        private void SortModules()
        {
            ModuleList.Sort();
            ModuleDataSource.ResetBindings(false);
        }

        private void SortModules(string selection)
        {
            ModuleData SelectedData = new ModuleData() { Name = selection };
            ModuleList.Sort();
            ModuleDataSource.ResetBindings(false);
            foreach (DataGridViewRow row in ModuleGridView.Rows)
            {
                if (row.DataBoundItem == SelectedData) { row.Selected = true; }
                else { row.Selected = false; }
            }
            ModuleDropBox.SelectedItem = SelectedData;
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
            CurrencyManager CM = (CurrencyManager)BindingContext[ModuleGridView.DataSource];
            CM.SuspendBinding();
            if (ModuleGridView.Rows[0].Visible)
            {
                
                ModuleGridView.Rows[0].Visible = false;
            }
            CM.ResumeBinding();
        }
        //Module Tab End
        //Pack Tab Start
        private void PackStructureDropBox_Enter(object sender, EventArgs e)
        {
            PackStructureDropSource.ResetBindings(false);
        }

    }
}
