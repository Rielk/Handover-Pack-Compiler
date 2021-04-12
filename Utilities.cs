using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Handover_Pack_Compiler
{
    static class Utilities
    {
        public static void WriteToFile(List<ModuleData> ModuleList, string FileName)
        {
            IEnumerable<Data> DataList = ModuleList;
            WriteToFile(DataList, FileName);
        }
        public static void WriteToFile(List<InverterData> InverterList, string FileName)
        {
            IEnumerable<Data> DataList = InverterList;
            WriteToFile(DataList, FileName);
        }
        public static void WriteToFile(IEnumerable<Data> DataList, string FileName)
        {
            string filepath = Path.Combine(Properties.Settings.Default.ProgramDataPath, FileName);
            XmlTextWriter XmlWriter = new XmlTextWriter(filepath, null)
            {
                Formatting = Formatting.Indented
            };
            XmlWriter.WriteStartDocument();
            XmlWriter.WriteStartElement("ComponentData");
            foreach (Data DataVal in DataList)
            {
                DataVal.WriteXml(XmlWriter);
            }
            XmlWriter.WriteEndElement();
            XmlWriter.WriteEndDocument();
            XmlWriter.Close();
        }
        public static List<Data> ReadFromFile(string FileName)
        {
            string filepath = Path.Combine(Properties.Settings.Default.ProgramDataPath, FileName);
            List<Data> DataList = new List<Data>();
            if (File.Exists(filepath))
            {
                XmlTextReader XmlReader = new XmlTextReader(filepath);
                while (XmlReader.Read())
                {
                    if (XmlReader.LocalName == "Module" & XmlReader.NodeType == XmlNodeType.Element)
                    {
                        ModuleData DataVal = new ModuleData();
                    }
                }                
            }
            return DataList;
        }
    }
}
