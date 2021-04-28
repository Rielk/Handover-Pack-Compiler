using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Handover_Pack_Compiler
{
    public abstract class NameCompare : IEquatable<NameCompare>, IComparable<NameCompare>, IComparable
    {
        public string Name { get; set; } = null;
        public bool NameIsNull { get { return Name is null; } }
        public bool NameIsNotNull { get { return !(Name is null); } }
        public abstract override string ToString();
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is NameCompare AsBase)) return false;
            else return Equals(AsBase);
        }
        public bool Equals(NameCompare other)
        {
            if (Name == null & other.Name == null) return true;
            else if (Name == null | other.Name == null) return false;
            return Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (!(obj is NameCompare AsBase)) return 1;
            else return CompareTo(AsBase);
        }
        public int CompareTo(NameCompare other)
        {
            if (Name == null)
            {
                if (other.Name == null) { return 0; }
                return -1;
            }
            else if (other.Name == null) { return 1; }
            return Name.NumericCompare(other.Name);
        }
    }
}
