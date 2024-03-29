﻿using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Handover_Pack_Compiler
{
    public class PackStructure : NameCompare
    {
        public override string ToString()
        {
            return Name?.ToString() ?? "Default";
        }
        public string Description { get; set; } = "";
        public List<Folder> Folders = new List<Folder>();
        public PackStructure()
        {

        }
        public PackStructure(PackStructure other)
        {
            Name = other.ToString() + "- Copy";
            Description = other.Description;
            Folders = new List<Folder>();
            foreach (Folder folder in other.Folders)
            {
                Folders.Add(new Folder(folder));
            }
        }
        public Folder AddFolder(string FolderName)
        {
            Folder NewFolder = new Folder() { Name = FolderName };
            AddFolder(NewFolder);
            return NewFolder;
        }
        public void AddFolder(Folder NewFolder)
        {
            Folders.Add(NewFolder);
        }
        public Folder.File AddFile(string FileName, string folder)
        {
            Folder.File NewFile = new Folder.File() { Name = FileName };
            AddFile(NewFile, folder);
            return NewFile;
        }
        public void AddFile(Folder.File NewFile, string folder)
        {
            Folder AddToFolder = Folders.Find(x => x.Name == folder);
            if (AddToFolder != null)
            {
                AddToFolder.AddFile(NewFile);
            }
        }
        public bool CheckConstantFilesExist()
        {
            bool ret = true;
            foreach (Folder folder in Folders)
            {
                if (!folder.CheckConstantFilesExist())
                {
                    ret = false;
                }
            }
            return ret;
        }

        public static PackStructure Default()
        {
            Folder fo;
            Folder.File fi;
            PackStructure DefaultStructure = new PackStructure { Description = "Default Pack" };
            #region 1.0  Important Technical Information
            fo = DefaultStructure.AddFolder("Important Technical Information");
            fo.Description = "Folder containing the Health and Safety Guidelines";
            fi = DefaultStructure.AddFile("Health & Safety Guidelines", "Important Technical Information");
            fi.Description = "Important Health and Safety information";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Constant;
            fi.AllowMultiple = false;
            fi.CSConPath = new CommSitePath
            {
                Extension = "QMS File\\MP014.b Health & Safety Guidelines.pdf",
                InCommSite = true
            };
            #endregion
            #region 2.0  General Information
            fo = DefaultStructure.AddFolder("General Information");
            fo.Description = "Folder containing the Summary and General information file";
            fi = DefaultStructure.AddFile("System Summary & General Information", "General Information");
            fi.Description = "System Summary and General Information";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Summary;
            fi.AllowMultiple = false;
            #endregion
            #region 3.0  Guarantees & Datasheets
            fo = DefaultStructure.AddFolder("Guarantees & Datasheets");
            fo.Description = "Folder containing the Warranties and datasheets for the installed components";
            fi = DefaultStructure.AddFile("Mypower Installation Warranty", "Guarantees & Datasheets");
            fi.Description = "Mypower's installation warranty";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Constant;
            fi.AllowMultiple = false;
            fi.CSConPath = new CommSitePath
            {
                Extension = "QMS File\\MP012 Mypower Installation Warranty.pdf",
                InCommSite = true
            };
            fi = DefaultStructure.AddFile("Module Warranty", "Guarantees & Datasheets");
            fi.Description = "The warranty for the installed modules";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.ModuleWarranty;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("Module Datasheet", "Guarantees & Datasheets");
            fi.Description = "The datasheet for the installed modules";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.ModuleData;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("Inverter datasheet", "Guarantees & Datasheets");
            fi.Description = "The warranty for the installed inverters";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.InverterData;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("Inverter Extended Warranty", "Guarantees & Datasheets");
            fi.Description = "The extended warranty for the installed inverters";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "Warranty";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("SolarEdge Product Warranty", "Guarantees & Datasheets");
            fi.Description = "The SolarEdge warranty";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.SolarEdgeWarranty;
            fi.AllowMultiple = false;
            fi.CSConPath = new CommSitePath
            {
                Extension = "Technical Area\\SOLAR PV\\Inverters\\SolarEdge\\SE Product Warranty\\SolarEdge warranty - May 2020.pdf",
                InCommSite = true
            };
            fi = DefaultStructure.AddFile("SolarEdge Optimiser datasheet", "Guarantees & Datasheets");
            fi.Description = "The datasheet for any optimisers installed";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.OptimiserData;
            fi.AllowMultiple = false;
            #endregion
            #region 4.0  Electrical
            fo = DefaultStructure.AddFolder("Electrical");
            fo.Description = "Folder containing various test reports and sign offs";
            fi = DefaultStructure.AddFile("Installation schematic", "Electrical");
            fi.Description = "Final Installation schematic";
            fi.DefaultFolder = 6;
            fi.SearchTerm = "Schematic";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("Commissioning test report (AC Cert)", "Electrical");
            fi.Description = "AC Cert";
            fi.DefaultFolder = 10;
            fi.SearchTerm = "ac";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("Commissioning test report (DC Cert)", "Electrical");
            fi.Description = "DC Cert";
            fi.DefaultFolder = 10;
            fi.SearchTerm = "dc";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("DNO commissioning form (G99 Form A3-1)", "Electrical");
            fi.Description = "G99 Form A3-1";
            fi.DefaultFolder = 6;
            fi.SearchTerm = "G99";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("Inverter & wiring sign off", "Electrical");
            fi.Description = "Inverter and Wiring sign off";
            fi.DefaultFolder = 10;
            fi.SearchTerm = "inv";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("DNO commissioning notification", "Electrical");
            fi.Description = "DNO commissioning notification email, including the acceptance email if recieved.";
            fi.DefaultFolder = null;
            fi.SearchTerm = "dno";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            #endregion
            #region 5.0  Predicted Output
            fo = DefaultStructure.AddFolder("Predicted Output");
            fo.Description = "Folder containing the predicted output and comparison tool";
            fi = DefaultStructure.AddFile("Summary Report", "Predicted Output");
            fi.Description = "PV Sol/SolarEdge Summary Report";
            fi.DefaultFolder = 1;
            fi.SearchTerm = "pv sol";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("Predicted Output Comparison Tool", "Predicted Output");
            fi.Description = "Predicted output comparison tool, spreadsheet";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "tool";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            #endregion
            #region 6.0  Building Regulations - Work Notification
            fo = DefaultStructure.AddFolder("Building Regulations - Work Notification");
            fo.Description = "Folder containing NAPIT work notification and Struct certs.";
            fi = DefaultStructure.AddFile("NAPIT Work notification details", "Building Regulations - Work Notification");
            fi.Description = "NAPIT work notification details";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "NAPIT";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("Structural survey certificate", "Building Regulations - Work Notification");
            fi.Description = "Structural survey certificate, ask if required";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "struc";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = true;
            #endregion
            #region 7.0  MCS Certificate
            fo = DefaultStructure.AddFolder("MCS Certificate");
            fo.Description = "Folder for the MCS Certificate, only required if System size is less than 50kWp";
            fi = DefaultStructure.AddFile("MCS Certificate", "MCS Certificate");
            fi.Description = "MCS Certificate, only required if System size is less than 50kWp";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "MCS";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            #endregion
            return DefaultStructure;
        }
    }

    public class ActivePack : PackStructure
    {
        private bool _inverterComplete = false;
        private List<InverterData> _inverters = new List<InverterData>();
        private bool _moduleComplete = false;
        private List<ModuleData> _modules = new List<ModuleData>();
        private bool _optimiserComplete = false;
        private List<OptimiserData> _optimisers = new List<OptimiserData>();
        private Folder.File _quoteFile = Folder.File.DefaultQuote();
        private bool _summaryComplete = false;
        private string _address = null;
        private DateTime _installDate = DateTime.Today;
        private decimal _systemSize = 0;
        private decimal _predictedOutput = 0;
        private string _customerNumber = null;
        private string _notes = null;
        private DateTime _lastEdited = DateTime.Now;
        private readonly bool Loading;

        public bool InverterComplete
        {
            get { return _inverterComplete; }
            set
            {
                _inverterComplete = value;
                TriggerEditTime();
            }
        }
        public List<InverterData> Inverters
        {
            get { return _inverters; }
            set
            {
                _inverters = value;
                TriggerEditTime();
            }
        }
        public bool ModuleComplete
        {
            get { return _moduleComplete; }
            set
            {
                _moduleComplete = value;
                TriggerEditTime();
            }
        }
        public List<ModuleData> Modules
        {
            get { return _modules; }
            set
            {
                _modules = value;
                TriggerEditTime();
            }
        }
        public bool OptimiserComplete
        {
            get { return _optimiserComplete; }
            set
            {
                _optimiserComplete = value;
                TriggerEditTime();
            }
        }
        public List<OptimiserData> Optimisers
        {
            get { return _optimisers; }
            set
            {
                _optimisers = value;
                TriggerEditTime();
            }
        }
        public Folder.File QuoteFile
        {
            get { return _quoteFile; }
            set
            {
                _quoteFile = value;
                TriggerEditTime();
            }
        }
        public bool SummaryComplete
        {
            get { return _summaryComplete; }
            set
            {
                _summaryComplete = value;
                TriggerEditTime();
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                TriggerEditTime();
            }
        }
        public DateTime InstallDate
        {
            get { return _installDate; }
            set
            {
                _installDate = value;
                TriggerEditTime();
            }
        }
        public decimal SystemSize
        {
            get { return _systemSize; }
            set
            {
                _systemSize = value;
                TriggerEditTime();
            }
        }
        public decimal PredictedOutput
        {
            get { return _predictedOutput; }
            set
            {
                _predictedOutput = value;
                TriggerEditTime();
            }
        }
        public string CustomerNumber
        {
            get { return _customerNumber; }
            set
            {
                _customerNumber = value;
                TriggerEditTime();
            }
        }
        public string Notes
        {
            get { return _notes; }
            set
            {
                _notes = value;
                TriggerEditTime();
            }
        }
        public DateTime LastEdited
        {
            get
            {
                DateTime ret = _lastEdited;
                foreach (Folder folder in Folders)
                {
                    if (folder.LastEdited > ret)
                    {
                        ret = folder.LastEdited;
                    }
                }
                return ret;
            }
            set { _lastEdited = value; }
        }
        [XmlIgnore]
        public List<CommSitePath> AllPaths
        {
            get
            {
                List<CommSitePath> ret = new List<CommSitePath>();
                foreach(CommSitePath path in QuoteFile.CSGenPaths)
                {
                    ret.Add(path);
                }
                foreach(Folder folder in Folders)
                {
                    foreach (Folder.File file in folder.Files)
                    {
                        foreach (CommSitePath path in file.CSGenPaths)
                        {
                            ret.Add(path);
                        }
                    }
                }
                return ret;
            }
        }
        public bool Complete
        {
            get
            {
                foreach (Folder f in Folders)
                {
                    if (!f.Complete)
                    {
                        return false;
                    }
                }
                if (!InverterComplete || !ModuleComplete || !OptimiserComplete || !SummaryComplete)
                {
                    return false;
                }
                if (!CheckConstantFilesExist())
                {
                    return false;
                }
                return true;
            }
        }
        public ActivePack()
        {
            Loading = true;
        }

        public ActivePack(PackStructure other) : base(other)
        {
        }

        public ActivePack(ActivePack other) : this((PackStructure)other)
        {
            Loading = true;
            Name = other.ToString();
            InverterComplete = other.InverterComplete;
            Inverters = new List<InverterData>();
            foreach (InverterData inverter in other.Inverters)
            {
                Inverters.Add(new InverterData(inverter));
            }
            ModuleComplete = other.ModuleComplete;
            Modules = new List<ModuleData>();
            foreach (ModuleData module in other.Modules)
            {
                Modules.Add(new ModuleData(module));
            }
            OptimiserComplete = other.OptimiserComplete;
            Optimisers = new List<OptimiserData>();
            foreach (OptimiserData optimiser in other.Optimisers)
            {
                Optimisers.Add(new OptimiserData(optimiser));
            }
            QuoteFile = other.QuoteFile;
            SummaryComplete = other.SummaryComplete;
            Address = other.Address;
            InstallDate = other.InstallDate;
            SystemSize = other.SystemSize;
            PredictedOutput = other.PredictedOutput;
            CustomerNumber = other.CustomerNumber;
            Notes = other.Notes;
            LastEdited = other.LastEdited;
            Loading = false;
        }

        public void TriggerEditTime()
        {
            if (!Loading)
            {
                LastEdited = DateTime.Now;
            }
        }

        public void CheckPathsExist()
        {
            foreach (Folder folder in Folders)
            {
                folder.CheckPathsExist();
            }
        }

        public void Autofill()
        {
            string TempCustomer = null;
            if (PackPaths.CustomerNumber != CustomerNumber)
            {
                TempCustomer = PackPaths.CustomerNumber;
                PackPaths.SetCustomerNumber(CustomerNumber);
            }
            QuoteFile?.Autofill();
            foreach (Folder folder in Folders)
            {
                folder.Autofill();
            }
            if (TempCustomer != null)
            {
                PackPaths.SetCustomerNumber(TempCustomer);
            }
        }
    }
    public class Folder
    {
        public bool Complete
        {
            get
            {
                foreach (File f in Files)
                {
                    if (!f.Complete)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public DateTime LastEdited
        {
            get
            {
                DateTime ret = DateTime.MinValue;
                foreach (File file in Files)
                {
                    if (file.LastEdited > ret)
                    {
                        ret = file.LastEdited;
                    }
                }
                return ret;
            }
        }

        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<File> Files { get; } = new List<File>();
        public Folder()
        {

        }
        public Folder(Folder other)
        {
            Name = other.Name;
            Description = other.Description;
            Files = new List<File>();
            foreach (File file in other.Files)
            {
                Files.Add(new File(file));
            }
        }
        public void AddFile(string FileName)
        {
            AddFile(new File() { Name = FileName });
        }
        public void AddFile(File NewFile)
        {
            Files.Add(NewFile);
        }
        public void CheckPathsExist()
        {
            foreach (File file in Files)
            {
                file.CheckPathsExist();
            }
        }
        public bool CheckConstantFilesExist()
        {
            bool ret = true;
            foreach (File file in Files)
            {
                if (!file.CheckConstantFilesExist())
                {
                    ret = false;
                }
            }
            return ret;
        }

        public void Autofill()
        {
            foreach (File file in Files)
            {
                file.Autofill();
            }
        }

        public class File
        {
            public CommSitePath CSConPath = new CommSitePath("");
            public List<CommSitePath> CSGenPaths = new List<CommSitePath>();
            private bool _complete = false;
            private readonly bool Loading;
            public string Name { get; set; } = "";
            public string Description { get; set; } = "";
            public int? DefaultFolder { get; set; } = null;
            public string SearchTerm { get; set; } = null;
            public bool AlwaysRequired { get; set; } = true;
            public string FileType { get; set; } = FileTypeTag.Generic;
            public bool AllowMultiple { get; set; } = false;
            public bool Complete
            {
                get { return _complete; }
                set
                {
                    _complete = value;
                    TriggerEditTime();
                }
            }
            public DateTime LastEdited { get; set; } = DateTime.Now;
            [XmlIgnore]
            public string ConstantPath
            {
                get { return CSConPath.FullPath; }
                set
                {
                    CSConPath.FullPath = value;
                    TriggerEditTime();
                }
            }
            public List<string> GenericPaths
            {
                get { return (from CSP in CSGenPaths select CSP.FullPath).ToList(); }
                set
                {
                    CSGenPaths = (from str in value select new CommSitePath(str)).ToList();
                    TriggerEditTime();
                }
            }
            public File()
            {

            }
            public File(File other)
            {
                Loading = true;
                Name = other.Name;
                Description = other.Description;
                DefaultFolder = other.DefaultFolder;
                SearchTerm = other.SearchTerm;
                AlwaysRequired = other.AlwaysRequired;
                FileType = other.FileType;
                AllowMultiple = other.AllowMultiple;
                CSConPath = new CommSitePath(null);
                ConstantPath = other.ConstantPath;
                CSGenPaths = (from CSP in other.CSGenPaths select CSP).ToList();
                Complete = other.Complete;
                LastEdited = other.LastEdited;
                Loading = false;
            }
            public void TriggerEditTime()
            {
                if (!Loading)
                {
                    LastEdited = DateTime.Now;
                }
            }

            public void CheckPathsExist()
            {
                foreach (CommSitePath CSP in CSGenPaths.ToList())
                {
                    if (!System.IO.File.Exists(CSP.FullPath))
                    {
                        CSGenPaths.Remove(CSP);
                        Complete = false;
                    }
                }
            }

            public bool CheckConstantFilesExist()
            {
                if (FileType == FileTypeTag.Constant)
                {
                    return System.IO.File.Exists(ConstantPath) & !string.IsNullOrWhiteSpace(ConstantPath);
                }
                else
                {

                    return true;
                }
            }

            public void Autofill()
            {
                if (FileType == FileTypeTag.Generic && SearchTerm != null)
                {
                    List<string> Terms = SearchTerm.Split(',').Select(x => x.Trim()).ToList();
                    List<string> AllFiles = new List<string>();
                    string LookInFolder;
                    if (DefaultFolder is int FolderNumber)
                    {
                        LookInFolder = PackPaths.CustomerFolderNumberN(FolderNumber);
                    }
                    else
                    {
                        LookInFolder = PackPaths.CustomerFolder;
                    }
                    foreach (string term in Terms)
                    {
                        string[] files = Directory.GetFiles(LookInFolder,"*" + term + "*", SearchOption.AllDirectories);
                        foreach (string f in files)
                        {
                            if (!(f.IndexOf("Archive", StringComparison.OrdinalIgnoreCase) >= 0))
                            {
                                AllFiles.Add(f);
                            }
                        }
                    }
                    GenericPaths = AllFiles;
                }
            }

            public static File DefaultQuote()
            {
                File file = new File()
                {
                    FileType = FileTypeTag.Generic,
                    AllowMultiple = false,
                    AlwaysRequired = true,
                    Description = "The Quotation File sent to the customer.\nContains" +
                            " useful information like the size of the installation which can be" +
                            " referred back to later.",
                    DefaultFolder = 1,
                    SearchTerm = "quote, quotation"
                };
                return file;
            }
        }
    }
}
