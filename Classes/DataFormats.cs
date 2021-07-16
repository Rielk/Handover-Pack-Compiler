using ExtensionMethods;
using Handover_Pack_Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

public abstract class Data : NameCompare
{
    public override string ToString()
    {
        return Name?.ToString() ?? "Please Select...";
    }
    public Data() { }

    public Data(Data other)
    {
        Name = other.Name;
    }
}

public class InverterData : Data
{
    public CommSitePath DPath = new CommSitePath(null);
    [XmlIgnore]
    public string Datasheet {
        get { return DPath.FullPath; }
        set { DPath.FullPath = value; }
    }
    public bool SolarEdge { get; set; } = false;
    public string SerialNumber = null;
    public InverterData() { }
    public InverterData(InverterData other) : base(other)
    {
        DPath = new CommSitePath(null);
        Datasheet = other.Datasheet;
        SolarEdge = other.SolarEdge;
        SerialNumber = other.SerialNumber;
    }
}

public class ModuleData : Data
{
    public CommSitePath DPath = new CommSitePath(null);
    public CommSitePath WPath = new CommSitePath(null);
    [XmlIgnore]
    public string Datasheet
    {
        get { return DPath.FullPath; }
        set { DPath.FullPath = value; }
    }
    [XmlIgnore]
    public string Warranty
    {
        get { return WPath.FullPath; }
        set { WPath.FullPath = value; }
    }
    public int? Quantity = null;
    public ModuleData() { }
    public ModuleData(ModuleData other) : base(other)
    {
        DPath = new CommSitePath(null);
        WPath = new CommSitePath(null);
        Datasheet = other.Datasheet;
        Warranty = other.Warranty;
        Quantity = other.Quantity;
    }
}

public class OptimiserData : Data
{
    public CommSitePath DPath = new CommSitePath(null);
    [XmlIgnore]
    public string Datasheet
    {
        get { return DPath.FullPath; }
        set { DPath.FullPath = value; }
    }
    public OptimiserData() { }
    public OptimiserData(OptimiserData other): base(other)
    {
        DPath = new CommSitePath(null);
        Datasheet = other.Datasheet;
    }
}
