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
        private PackPaths ActivePackPaths = null;
        public PackCompiler()
        {
            InitializeComponent();
            CheckFilePaths();
            LoadFilePaths();

            InverterList = Utilities.ReadFromFile<InverterData>("Inverters.xml");
            InverterDataSource.DataSource = InverterList;
            SortInverters();

            ModuleList = Utilities.ReadFromFile<ModuleData>("Modules.xml");
            ModuleDataSource.DataSource = ModuleList;
            SortModules();

            ProgDataButton.InitialPathFunction = DefaultPath.ProgData;
            CommSiteButton.InitialPathFunction = DefaultPath.CommSite;

            PackStructureList = Utilities.ReadFromFile<PackStructure>("Pack Structures.xml");
            if (PackStructureList.Count == 0)
            {
                PackStructureList.Add(PackStructure.Default());
            }
            PackStructureSource.DataSource = PackStructureList;
            SortPackStructures();
        }

        #region General Utilities
        private void PackCompiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilities.WriteToFile(InverterList, "Inverters.xml", true);
            Utilities.WriteToFile(ModuleList, "Modules.xml", true);
            Utilities.WriteToFile(PackStructureList, "Pack Structures.xml", false);
        }
        
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
                    DialogResult Confirm = CMessageBox.Show("Confirm Replace", "\"" + ToAdd.ToString() +
                            "\"already exists. Do you want to replace it?", "Yes", "No");
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
        #endregion

        #region Settings Tab
        private void ProgDataButton_ValueUpdate(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProgramDataPath = ProgDataButton.Value;
            Properties.Settings.Default.Save();
        }

        private void CommSiteButton_ValueUpdate(object sender, EventArgs e)
        {
            Properties.Settings.Default.CommSitePath = CommSiteButton.Value;
            Properties.Settings.Default.Save();
        }

        private void CheckFilePaths()
        {
            if (!Directory.Exists(Properties.Settings.Default.ProgramDataPath))
            {
                Properties.Settings.Default.ProgramDataPath = "";
            }
            if (Properties.Settings.Default.ProgramDataPath == "")
            {
                Properties.Settings.Default.ProgramDataPath = Application.UserAppDataPath;
            }
            if (!Directory.Exists(Properties.Settings.Default.CommSitePath))
            {
                Properties.Settings.Default.CommSitePath = "";
            }
        }

        private void LoadFilePaths()
        {
            ProgDataButton.Value = Properties.Settings.Default.ProgramDataPath;
            CommSiteButton.Value = Properties.Settings.Default.CommSitePath;
        }
        private void OperationTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (OperationTabs.SelectedTab.Text == "Settings")
            {
                LoadFilePaths();
            }
        }
        #endregion

        #region Inverter Tab
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
                }
            }
        }

        private void DeleteInverterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InverterGridView.SelectedRows)
            {
                if (((InverterData)row.DataBoundItem).Name != null)
                {
                    DialogResult Confirm = CMessageBox.Show("Confirm Delete", "Are you sure you want to delete the Inverter: " +
                        ((InverterData)row.DataBoundItem).ToString(), "Yes", "No");
                    if (Confirm == DialogResult.Yes)
                    {
                        InverterList.Remove((InverterData)row.DataBoundItem);
                    }
                }
            }
            SortInverters();
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
            foreach (DataGridViewRow row in InverterGridView.Rows)
            {
                if (((InverterData)row.DataBoundItem).Name == selection)
                {
                    row.Selected = true;
                }
            }
        }
        #endregion

        #region Module Tab
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
                }
            }
        }

        private void DeleteModuleButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ModuleGridView.SelectedRows)
            {
                if (((ModuleData)row.DataBoundItem).Name != null)
                {
                    DialogResult Confirm = CMessageBox.Show("Confirm Delete", "Are you sure you want to delete the Module: " +
                        ((ModuleData)row.DataBoundItem).ToString(), "Yes", "No");
                    if (Confirm == DialogResult.Yes)
                    {
                        ModuleList.Remove((ModuleData)row.DataBoundItem);
                    }
                }
            }
            SortModules();
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
            foreach (DataGridViewRow row in ModuleGridView.Rows)
            {
                if (((ModuleData)row.DataBoundItem).Name == selection)
                {
                    row.Selected = true;
                }
            }
        }
        #endregion

        #region Structure Tab
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
            PackStructure NewPack = PackStructure.Default();
            NewPack.Name = "New Structure";
            CheckExistingAdd<PackStructure>(PackStructureList, NewPack, true);
            SortPackStructures(NewPack.Name);
        }

        private void DuplicatePackStructureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PackStructureGridView.SelectedRows)
            {
                PackStructure newPS = new PackStructure((PackStructure)row.DataBoundItem);
                CheckExistingAdd<PackStructure>(PackStructureList, newPS, true);
                SortPackStructures(newPS.Name);
            }
        }

        private void DeletePackStructureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PackStructureGridView.SelectedRows)
            {
                if (((PackStructure)row.DataBoundItem).Name != null)
                {
                    DialogResult Confirm = CMessageBox.Show("Confirm Delete", "Are you sure you want to delete the Structure: " +
                        ((PackStructure)row.DataBoundItem).ToString(), "Yes", "No");
                    if (Confirm == DialogResult.Yes)
                    {
                        PackStructureList.Remove((PackStructure)row.DataBoundItem);
                        SortPackStructures(null);
                    }
                }
                else if (((PackStructure)row.DataBoundItem).Name == null)
                {
                    DialogResult Confirm = CMessageBox.Show("Confirm Delete",
                        "Are you sure you want to restore the default pack?", "Yes", "No");
                    if (Confirm == DialogResult.Yes)
                    {
                        PackStructureList[PackStructureList.FindIndex(x => x.Name == null)] = PackStructure.Default();
                        SortPackStructures(null);
                    }
                }
            }
        }

        private bool EditTrigger = false;
        private string temp_edit;
        private bool SortTrigger = false;
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
                    SortTrigger = true;
                }
                EditTrigger = false;
            }
        }

        private void PackStructure_SelectionChanged(object sender, EventArgs e)
        {
            PackTree.FillPack((PackStructure)PackStructureDropBox.SelectedItem);
            if (PackTree.CurrentPack.Name == null)
            {
                DeletePackStructureButton.Text = "Restore Default";
            }
            else
            {
                DeletePackStructureButton.Text = "Delete Structure";
            }
        }

        private void PackStructureGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (SortTrigger)
            {
                SortPackStructures(PackStructureGridView.SelectedRows[0].DataBoundItem.ToString());
                SortTrigger = false;
            }
        }

        private void LoadPackStructureButton_Click(object sender, EventArgs e)
        {
            NewPackNumberRequest NumberDialog = new NewPackNumberRequest();
            if (NumberDialog.ShowDialog() == DialogResult.OK)
            {
                string CustomerNumber = NumberDialog.Result;
                ActivePackPaths = new PackPaths(CustomerNumber);
            }
        }
        #endregion

    }
}
