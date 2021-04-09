using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handover_Pack_Compiler
{
    static class Utilities
    {
        public static void WritetoXML(List<ModuleData> ModuleList)
        {
            IEnumerable<Data> DataList = ModuleList;
            WritetoXML(DataList);
        }
        public static void WritetoXML(List<InverterData> InverterList)
        {
            IEnumerable<Data> DataList = InverterList;
            WritetoXML(DataList);
        }
        public static void WritetoXML(IEnumerable<Data> DataList)
        {

        }
    }
}
