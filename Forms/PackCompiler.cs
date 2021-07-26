using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public static List<InverterData> InverterList;
        public static List<ModuleData> ModuleList;
        public static List<OptimiserData> OptimiserList;
        public static List<PackStructure> PackStructureList;
        public static List<ActivePack> ActivePackList;
        private bool RequireReload = false;
        private ActivePack loadedPack = null;
        public ActivePack LoadedPack
        {
            get { return loadedPack; }
            set
            {
                loadedPack = value;
                LoadActivePack();
            }
        }

        public PackCompiler()
        {
            InitializeComponent();
            CheckFilePaths();
            LoadFilePaths();

            InverterList = Utilities.ReadFromFile<InverterData>("Inverters.xml");
            InverterDataSource.DataSource = InverterList;
            

            ModuleList = Utilities.ReadFromFile<ModuleData>("Modules.xml");
            ModuleDataSource.DataSource = ModuleList;

            OptimiserList = Utilities.ReadFromFile<OptimiserData>("Optimisers.xml");
            OptimiserDataSource.DataSource = OptimiserList;

            ProgDataButton.InitialPathFunction = DefaultPath.ProgData;
            CommSiteButton.InitialPathFunction = DefaultPath.CommSite;

            PackStructureList = Utilities.ReadFromFile<PackStructure>("Pack Structures.xml");
            if (PackStructureList.Count == 0)
            {
                PackStructureList.Add(PackStructure.Default());
            }
            PackStructureSource.DataSource = PackStructureList;
            SortPackStructures();

            ActivePackList = Utilities.ReadFromFile<ActivePack>("Started Packs.xml");
            foreach(ActivePack AP in ActivePackList)
            {
                AP.CheckPathsExist();
            }
            ActivePackSource.DataSource = ActivePackList;

            AssertComponentsExist();
            SortInverters();
            SortModules();
            SortOptimisers();
            SortActivePacks();
        }

        #region General Utilities
        private void PackCompiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilities.WriteToFile(InverterList, "Inverters.xml", true);
            Utilities.WriteToFile(ModuleList, "Modules.xml", true);
            Utilities.WriteToFile(OptimiserList, "Optimisers.xml", true);
            Utilities.WriteToFile(PackStructureList, "Pack Structures.xml", false);
            Utilities.WriteToFile(ActivePackList, "Started Packs.xml", false);
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

        private void OperationTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (OperationTabs.SelectedTab == SettingsTab)
            {
                LoadFilePaths();
            }
            else if (OperationTabs.SelectedTab == PacksTab)
            {
                PackGridView_SelectionChanged(null, null);
            }
            else if (OperationTabs.SelectedTab == FilesTab)
            {
                if (RequireReload)
                {
                    LoadActivePack();
                }
            }
        }

        private void LoadAndSwitchToPack(ActivePack PackToLoad)
        {
            LoadedPack = PackToLoad;
            OperationTabs.SelectedTab = FilesTab;
            FilesTab.VerticalScroll.Value = 0;
        }

        private void AssertComponentsExist()
        {
            foreach (ActivePack AP in ActivePackList)
            {
                foreach (InverterData ID in AP.Inverters)
                {
                    if (!InverterList.Contains(ID))
                    {
                        MessageBox.Show("Inverter \"" + ID.Name + "\" was renamed or removed at some point." +
                            " It has been re-added for Pack ID:" + AP.CustomerNumber.ToString(), "Missing Inverter");
                        InverterList.Add(ID);
                    }
                }
                foreach (ModuleData MD in AP.Modules)
                {
                    if (!ModuleList.Contains(MD))
                    {
                        MessageBox.Show("Module \"" + MD.Name + "\" was renamed or removed at some point." +
                            " It has been re-added for Pack ID:" + AP.CustomerNumber.ToString(), "Missing Module");
                        ModuleList.Add(MD);
                    }
                }
                foreach (OptimiserData OD in AP.Optimisers)
                {
                    if (!OptimiserList.Contains(OD))
                    {
                        MessageBox.Show("Optimiser \"" + OD.Name + "\" was renamed or removed at some point." +
                            " It has been re-added for Pack ID:" + AP.CustomerNumber.ToString(), "Missing Optimiser");
                        OptimiserList.Add(OD);
                    }
                }
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

                foreach (ActivePack AP in ActivePackList)
                {
                    foreach (InverterData ID in AP.Inverters)
                    {
                        if (ID.Name == ((InverterData)row.DataBoundItem).Name)
                        {
                            AP.Inverters.Remove(ID);
                            AP.InverterComplete = false;
                            if (AP == LoadedPack)
                            {
                                RequireReload = true;
                            }
                        }
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

                    foreach (ActivePack AP in ActivePackList)
                    {
                        foreach (InverterData ID in AP.Inverters)
                        {
                            if (ID.Name == IData.Name)
                            {
                                ID.Name = IVForm.NameVal;
                                ID.Datasheet = IVForm.DatasheetVal;
                                ID.SolarEdge = IVForm.SolarEdgeVal;
                                AP.InverterComplete = false;
                                if (AP == LoadedPack)
                                {
                                    RequireReload = true;
                                }
                            }
                        }
                    }
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

        #region Optimiser Tab
        private void AddOptimiserButton_Click(object sender, EventArgs e)
        {
            OptimiserValuesForm OVForm = new OptimiserValuesForm();
            if (OVForm.ShowDialog() == DialogResult.OK)
            {
                OptimiserData OData = new OptimiserData
                {
                    Name = OVForm.NameVal,
                    Datasheet = OVForm.DatasheetVal
                };
                if (CheckExistingAdd<OptimiserData>(OptimiserList, OData, false))
                {
                    SortOptimisers(OData.Name);
                }
            }
        }

        private void DeleteOptimiserButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OptimiserGridView.SelectedRows)
            {
                if (((OptimiserData)row.DataBoundItem).Name != null)
                {
                    DialogResult Confirm = CMessageBox.Show("Confirm Delete", "Are you sure you want to delete the Optimiser: " +
                        ((OptimiserData)row.DataBoundItem).ToString(), "Yes", "No");
                    if (Confirm == DialogResult.Yes)
                    {
                        OptimiserList.Remove((OptimiserData)row.DataBoundItem);
                    }
                }
            }
            SortOptimisers();
        }

        private void EditOptimiserButton_Click(object sender, EventArgs e)
        {
            OptimiserData OData = (OptimiserData)OptimiserGridView.SelectedRows[0].DataBoundItem;
            if (OData.Name != null)
            {
                OptimiserValuesForm OVForm = new OptimiserValuesForm(OData.Name, OData.Datasheet);
                if (OVForm.ShowDialog() == DialogResult.OK)
                {
                    OptimiserList.Remove(OData);
                    OData.Name = OVForm.NameVal;
                    OData.Datasheet = OVForm.DatasheetVal;
                    OptimiserList.Add(OData);
                    SortOptimisers(OData.Name);
                }
            }
        }

        private void SortOptimisers()
        {
            OptimiserList.Sort();
            OptimiserDataSource.ResetBindings(false);
        }

        private void SortOptimisers(string selection)
        {
            SortOptimisers();
            foreach (DataGridViewRow row in OptimiserGridView.Rows)
            {
                if (((OptimiserData)row.DataBoundItem).Name == selection)
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
            bool Requesting = true;
            while (Requesting)
            {
                if (NumberDialog.ShowDialog() == DialogResult.OK)
                {
                    string CustomerNumber = NumberDialog.Result;
                    bool valid = PackPaths.SetCustomerNumber(CustomerNumber);
                    if (valid)
                    {
                        ActivePack NewStructure = null;
                        foreach (ActivePack AP in ActivePackList)
                        {
                            if (AP.CustomerNumber == CustomerNumber)
                            {
                                NewStructure = AP;
                                break;
                            }
                        }
                        if (NewStructure == null)
                        {
                            NewStructure = new ActivePack((PackStructure)PackStructureGridView.SelectedRows[0].DataBoundItem)
                            {
                                CustomerNumber = CustomerNumber
                            };
                            ActivePackList.Add(NewStructure);
                            SortActivePacks();
                        }
                        LoadAndSwitchToPack(NewStructure);
                        Requesting = false;
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Couldn't find a folder for the customer number \"{0}\". Please make sure the folder exists.", CustomerNumber),
                            "Customer Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Requesting = false;
                }
            }
        }
        #endregion

        #region Files Tab
        private void LoadActivePack()
        {
            if (LoadedPack != null)
            {
                List<Control> ControlsToAdd = new List<Control>();

                {
                    Folder.File file;
                    if (LoadedPack.QuoteFile == null)
                    {
                        file = new Folder.File()
                        {
                            FileType = FileTypeTag.Generic,
                            AllowMultiple = false,
                            AlwaysRequired = true,
                            Description = "The Quotation File sent to the customer.\nContains" +
                            "useful information like the size of the installation which can be" +
                            "referred back to later.",
                            DefaultFolder = 1,
                            SearchTerm = "quote"
                        };
                        loadedPack.QuoteFile = file;
                    }
                    else
                    {
                        file = LoadedPack.QuoteFile;
                    }
                    FileUI NewSelector = new FileUI(file)
                    {
                        Text = PackPaths.IDCustomerName + " Quote File",
                        Dock = DockStyle.Top
                    };
                    ControlsToAdd.Add(NewSelector);
                }

                bool requireInverters = false;
                bool requireModules = false;
                bool requireOptimisers = false;
                bool requireAdditional = false;
                foreach (Folder folder in LoadedPack.Folders)
                {
                    foreach (Folder.File file in folder.Files)
                    {
                        if (file.FileType == FileTypeTag.Summary)
                        {
                            file.Complete = true;
                            requireInverters = true;
                            requireModules = true;
                            requireAdditional = true;
                        }
                        else if (file.FileType == FileTypeTag.InverterData | file.FileType == FileTypeTag.SolarEdgeWarranty)
                        {
                            file.Complete = true;
                            requireInverters = true;
                        }
                        else if (file.FileType == FileTypeTag.ModuleData | file.FileType == FileTypeTag.ModuleWarranty)
                        {
                            file.Complete = true;
                            requireModules = true;
                        }
                        else if (file.FileType == FileTypeTag.OptimiserData)
                        {
                            file.Complete = true;
                            requireOptimisers = true;
                        }
                        else if (file.FileType == FileTypeTag.Constant)
                        {
                            file.Complete = true;
                        }
                    }
                }

                if (requireInverters)
                {
                    InverterUI ISelector = new InverterUI(LoadedPack)
                    {
                        Dock = DockStyle.Top
                    };
                    ControlsToAdd.Add(ISelector);
                }
                else
                {
                    LoadedPack.InverterComplete = true;
                }
                if (requireModules)
                {
                    ModuleUI MSelector = new ModuleUI(LoadedPack)
                    {
                        Dock = DockStyle.Top
                    };
                    ControlsToAdd.Add(MSelector);
                }
                else
                {
                    LoadedPack.ModuleComplete = true;
                }
                if (requireOptimisers)
                {
                    OptimiserUI OSelector = new OptimiserUI(LoadedPack)
                    {
                        Dock = DockStyle.Top
                    };
                    ControlsToAdd.Add(OSelector);
                }
                else
                {
                    LoadedPack.OptimiserComplete = true;
                }
                if (requireAdditional)
                {
                    SummaryInformation SumInf = new SummaryInformation(LoadedPack)
                    {
                        Dock = DockStyle.Top
                    };
                    ControlsToAdd.Add(SumInf);
                }
                else
                {
                    LoadedPack.SummaryComplete = true;
                }

                int FolderNumber = 0;
                foreach (Folder folder in LoadedPack.Folders)
                {
                    FolderNumber++;
                    int FileNumber = 0;
                    foreach (Folder.File file in folder.Files)
                    {
                        FileNumber++;
                        if (file.FileType == FileTypeTag.Generic)
                        {
                            FileUI NewSelector = new FileUI(file)
                            {
                                Text = FolderNumber.ToString() + "." + FileNumber.ToString() + "  " + file.Name,
                                Dock = DockStyle.Top
                            };
                            ControlsToAdd.Add(NewSelector);
                        }
                    }
                }
                for (int i = ControlsToAdd.Count - 1; i >= 0; i--)
                {
                    FilesTab.Controls.Add(ControlsToAdd[i]);
                }
            }
        }
        #endregion

        #region Packs Tab
        private void SortActivePacks()
        {
            ActivePackList.Sort((x, y) => x.CustomerNumber.CompareTo(y.CustomerNumber));
            ActivePackSource.ResetBindings(false);
        }

        private void PackGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (PackGridView.SelectedRows.Count > 0)
            {
                CompilePackButton.Enabled = ((ActivePack)PackGridView.SelectedRows[0].DataBoundItem).Complete;
                LoadPackButton.Enabled = true;
            }
            else
            {
                LoadPackButton.Enabled = false;
            }
        }

        private void LoadPackButton_Click(object sender, EventArgs e)
        {
            PackPaths.SetCustomerNumber(((ActivePack)PackGridView.SelectedRows[0].DataBoundItem).CustomerNumber);
            LoadAndSwitchToPack((ActivePack)PackGridView.SelectedRows[0].DataBoundItem);
        }

        private void CompilePackButton_Click(object sender, EventArgs e)
        {
            ActivePack SelectedPack = (ActivePack)PackGridView.SelectedRows[0].DataBoundItem;
            PackPaths.SetCustomerNumber(SelectedPack.CustomerNumber);
            LoadedPack = SelectedPack;
            if (MessageBox.Show("Are you sure you want to create the pack for \"" + PackPaths.IDCustomerName + "\"? " +
                Environment.NewLine +"Any folders or files in \"Copy Docs for Handover Pack\" will be moved to the archive folder.",
                "Compile Pack", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CompileWorker CW = new CompileWorker(SelectedPack);
                CW.Compile();
                CW.Zip();
                Process.Start(PackPaths.CustomerFolderNumberN(11));
            }
            
        }
        #endregion
    }
}
