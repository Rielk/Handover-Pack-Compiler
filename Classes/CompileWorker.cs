using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Handover_Pack_Compiler
{
    public class CompileWorker
    {
        private readonly ActivePack PackToCompile = null;
        public CompileWorker(ActivePack AP)
        {
            PackToCompile = AP;
            PackPaths.SetCustomerNumber(PackToCompile.CustomerNumber);
        }

        public void Compile()
        {
            ArchiveCopyDocks();
            int i = 1;
            foreach(Folder folder in PackToCompile.Folders)
            {
                int j = 1;
                foreach (Folder.File file in folder.Files)
                {
                    switch (file.FileType)
                    {
                        case FileTypeTag.Generic:
                            {
                                if (file.GenericPaths.Count > 1)
                                {
                                    int k = 0;
                                    foreach (string path in file.GenericPaths)
                                    {
                                        k++;
                                        string Name = string.Format("{0}.{1}.{2}  {3}", i, j, k, file.Name);
                                        File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name + Path.GetExtension(path)));
                                    }
                                    j++;
                                }
                                else
                                {
                                    foreach (string path in file.GenericPaths)
                                    {
                                        string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                        File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name + Path.GetExtension(path)));
                                        j++;
                                    }
                                }
                                break;
                            }
                        case FileTypeTag.Constant:
                            {
                                string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                string path = file.ConstantPath;
                                File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name + Path.GetExtension(path)));
                                j++;
                                break;
                            }
                        case FileTypeTag.Summary:
                            {
                                object MissingVal = Missing.Value;
                                object TemplatePath = Path.Combine(PackPaths.CustomerFolderNumberN(11), Path.ChangeExtension(file.Name, ".docx"));
                                File.Copy(Path.Combine(Directory.GetParent(Assembly.GetEntryAssembly().Location).FullName, "SummaryDocTemplate.docx"), (string)TemplatePath);
                                Word._Application WordApplication = new Word.Application
                                {
                                    Visible = true
                                };
                                Word._Document WordDoc = WordApplication.Documents.Add(ref TemplatePath, ref MissingVal, ref MissingVal, ref MissingVal);
                                WordDoc.FormFields["Address"].Result = PackToCompile.Address;
                                WordDoc.FormFields["InstallationDate"].Result = PackToCompile.InstallDate.Date.ToString();
                                #region InverterInformation
                                Dictionary<string, int> InvCounts = new Dictionary<string, int>();
                                foreach (InverterData ID in PackToCompile.Inverters)
                                {
                                    foreach (KeyValuePair<string, int> Entry in InvCounts)
                                    {
                                        if (Entry.Key == ID.Name)
                                        {
                                            InvCounts[Entry.Key]++;
                                        }
                                        else
                                        {
                                            InvCounts.Add(ID.Name, 1);
                                        }
                                    }
                                }
                                string InverterInformation = "";
                                foreach (KeyValuePair<string, int> Entry in InvCounts)
                                {
                                    InverterInformation += string.Format("{0}x{1}, ", Entry.Value, Entry.Key);
                                }
                                InverterInformation = InverterInformation.Remove(InverterInformation.Length - 2);
                                #endregion
                                WordDoc.FormFields["InverterInformation"].Result = InverterInformation;
                                #region InverterSerialNumbers
                                string InverterSerialNumber1 = "";
                                string InverterSerialNumber2 = "";
                                string InverterSerialNumber3 = "";
                                string InverterSerialNumber4 = "";
                                List<InverterData> Inverters = PackToCompile.Inverters;
                                for (int x = 0; x < Inverters.Count; x++)
                                {
                                    switch (x)
                                    {
                                        case 0:
                                            InverterSerialNumber1 = Inverters[x].SerialNumber;
                                            break;
                                        case 1:
                                            InverterSerialNumber2 = Inverters[x].SerialNumber;
                                            break;
                                        case 2:
                                            InverterSerialNumber3 = Inverters[x].SerialNumber;
                                            break;
                                        case 3:
                                            InverterSerialNumber4 = Inverters[x].SerialNumber;
                                            break;
                                        case 4:
                                            InverterSerialNumber1 += "  " + Inverters[x].SerialNumber;
                                            break;
                                        case 5:
                                            InverterSerialNumber2 += "  " + Inverters[x].SerialNumber;
                                            break;
                                        case 6:
                                            InverterSerialNumber3 += "  " + Inverters[x].SerialNumber;
                                            break;
                                        case 7:
                                            InverterSerialNumber4 += "  " + Inverters[x].SerialNumber;
                                            break;
                                        default:
                                            throw new NotImplementedException();
                                    }
                                }
                                #endregion
                                WordDoc.FormFields["InverterSerialNumber1"].Result = InverterSerialNumber1;
                                WordDoc.FormFields["InverterSerialNumber2"].Result = InverterSerialNumber2;
                                WordDoc.FormFields["InverterSerialNumber3"].Result = InverterSerialNumber3;
                                WordDoc.FormFields["InverterSerialNumber4"].Result = InverterSerialNumber4;
                                WordDoc.FormFields["JobRef"].Result = PackToCompile.CustomerNumber;
                                #region PanelsInformation
                                Dictionary<string, int> ModCounts = new Dictionary<string, int>();
                                foreach (ModuleData MD in PackToCompile.Modules)
                                {
                                    foreach (KeyValuePair<string, int> Entry in ModCounts)
                                    {
                                        if (Entry.Key == MD.Name)
                                        {
                                            if (MD.Quantity is int Quantity)
                                            {
                                                ModCounts[Entry.Key] += Quantity;
                                            }
                                        }
                                        else
                                        {
                                            if (MD.Quantity is int Quantity)
                                            {
                                                ModCounts.Add(MD.Name, Quantity);
                                            }
                                        }
                                    }
                                }
                                string PanelsInformation = "";
                                foreach (KeyValuePair<string, int> Entry in ModCounts)
                                {
                                    PanelsInformation += string.Format("{0}x{1}, ", Entry.Value, Entry.Key);
                                }
                                PanelsInformation = PanelsInformation.Remove(PanelsInformation.Length - 2);
                                #endregion
                                WordDoc.FormFields["PanelsInformation"].Result = PanelsInformation;
                                WordDoc.FormFields["PredictedOutput"].Result = PackToCompile.PredictedOutput.ToString();
                                WordDoc.FormFields["SystemSize"].Result = PackToCompile.SystemSize.ToString();
                                Process process = Process.Start((string)TemplatePath);
                                process.WaitForExit();
                                string Name = string.Format("{0}.{1}  {2}.pdf", i, j, file.Name);
                                string path = Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name);
                                WordDoc.ExportAsFixedFormat(path, Word.WdExportFormat.wdExportFormatPDF);
                                ArchiveFile((string)TemplatePath);
                                j++;
                                break;
                            }
                        case FileTypeTag.SolarEdgeWarranty:
                            {
                                bool SolarEdge = false;
                                foreach (InverterData ID in PackToCompile.Inverters)
                                {
                                    if (ID.SolarEdge)
                                    {
                                        SolarEdge = true;
                                        break;
                                    }
                                }
                                if (SolarEdge)
                                {
                                    string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    string path = file.ConstantPath;
                                    File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name));
                                    j++;
                                }
                                break;
                            }
                        case FileTypeTag.ModuleWarranty:
                            {
                                List<ModuleData> ToAdd = new List<ModuleData>();
                                foreach (ModuleData MD in PackToCompile.Modules)
                                {
                                    bool NewMD = true;
                                    foreach (ModuleData ExistingMD in ToAdd)
                                    {
                                        if (MD.Name == ExistingMD.Name)
                                        {
                                            NewMD = false;
                                        }
                                    }
                                    if (NewMD)
                                    {
                                        ToAdd.Add(MD);
                                    }
                                }
                                int k = 0;
                                foreach (ModuleData MD in ToAdd)
                                {
                                    k++;
                                    string Name = string.Format("{0}.{1}.{2}  {3}", i, j, k, file.Name);
                                    string path = MD.Warranty;
                                    File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name + Path.GetExtension(path)));
                                }
                                if (ToAdd.Count > 0)
                                {
                                    j++;
                                }
                                break;
                            }
                        case FileTypeTag.ModuleData:
                            {
                                List<ModuleData> ToAdd = new List<ModuleData>();
                                foreach (ModuleData MD in PackToCompile.Modules)
                                {
                                    bool NewMD = true;
                                    foreach (ModuleData ExistingMD in ToAdd)
                                    {
                                        if (MD.Name == ExistingMD.Name)
                                        {
                                            NewMD = false;
                                        }
                                    }
                                    if (NewMD)
                                    {
                                        ToAdd.Add(MD);
                                    }
                                }
                                int k = 0;
                                foreach (ModuleData MD in ToAdd)
                                {
                                    k++;
                                    string Name = string.Format("{0}.{1}.{2}  {3}", i, j, k, file.Name);
                                    string path = MD.Datasheet;
                                    File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name + Path.GetExtension(path)));
                                }
                                if (ToAdd.Count > 0)
                                {
                                    j++;
                                }
                                break;
                            }
                        case FileTypeTag.InverterData:
                            {
                                List<InverterData> ToAdd = new List<InverterData>();
                                foreach(InverterData ID in PackToCompile.Inverters)
                                {
                                    bool NewID = true;
                                    foreach (InverterData ExistingID in ToAdd)
                                    {
                                        if (ID.Name == ExistingID.Name)
                                        {
                                            NewID = false;
                                        }
                                    }
                                    if (NewID)
                                    {
                                        ToAdd.Add(ID);
                                    }
                                }
                                foreach(InverterData ID in ToAdd)
                                {
                                    string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    string path = ID.Datasheet;
                                    File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name));
                                }
                                if (ToAdd.Count > 0)
                                {
                                    j++;
                                }
                                break;
                            }
                        case FileTypeTag.OptimiserData:
                            {
                                List<OptimiserData> ToAdd = new List<OptimiserData>();
                                foreach (OptimiserData OD in PackToCompile.Optimisers)
                                {
                                    bool NewOD = true;
                                    foreach (OptimiserData ExistingOD in ToAdd)
                                    {
                                        if (OD.Name == ExistingOD.Name)
                                        {
                                            NewOD = false;
                                        }
                                    }
                                    if (NewOD)
                                    {
                                        ToAdd.Add(OD);
                                    }
                                }
                                foreach (OptimiserData OD in ToAdd)
                                {
                                    string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    string path = OD.Datasheet;
                                    File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name));
                                }
                                if (ToAdd.Count > 0)
                                {
                                    j++;
                                }
                                break;
                            }
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        public void Zip()
        {
            string TempZip = PackPaths.TempZip;
            Directory.CreateDirectory(TempZip);
            foreach (Folder folder in PackToCompile.Folders)
            {
                string SourcePath = Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name);
                string TargetPath = Path.Combine(PackPaths.TempZip, folder.Name);
                CopyDirectory(SourcePath, TargetPath);
            }
            ZipFile.CreateFromDirectory(TempZip, TempZip+".zip");
            Directory.Delete(TempZip);
        }

        private void ArchiveCopyDocks()
        {
            Directory.CreateDirectory(PackPaths.Archive);
            string CopyDocksPath = PackPaths.CustomerFolderNumberN(11);
            foreach (CommSitePath CSPath in PackToCompile.AllPaths)
            {
                string parent = CSPath.FullPath;
                string ext = "";
                while (!string.IsNullOrEmpty(parent))
                {
                    if (parent == CopyDocksPath)
                    {
                        ArchiveFile(CSPath, Directory.GetParent(ext).FullName);
                        break;
                    }
                    ext = Path.Combine(Path.GetFileName(parent), ext);
                    parent = Directory.GetParent(parent).FullName;
                }
            }
            foreach (string path in Directory.GetFiles(CopyDocksPath))
            {
                ArchiveFile(path);
            }
            foreach (string path in Directory.GetDirectories(CopyDocksPath))
            {
                if (path != PackPaths.Archive)
                {
                    ArchiveDirectory(path);
                }
            }
        }

        private void ArchiveFile(CommSitePath FilePath, string ToSubDirectory = "")
        {
            FilePath.FullPath = ArchiveFile(FilePath.FullPath, ToSubDirectory);
        }

        private string ArchiveFile(string FilePath, string ToSubDirectory = "")
        {
            int count = 0;
            while (true)
            {
                string FileName;
                if (count == 0)
                {
                    FileName = Path.GetFileNameWithoutExtension(FilePath);
                    count++;
                }
                else
                {
                    FileName = Path.GetFileNameWithoutExtension(FilePath) + "(" + count++ + ")";
                }
                string NewPath = Path.Combine(PackPaths.Archive, ToSubDirectory, FileName + Path.GetExtension(FilePath));
                if (!File.Exists(NewPath))
                {
                    File.Move(FilePath, NewPath);
                    return NewPath;
                }
            }
        }

        private string ArchiveDirectory(string DirectoryPath, string ToSubDirectory = "")
        {
            string FolderName = Path.GetDirectoryName(DirectoryPath);
            string NewPath = Path.Combine(PackPaths.Archive, ToSubDirectory, FolderName);
            if (Directory.Exists(NewPath))
            {
                foreach (string path in Directory.GetFiles(DirectoryPath))
                {
                    ArchiveFile(path, Path.Combine(ToSubDirectory, FolderName));
                }
                foreach (string path in Directory.GetDirectories(DirectoryPath))
                {
                    ArchiveDirectory(path, Path.Combine(ToSubDirectory, FolderName));
                }
            }
            else
            {
                Directory.Move(DirectoryPath, NewPath);
            }
            return NewPath;
        }

        private void CopyDirectory(string SourcePath, string TargetPath)
        {
            foreach (string path in Directory.GetFiles(SourcePath))
            {
                File.Copy(path, Path.Combine(TargetPath, Path.GetFileName(path)));
            }
        }
    }
}
