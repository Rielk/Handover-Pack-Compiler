﻿using ExtensionMethods;
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
            throw new NotImplementedException();
        }

        public class Folder
        {
            public List<File> Files = new List<File>();
            public string Name { get; set; } = "";
            public Folder()
            {

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
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is PackStructure objAsPS))
            {
                if (!(obj is string objAsS)) { return false; }
                else return Equals(objAsS);
            }
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
            if (!(obj is PackStructure objAsPS))
            {
                if (!(obj is string objAsS)) { return 1; }
                else return CompareTo(objAsS);
            }
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