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
        public void AddFolder(string FolderName)
        {
            AddFolder(new Folder() { Name = FolderName });
        }
        public void AddFolder(Folder NewFolder)
        {
            Folders.Add(NewFolder);
        }

        public class Folder
        {
            public string Name { get; set; } = "";
            public List<File> Files = new List<File>();
            public Folder()
            {

            }
            public Folder(Folder other)
            {
                Name = other.Name;
                Files = new List<File>();
                foreach (File file in other.Files)
                {
                    Files.Add(new File(file));
                }
            }

            public class File
            {
                public string Name { get; set; } = "";
                public string Description { get; set; } = "";
                public bool Optional { get; set; } = false;
                public string Condition { get; set; }
                public File()
                {

                }
                public File(File other)
                {
                    Name = other.Name;
                    Description = other.Description;
                    Optional = other.Optional;
                    Condition = other.Condition;
                }
            }
        }
    }
}
