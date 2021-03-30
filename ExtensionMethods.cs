using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static int NumericCompare(this string x, string y)
        {
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

                //If both characters are digits, then compare the next digits as one.
                //Find the full number from the following digits
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
            //If the end of one or both strings is reached, the shorter one is place first.
            return x.Length - y.Length;
            //test
        }
    }
}
