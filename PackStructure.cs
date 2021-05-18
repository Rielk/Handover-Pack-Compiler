using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddFile(Folder.File FileName, string folder)
        {
            Folder AddToFolder = Folders.Find(x => x.Name == folder);
            if (AddToFolder != null)
            {
                AddToFolder.AddFile(FileName);
            }
        }
    }
    public class Folder
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<File> Files = new List<File>();
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
            public string Name { get; set; } = "";
            public string Description { get; set; } = "";
            public int? DefaultFolder { get; set; } = null;
            public string SearchTerm { get; set; } = null;
            public bool AlwaysRequired { get; set; } = true;
            public string FileType { get; set; } = "Gen";
            public bool AllowMultiple { get; set; } = false;
            public string ConstantFile { get; set; } = "";
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
                ConstantFile = other.ConstantFile;
            }
        }
    }
}
