using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Handover_Pack_Compiler
{
    static class Utilities
    {
        public static void WriteToFile(List<ModuleData> ModuleList, string FileName)
        {
            IEnumerable<Data> DataList = ModuleList;
            WriteToFile(DataList.Where(d => d.Name != null).ToList(), FileName);
        }
        public static void WriteToFile(List<InverterData> InverterList, string FileName)
        {
            IEnumerable<Data> DataList = InverterList;
            WriteToFile(DataList.Where(d => d.Name != null).ToList(), FileName);
        }
        public static void WriteToFile(List<Data> DataList, string FileName)
        {
            string filepath = Path.Combine(Properties.Settings.Default.ProgramDataPath, FileName);
            XmlSerializer XMLserializer = new XmlSerializer(typeof(List<Data>));
            using (TextWriter filestream = new StreamWriter(filepath))
            {
                XMLserializer.Serialize(filestream, DataList);
            }
        }
        public static List<InverterData> IReadFromFile(string FileName)
        {
            List<Data> DataList = ReadFromFile(FileName);
            List<InverterData> InverterList = DataList.ConvertAll(x => (InverterData)x);
            InverterList.Add(new InverterData());
            return InverterList;
        }
        public static List<ModuleData> MReadFromFile(string FileName)
        {
            List<Data> DataList = ReadFromFile(FileName);
            List<ModuleData> ModuleList = DataList.ConvertAll(x => (ModuleData)x);
            ModuleList.Add(new ModuleData());
            return ModuleList;
        }
        public static List<Data> ReadFromFile(string FileName)
        {
            List<Data> DataList;
            string filepath = Path.Combine(Properties.Settings.Default.ProgramDataPath, FileName);
            if (File.Exists(filepath))
            {
                XmlSerializer XMLserializer = new XmlSerializer(typeof(List<Data>));
                TextReader filestream = new StreamReader(filepath);
                DataList = (List<Data>)XMLserializer.Deserialize(filestream);
                filestream.Close();
            }
            else
            {
                DataList = new List<Data>();
            }
            return DataList;
        }
    }
}
