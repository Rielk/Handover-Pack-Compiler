using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Data : IEquatable<InverterData>, IComparable<InverterData>, IComparable
{
    public string Name { get; set; } = null;
    public override string ToString()
    {
        return Name.ToString();
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (!(obj is InverterData objAsPart)) return false;
        else return Equals(objAsPart);
    }
    public bool Equals(InverterData other)
    {
        if (other == null) return false;
        return (this.Name.Equals(other.Name));
    }
    public override int GetHashCode()
    {
        int ret = 0;
        foreach (char c in Name)
        {
            ret += c;
        }
        return ret;
    }
    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        if (!(obj is InverterData objAsPart)) return 1;
        else return CompareTo(objAsPart);
    }
    public int CompareTo(InverterData ComparePart)
    {
        string x = Name;
        string y = ComparePart.Name;
        for (int pos = 0; pos < x.Length && pos < y.Length; pos++)
        {
            //If the values are the same, then conitnue down string.
            if (x[pos] == y[pos])
            {
                continue;
            }
            //As long as both characters aren't digits, compare normally.
            if (!(char.IsDigit(x[pos]) && char.IsDigit(y[pos])))
            {
                return x[pos].CompareTo(y[pos]);
            }

            //If both characters are digits, then compare the next numbers as one.
            //Find the full number from the foolowing digits
            int numx = 0;
            for (int temp_pos = pos; temp_pos < x.Length && char.IsDigit(x[temp_pos]); temp_pos++)
            {
                numx *= 10; numx += (int)Char.GetNumericValue(x[temp_pos]);
            }
            int numy = 0;
            for (int temp_pos = pos; temp_pos < y.Length && char.IsDigit(y[temp_pos]); temp_pos++)
            {
                numy *= 10; numy += (int)Char.GetNumericValue(y[temp_pos]);
            }
            //If the numbers are the same, move the pos to end of number, then continue down string.
            if (numx == numy)
            {
                pos += (int)Math.Floor((double)numx / 10);
                continue;
            }
            //Otherwise, compare them
            else
            {
                return numx.CompareTo(numy);
            }
        }
        return x.Length - y.Length;
    }
}

public class  InverterData : Data
{
    public string Datasheet { get; set; } = null;
    public bool SolarEdge { get; set; } = false;
}
