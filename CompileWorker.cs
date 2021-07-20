using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                throw new NotImplementedException();
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
                                foreach (ModuleData MD in ToAdd)
                                {
                                    string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    string path = MD.Warranty;
                                    File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name));
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
                                foreach (ModuleData MD in ToAdd)
                                {
                                    string Name = string.Format("{0}.{1}  {2}", i, j, file.Name);
                                    string path = MD.Datasheet;
                                    File.Copy(path, Path.Combine(PackPaths.CustomerFolderNumberN(11), folder.Name, Name));
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
    }
}
