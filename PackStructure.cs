using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handover_Pack_Compiler
{
    class PackStructure : IEquatable<PackStructure>, IComparable<PackStructure>, IComparable
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<Folder> Folders = new List<Folder>();
        public PackStructure()
        {

        }
        public PackStructure(PackStructure other)
        {
            Name = other.Name + "- Copy";
            Description = other.Description;
            Folders = new List<Folder>();
            foreach (Folder folder in other.Folders)
            {
                Folders.Add(new Folder(folder));
            }
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
                public Func<bool> Condition { get; set; }
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is PackStructure objAsPS)) { return false; }
            else return Equals(objAsPS);
        }
        public bool Equals(PackStructure other)
        {
            return Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (!(obj is PackStructure objAsPS)) { return 1; }
            else return CompareTo(objAsPS);
        }
        public int CompareTo(PackStructure other)
        {
            if (Name == "Default")
            {
                if (other.Name == "Default") { return 0; }
                return -1;
            }
            else if (other.Name == "Default") { return 1; }
            return Name.NumericCompare(other.Name);
        }
    }
}
