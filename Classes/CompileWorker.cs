using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
                string NumericalFolderName = string.Format("{0}.0  {1}", i, folder.Name);
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
                                        CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name + Path.GetExtension(path)));
                                    }
                                    j++;
                                }
                                else
                                {
                                    foreach (string path in file.GenericPaths)
                                    {
                                        string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                        CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name + Path.GetExtension(path)));
                                        j++;
                                    }
                                }
                                break;
                            }
                        case FileTypeTag.Constant:
                            {
                                string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                string path = file.ConstantPath;
                                CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name + Path.GetExtension(path)));
                                j++;
                                break;
                            }
                        case FileTypeTag.Summary:
                            {
                                object MissingVal = Missing.Value;
                                object TemplatePath = Path.Combine(PackPaths.CustomerFolderNumberN(11), Path.ChangeExtension(file.Name, ".docx")).Remove(0, 4);
                                File.Copy(Path.Combine(Directory.GetParent(Assembly.GetEntryAssembly().Location).FullName, "SummaryDocTemplate.docx"), (string)TemplatePath);
                                Word.Application WordApplication = new Word.Application
                                {
                                    Visible = false
                                };
                                Word.Document WordDoc = WordApplication.Documents.Open(ref TemplatePath);
                                Word.Variables Variables = WordDoc.Variables;
                                Variables["Address"].Value = PackToCompile.Address;
                                Variables["InstallationDate"].Value = PackToCompile.InstallDate.Date.ToString("dd/MM/yyyy");
                                #region InverterInformation
                                Dictionary<string, int> InvCounts = new Dictionary<string, int>();
                                foreach (InverterData ID in PackToCompile.Inverters)
                                {
                                    if (InvCounts.ContainsKey(ID.Name))
                                    {
                                        InvCounts[ID.Name]++;
                                    }
                                    else
                                    {
                                        InvCounts.Add(ID.Name, 1);
                                    }
                                }
                                string InverterInformation = "";
                                foreach (KeyValuePair<string, int> Entry in InvCounts)
                                {
                                    InverterInformation += string.Format("{0} x {1}, ", Entry.Value, Entry.Key);
                                }
                                InverterInformation = InverterInformation.Remove(InverterInformation.Length - 2);
                                #endregion
                                Variables["InverterInformation"].Value = InverterInformation;
                                #region InverterSerialNumbers
                                string InverterSerialNumber1 = " ";
                                string InverterSerialNumber2 = " ";
                                string InverterSerialNumber3 = " ";
                                string InverterSerialNumber4 = " ";
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
                                Variables["InverterSerialNumber1"].Value = InverterSerialNumber1;
                                Variables["InverterSerialNumber2"].Value = InverterSerialNumber2;
                                Variables["InverterSerialNumber3"].Value = InverterSerialNumber3;
                                Variables["InverterSerialNumber4"].Value = InverterSerialNumber4;
                                Variables["JobRef"].Value = PackToCompile.CustomerNumber;
                                #region PanelsInformation
                                Dictionary<string, int> ModCounts = new Dictionary<string, int>();
                                foreach (ModuleData MD in PackToCompile.Modules)
                                {
                                    if (ModCounts.ContainsKey(MD.Name))
                                    {
                                        if (MD.Quantity is int Quantity)
                                        {
                                            ModCounts[MD.Name] += Quantity;
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
                                string PanelsInformation = "";
                                foreach (KeyValuePair<string, int> Entry in ModCounts)
                                {
                                    PanelsInformation += string.Format("{0} x {1}, ", Entry.Value, Entry.Key);
                                }
                                PanelsInformation = PanelsInformation.Remove(PanelsInformation.Length - 2);
                                #endregion
                                Variables["PanelsInformation"].Value = PanelsInformation;
                                Variables["PredictedOutput"].Value = PackToCompile.PredictedOutput.ToString();
                                Variables["SystemSize"].Value = PackToCompile.SystemSize.ToString();
                                WordDoc.Fields.Update();
                                WordDoc.Close(Word.WdSaveOptions.wdSaveChanges);
                                Process process = Process.Start((string)TemplatePath);
                                process.WaitForExit();
                                string Name = string.Format("{0}.{1}  {2}.pdf", i, j, file.Name);
                                string path = Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name).Remove(0, 4);
                                WordDoc = WordApplication.Documents.Open(ref TemplatePath);
                                Directory.CreateDirectory(Directory.GetParent(path).FullName);
                                WordDoc.ExportAsFixedFormat(path, Word.WdExportFormat.wdExportFormatPDF);
                                WordDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
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
                                    CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name + Path.GetExtension(path)));
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
                                    string Name;
                                    if (ToAdd.Count > 1)
                                    {
                                        Name = string.Format("{0}.{1}.{2}  {3}", i, j, k, file.Name);
                                    }
                                    else
                                    {
                                        Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    }
                                    string path = MD.Warranty;
                                    CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name + Path.GetExtension(path)));
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
                                    string Name;
                                    if (ToAdd.Count > 1)
                                    {
                                        Name = string.Format("{0}.{1}.{2}  {3}", i, j, k, file.Name);
                                    }
                                    else
                                    {
                                        Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    }
                                    string path = MD.Datasheet;
                                    CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name + Path.GetExtension(path)));
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
                                int k = 0;
                                foreach(InverterData ID in ToAdd)
                                {
                                    k++;
                                    string Name;
                                    if (ToAdd.Count > 1)
                                    {
                                        Name = string.Format("{0}.{1}.{2}  {3}", i, j, k, file.Name);
                                    }
                                    else
                                    {
                                        Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    }
                                    string path = ID.Datasheet;
                                    CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name + Path.GetExtension(path)));
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
                                    CopyFile(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), NumericalFolderName, Name));
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
                i++;
            }
        }

        public void Zip()
        {
            string TempZip = PackPaths.TempZip;
            Directory.CreateDirectory(TempZip);
            int i = 0;
            foreach (Folder folder in PackToCompile.Folders)
            {
                i++;
                string SourcePath = Path.Combine(PackPaths.CustomerFolderNumberN(11), string.Format("{0}.0  {1}", i, folder.Name));
                string TargetPath = Path.Combine(PackPaths.TempZip, string.Format("{0}.0  {1}", i, folder.Name));
                if (Directory.Exists(SourcePath))
                {
                    CopyDirectory(SourcePath, TargetPath);
                }
            }
            ZipFile.CreateFromDirectory(TempZip, TempZip+".zip");
            Directory.Delete(TempZip, true);
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
                        ArchiveFile(CSPath, Path.GetDirectoryName(ext));
                        break;
                    }
                    ext = Path.Combine(Path.GetFileName(parent), ext);
                    parent = Directory.GetParent(parent)?.FullName;
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
                    Directory.CreateDirectory(Path.GetDirectoryName(NewPath));
                    if (File.Exists(FilePath))
                    {
                        while (true)
                        {
                            try
                            {
                                File.Move(FilePath, NewPath);
                                break;
                            }
                            catch (System.IO.IOException)
                            {
                                PackCompiler.ShowCMessageBox("File is Open", string.Format("A file is open in another program." +
                                    " Please close it then continue.\n\n{0}", FilePath), null, "Continue");
                            }
                        }   
                        return NewPath;
                    }
                    else
                    {
                        return null;
                    }
                    
                }
            }
        }

        private string ArchiveDirectory(string DirectoryPath, string ToSubDirectory = "")
        {
            string FolderName = Path.GetFileName(DirectoryPath);
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
            Directory.CreateDirectory(TargetPath);
            foreach (string path in Directory.GetFiles(SourcePath))
            {
                File.Copy(path, Path.Combine(TargetPath, Path.GetFileName(path)));
                break;
            }
        }

        private void CopyFile(string SourcePath, string TargetPath)
        {
            Directory.CreateDirectory(Directory.GetParent(TargetPath).FullName);
            if (!string.IsNullOrWhiteSpace(SourcePath))
            {
                File.Copy(SourcePath, TargetPath);
            }
        }
    }
}
