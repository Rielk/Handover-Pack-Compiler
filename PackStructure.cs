using ExtensionMethods;
using System;
using System.Collections.Generic;
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
        public List<InverterData> Inverters = null;
        public List<ModuleData> Modules = null;
        public List<OptimiserData> Optimisers = null;
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
            Inverters = new List<InverterData>();
            foreach (InverterData inverter in other.Inverters)
            {
                Inverters.Add(new InverterData(inverter));
            }
            Modules = new List<ModuleData>();
            foreach (ModuleData module in other.Modules)
            {
                Modules.Add(new ModuleData(module));
            }
            Optimisers = new List<OptimiserData>();
            foreach (OptimiserData optimiser in other.Optimisers)
            {
                Optimisers.Add(new OptimiserData(optimiser));
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
        public static PackStructure Default()
        {
            Folder fo;
            Folder.File fi;
            PackStructure DefaultStructure = new PackStructure { Description = "Default Pack" };
            #region 1.0  Important Technical Information
            fo = DefaultStructure.AddFolder("1.0  Important Technical Information");
            fo.Description = "Folder containing the Health and Safety Guidelines";
            fi = DefaultStructure.AddFile("1.1  Health & Safety Guidelines", "1.0  Important Technical Information");
            fi.Description = "Important Health and Safety information";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Constant;
            fi.AllowMultiple = false;
            fi.CSPath = new CommSitePath
            {
                Extension = "QMS File\\MP014.b Health & Safety Guidelines.pdf",
                InCommSite = true
            };
            #endregion
            #region 2.0  General Information
            fo = DefaultStructure.AddFolder("2.0  General Information");
            fo.Description = "Folder containing the Summary and General information file";
            fi = DefaultStructure.AddFile("2.1  System Summary & General Information", "2.0  General Information");
            fi.Description = "System Summary and General Information";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Summary;
            fi.AllowMultiple = false;
            #endregion
            #region 3.0  Guarantees & Datasheets
            fo = DefaultStructure.AddFolder("3.0  Guarantees & Datasheets");
            fo.Description = "Folder containing the Warranties and datasheets for the installed components";
            fi = DefaultStructure.AddFile("3.1  Mypower Installation Warranty", "3.0  Guarantees & Datasheets");
            fi.Description = "Mypower's installation warranty";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Constant;
            fi.AllowMultiple = false;
            fi.CSPath = new CommSitePath
            {
                Extension = "QMS File\\MP012 Mypower Installation Warranty.pdf",
                InCommSite = true
            };
            fi = DefaultStructure.AddFile("3.2  Module Warranty", "3.0  Guarantees & Datasheets");
            fi.Description = "The warranty for the installed modules";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.ModuleWarranty;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("3.3  Module Datasheet", "3.0  Guarantees & Datasheets");
            fi.Description = "The datasheet for the installed modules";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.ModuleData;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("3.4  Inverter datasheet", "3.0  Guarantees & Datasheets");
            fi.Description = "The warranty for the installed inverters";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.InverterData;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("3.4a  Inverter Extended Warranty", "3.0  Guarantees & Datasheets");
            fi.Description = "The extended warranty for the installed inverters";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "Warranty";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = true;
            fi = DefaultStructure.AddFile("3.5  SolarEdge Product Warranty", "3.0  Guarantees & Datasheets");
            fi.Description = "The SolarEdge warranty";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.SolarEdgeWarranty;
            fi.AllowMultiple = false;
            fi.CSPath = new CommSitePath
            {
                Extension = "Technical Area\\SOLAR PV\\Inverters\\SolarEdge\\SE Product Warranty\\SolarEdge warranty - May 2020.pdf",
                InCommSite = true
            };
            fi = DefaultStructure.AddFile("3.6  SolarEdge Optimiser datasheet", "3.0  Guarantees & Datasheets");
            fi.Description = "The datasheet for any optimisers installed";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.OptimiserData;
            fi.AllowMultiple = false;
            #endregion
            #region 4.0  Electrical
            fo = DefaultStructure.AddFolder("4.0  Electrical");
            fo.Description = "Folder containing various test reports and sign offs";
            fi = DefaultStructure.AddFile("4.1  Installation schematic", "4.0  Electrical");
            fi.Description = "Final Installation schematic";
            fi.DefaultFolder = 6;
            fi.SearchTerm = "Schematic";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("4.2  Commissioning test report (AC Cert)", "4.0  Electrical");
            fi.Description = "AC Cert";
            fi.DefaultFolder = 10;
            fi.SearchTerm = "ac";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("4.3  Commissioning test report (DC Cert)", "4.0  Electrical");
            fi.Description = "DC Cert";
            fi.DefaultFolder = 10;
            fi.SearchTerm = "dc";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("4.4  DNO commissioning form (G99 Form A3-1)", "4.0  Electrical");
            fi.Description = "G99 Form A3-1";
            fi.DefaultFolder = 6;
            fi.SearchTerm = "G99";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("4.5  Inverter & wiring sign off", "4.0  Electrical");
            fi.Description = "Inverter and Wiring sign off";
            fi.DefaultFolder = 10;
            fi.SearchTerm = "inv";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("4.6  DNO commissioning notification", "4.0  Electrical");
            fi.Description = "DNO commissioning notification email, including the acceptance email if recieved.";
            fi.DefaultFolder = 12;
            fi.SearchTerm = "dno";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            #endregion
            #region 5.0  Predicted Output
            fo = DefaultStructure.AddFolder("5.0  Predicted Output");
            fo.Description = "Folder containing the predicted output and comparison tool";
            fi = DefaultStructure.AddFile("5.1  Summary Report", "5.0  Predicted Output");
            fi.Description = "PV Sol/SolarEdge Summary Report";
            fi.DefaultFolder = 1;
            fi.SearchTerm = "pv sol";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("5.2  Predicted Output Comparison Tool", "5.0  Predicted Output");
            fi.Description = "Predicted output comparison tool, spreadsheet";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "tool";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            #endregion
            #region 6.0  Building Regulations - Work Notification
            fo = DefaultStructure.AddFolder("6.0  Building Regulations - Work Notification");
            fo.Description = "Folder containing NAPIT work notification and Struct certs.";
            fi = DefaultStructure.AddFile("6.1  NAPIT Work notification details", "6.0  Building Regulations - Work Notification");
            fi.Description = "NAPIT work notification details";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "NAPIT";
            fi.AlwaysRequired = true;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            fi = DefaultStructure.AddFile("6.2  Structural survey certificate", "6.0  Building Regulations - Work Notification");
            fi.Description = "Structural survey certificate, ask if required";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "struc";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = true;
            #endregion
            #region 7.0  MCS Certificate
            fo = DefaultStructure.AddFolder("7.0  MCS Certificate");
            fo.Description = "MCS Certificate, only required if System size is less than 50kWp";
            fi = DefaultStructure.AddFile("7.1  MCS Certificate", "7.0  MCS Certificate");
            fi.Description = "MCS Certificate";
            fi.DefaultFolder = 11;
            fi.SearchTerm = "MCS";
            fi.AlwaysRequired = false;
            fi.FileType = FileTypeTag.Generic;
            fi.AllowMultiple = false;
            #endregion
            return DefaultStructure;
        }
    }
    public class Folder
    {
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

        public class File
        {
            public CommSitePath CSPath = new CommSitePath("");
            public string Name { get; set; } = "";
            public string Description { get; set; } = "";
            public int? DefaultFolder { get; set; } = null;
            public string SearchTerm { get; set; } = null;
            public bool AlwaysRequired { get; set; } = true;
            public string FileType { get; set; } = FileTypeTag.Generic;
            public bool AllowMultiple { get; set; } = false;
            [XmlIgnore]
            public string Path
            {
                get { return CSPath.FullPath; }
                set { CSPath.FullPath = value; }
            }
            public File()
            {

            }
            public File(File other)
            {
                Name = other.Name;
                Description = other.Description;
                DefaultFolder = other.DefaultFolder;
                SearchTerm = other.SearchTerm;
                AlwaysRequired = other.AlwaysRequired;
                FileType = other.FileType;
                AllowMultiple = other.AllowMultiple;
                CSPath = new CommSitePath(null);
                Path = other.Path;
            }
        }
    }
}
