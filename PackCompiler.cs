using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            InverterList = Utilities.ReadFromFile<InverterData>("Inverters.xml", true);
            InverterDataSource.DataSource = InverterList;
            SortInverters();

            ModuleList = Utilities.ReadFromFile<ModuleData>("Modules.xml", true);
            ModuleDataSource.DataSource = ModuleList;
            SortModules();

            MPWarrantyButton.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            SEWarrantyButton.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

            ProgDataButton.InitialPathFunction = DefaultPath.ProgData;
            CommSiteButton.InitialPathFunction = DefaultPath.CommSite;
            MPWarrantyButton.InitialPathFunction = DefaultPath.MPWarranty;
            SEWarrantyButton.InitialPathFunction = DefaultPath.SEWarrant;

            PackStructureList = Utilities.ReadFromFile<PackStructure>("Pack Structures.xml", false);
            if (PackStructureList.Count == 0)
            {
                PackStructure DefaultStructure = new PackStructure() { Description = "Default Pack" };
                DefaultStructure.AddFolder("1.0  Important Technical Information");
                DefaultStructure.AddFile("1.1  Health & Safety Guidelines.pdf", "1.0  Important Technical Information");
                DefaultStructure.AddFolder("2.0  General Information");
                DefaultStructure.AddFile("2.1  System Summary & General Information.pdf", "2.0  General Information");
                DefaultStructure.AddFolder("3.0  Guarantees & Datasheets");
                DefaultStructure.AddFile("3.1  Mypower Installation Warranty.pdf", "3.0  Guarantees & Datasheets");
                DefaultStructure.AddFile("3.2  Module Warranty.pdf", "3.0  Guarantees & Datasheets");
                DefaultStructure.AddFile("3.3  Module Datasheet.pdf", "3.0  Guarantees & Datasheets");
                DefaultStructure.AddFile("3.4  Inverter datasheet.pdf", "3.0  Guarantees & Datasheets");
                DefaultStructure.AddFile("3.4a  Inverter Extended Warranty.pdf", "3.0  Guarantees & Datasheets");
                DefaultStructure.AddFile("3.5  SolarEdge product warranty.pdf", "3.0  Guarantees & Datasheets");
                DefaultStructure.AddFile("3.6  SolarEdge Optimiser datasheet.pdf", "3.0  Guarantees & Datasheets");
                DefaultStructure.AddFolder("4.0  Electrical");
                DefaultStructure.AddFile("4.1  Installation schematic.pdf", "4.0  Electrical");
                DefaultStructure.AddFile("4.2  Commissioning test report (AC Cert).pdf", "4.0  Electrical");
                DefaultStructure.AddFile("4.3  Commissioning test report (DC Cert).pdf", "4.0  Electrical");
                DefaultStructure.AddFile("4.4  DNO commissioning form (G99 Form A3-1).pdf", "4.0  Electrical");
                DefaultStructure.AddFile("4.5  Inverter & wiring sign off.pdf", "4.0  Electrical");
                DefaultStructure.AddFile("4.6  DNO commissioning notification.pdf", "4.0  Electrical");
                DefaultStructure.AddFolder("5.0  Predicted Output");
                DefaultStructure.AddFile("5.1  Summary Report.pdf", "5.0  Predicted Output");
                DefaultStructure.AddFile("5.2  Predicted Output Comparison Tool.xlsx", "5.0  Predicted Output");
                DefaultStructure.AddFolder("6.0  Building Regulations - Work Notification");
                DefaultStructure.AddFile("6.1  NAPIT Work notification details.pdf", "6.0  Building Regulations - Work Notification");
                DefaultStructure.AddFile("6.2  Structural survey certificate.pdf", "6.0  Building Regulations - Work Notification");
                DefaultStructure.AddFolder("7.0  MCS Certificate");
                DefaultStructure.AddFile("7.1  MCS Certificate.pdf", "7.0  MCS Certificate");
                PackStructureList.Add(DefaultStructure);
            }
            PackStructureSource.DataSource = PackStructureList;
            SortPackStructures();
        }
        //General Utilites Start
        private bool CheckExisting<T>(List<T> list, T ToAdd) where T : NameCompare
        {
            bool exists = false;
            foreach (T item in list)
            {
                if (item.ToString() == ToAdd.ToString()) { exists = true; }
            }
            return exists;
        }
        private string CheckExistingName<T>(List<T> list, T ToAdd, bool AutoRename) where T : NameCompare
        {
            if (AutoRename)
            {
                while (CheckExisting<T>(list, ToAdd))
                {
                    string CountString = Regex.Match(ToAdd.ToString(), @"(\d+)").Value;
                    if (CountString != "")
                    {
                        int CountInt = int.Parse(CountString);
                        CountInt++;
                        ToAdd.Name = Regex.Replace(ToAdd.ToString(), @"(\d+)", CountInt.ToString());
                    }
                    else
                    {
                        ToAdd.Name = ToAdd.ToString() + "(1)";
                    }
                }
                return ToAdd.ToString();
            }
            else
            {
                if (CheckExisting<T>(list, ToAdd))
                {
                    DialogResult Confirm = MessageBox.Show("\"" + ToAdd.ToString() +
                            "\"already exists. Do you want to replace it?", "Confirm Replace", MessageBoxButtons.YesNo);
                    if (Confirm == DialogResult.Yes)
                    {
                        list.Remove(ToAdd);
                        return ToAdd.ToString();
                    }
                    else { return null; }
                }
                else { return ToAdd.ToString(); }
            }
        }
        private bool CheckExistingAdd<T>(List<T> list, T ToAdd, bool AutoRename) where T : NameCompare
        {
            string returnedString = CheckExistingName<T>(list, ToAdd, AutoRename);
            if(returnedString != null)
            {
                ToAdd.Name = returnedString;
                list.Add(ToAdd);
                return true;
            }
            else
            {
                return false;
            }
        }
        //General Utilities End
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
                if (CheckExistingAdd<InverterData>(InverterList, IData, false))
                {
                    SortInverters(IData.Name);
                    Utilities.WriteToFile(InverterList, "Inverters.xml", true);
                }
            }
        }

        private void DeleteInverterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InverterGridView.SelectedRows)
            {
                if (((InverterData)row.DataBoundItem).Name != null)
                {
                    DialogResult Confirm = MessageBox.Show("Are you sure you want to delete the Inverter: " +
                        ((InverterData)row.DataBoundItem).ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
                    if (Confirm == DialogResult.Yes)
                    {
                        InverterList.Remove((InverterData)row.DataBoundItem);
                    }
                }
            }
            SortInverters();
            Utilities.WriteToFile(InverterList, "Inverters.xml", true);
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
                    Utilities.WriteToFile(InverterList, "Inverters.xml", true);
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
            SortInverters();
            InverterData SelectedData = new InverterData() { Name = selection };
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
                if (CheckExistingAdd<ModuleData>(ModuleList, MData, false))
                {
                    SortModules(MData.Name);
                    Utilities.WriteToFile(ModuleList, "Modules.xml", true);
                }
            }
        }

        private void DeleteModuleButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ModuleGridView.SelectedRows)
            {
                if (((ModuleData)row.DataBoundItem).Name != null)
                {
                    DialogResult Confirm = MessageBox.Show("Are you sure you want to delete the Module: " +
                        ((ModuleData)row.DataBoundItem).ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
                    if (Confirm == DialogResult.Yes)
                    {
                        ModuleList.Remove((ModuleData)row.DataBoundItem);
                    }
                }
            }
            SortModules();
            Utilities.WriteToFile(ModuleList, "Modules.xml", true);
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
                    Utilities.WriteToFile(ModuleList, "Modules.xml", true);
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
            SortModules();
            ModuleData SelectedData = new ModuleData() { Name = selection };
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

        private void SortPackStructures()
        {
            PackStructureList.Sort();
            PackStructureSource.ResetBindings(false);
        }

        private void SortPackStructures(string selection)
        {
            SortPackStructures();
            PackStructure SelectedStructure = new PackStructure() { Name = selection };
            PackStructureDropBox.SelectedItem = SelectedStructure;
        }

        private void AddPackStructureButton_Click(object sender, EventArgs e)
        {
            PackStructure NewPack = new PackStructure() { Name = "New Structure" };
            CheckExistingAdd<PackStructure>(PackStructureList, NewPack, true);
            SortPackStructures(NewPack.Name);
            Utilities.WriteToFile(PackStructureList, "Pack Structures.xml", false);
        }

        private void DuplicatePackStructureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PackStructureGridView.SelectedRows)
            {
                PackStructure newPS = new PackStructure((PackStructure)row.DataBoundItem);
                CheckExistingAdd<PackStructure>(PackStructureList, newPS, true);
                SortPackStructures(newPS.Name);
            }
            Utilities.WriteToFile(PackStructureList, "Pack Structures.xml", false);
        }

        private void DeletePackStructureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PackStructureGridView.SelectedRows)
            {
                if (((PackStructure)row.DataBoundItem).Name != null)
                {
                    DialogResult Confirm = MessageBox.Show("Are you sure you want to delete the Structure: " +
                        ((PackStructure)row.DataBoundItem).ToString(), "Confirm Delete", MessageBoxButtons.YesNo);
                    if (Confirm == DialogResult.Yes)
                    {
                        bool delete_selected;
                        if ((PackStructure)row.DataBoundItem == PackStructureDropBox.SelectedItem)
                        {
                            delete_selected = true;
                        }
                        else
                        {
                            delete_selected = false;
                        }
                        PackStructureList.Remove((PackStructure)row.DataBoundItem);
                        if (delete_selected) { SortPackStructures(null); }
                        else { SortPackStructures(null); }
                    }
                }
            }
            Utilities.WriteToFile(PackStructureList, "Pack Structures.xml", false);
        }

        private bool EditTrigger = false;
        private string temp_edit;
        private void PackStructureGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            EditTrigger = true;
            temp_edit = (string)PackStructureGridView.CurrentCell.Value;
        }

        private void PackStructureGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (EditTrigger)
            {
                if (e.ColumnIndex == 0 & (string)e.FormattedValue != temp_edit)
                {
                    PackStructure NewPack = new PackStructure { Name = (string)e.FormattedValue };
                    string returnedString = CheckExistingName<PackStructure>(PackStructureList, NewPack, true);
                    PackStructureGridView.EditingControl.Text = returnedString;
                }
                EditTrigger = false;
            }
        }

        private void PackStructureGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Utilities.WriteToFile(PackStructureList, "Pack Structures.xml", false);
        }

        private void PackStructure_SelectionChanged(object sender, EventArgs e)
        {
            PackTree.FillPack((PackStructure)PackStructureDropBox.SelectedItem);
        }
    }
}
