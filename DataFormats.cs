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
using System.Xml.Serialization;

[XmlInclude(typeof(InverterData)), XmlInclude(typeof(ModuleData))]
public abstract class Data : NameCompare
{
    public override string ToString()
    {
        return Name?.ToString() ?? "Please Select...";
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
