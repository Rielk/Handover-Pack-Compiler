﻿using ExtensionMethods;
using Handover_Pack_Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

    public abstract void CopyBase(Data Copy);
    public abstract bool ClearFalsePaths();

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

    public override void CopyBase(Data Copy)
    {
        if (Copy is InverterData other)
        {
            Datasheet = other.Datasheet;
            SolarEdge = other.SolarEdge;
        }
    }

    public override bool ClearFalsePaths()
    {
        bool ret = false;

        if (string.IsNullOrWhiteSpace(Datasheet))
        {
            ret = true;
        }
        else if (!File.Exists(Datasheet))
        {
            Datasheet = null;
            ret = true;
        }
        
        return ret;
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

    public override void CopyBase(Data Copy)
    {
        if (Copy is ModuleData other)
        {
            Datasheet = other.Datasheet;
            Warranty = other.Warranty;
        }
    }

    public override bool ClearFalsePaths()
    {
        bool ret = false;

        if (string.IsNullOrWhiteSpace(Datasheet))
        {
            ret = true;
        }
        else if (!File.Exists(Datasheet))
        {
            Datasheet = null;
            ret = true;
        }

        if (string.IsNullOrWhiteSpace(Warranty))
        {
            ret = true;
        }
        else if (!File.Exists(Warranty))
        {
            Datasheet = null;
            ret = true;
        }

        return ret;
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

    public override void CopyBase(Data Copy)
    {
        if (Copy is OptimiserData other)
        {
            Datasheet = other.Datasheet;
        }
    }

    public override bool ClearFalsePaths()
    {
        bool ret = false;

        if (string.IsNullOrWhiteSpace(Datasheet))
        {
            ret = true;
        }
        else if (!File.Exists(Datasheet))
        {
            Datasheet = null;
            ret = true;
        }

        return ret;
    }
}
