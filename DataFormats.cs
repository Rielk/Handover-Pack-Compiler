using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ExtensionMethods;

[XmlInclude(typeof(InverterData)), XmlInclude(typeof(ModuleData))]
public abstract class Data : IEquatable<Data>, IComparable<Data>, IComparable
{
    public string Name { get; set; } = null;
    public override string ToString()
    {
        return Name?.ToString() ?? "Please Select...";
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (!(obj is Data objAsPart)) return false;
        else return Equals(objAsPart);
    }
    public bool Equals(Data other)
    {
        if (other == null) return false;
        if (Name == null & other.Name == null) return true;
        else if (Name == null | other.Name == null) return false;
        return this.Name.Equals(other.Name);
    }
    public override int GetHashCode()
    {
        return Name?.GetHashCode() ?? 0;
    }
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        if (!(obj is Data objAsPart)) return 1;
        else return CompareTo(objAsPart);
    }
    public int CompareTo(Data CompareData)
    {
        if (Name == null)
        {
            if (CompareData.Name == null) { return 0; }
            return -1;
        }
        else if (CompareData.Name == null) { return 1; }
        return Name.NumericCompare(CompareData.Name);
    }
}

public class InverterData : Data
{
    public string Datasheet { get; set; } = null;
    public bool SolarEdge { get; set; } = false;
}

public class ModuleData : Data
{
    public string Datasheet { get; set; } = null;
    public string Warranty { get; set; } = null;
}
