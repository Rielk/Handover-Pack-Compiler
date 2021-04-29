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
        public static void WriteToFile<T>(List<T> CompareList, string FileName) where T : NameCompare, new()
        {
            string filepath = Path.Combine(Properties.Settings.Default.ProgramDataPath, FileName);
            IEnumerable<T> CompareEnumerable = CompareList;
            XmlSerializer XMLserializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter filestream = new StreamWriter(filepath))
            {
                XMLserializer.Serialize(filestream, CompareEnumerable.Where(d => d.Name != null).ToList());
            }
        }
        public static List<T> ReadFromFile<T>(string FileName) where T : NameCompare, new()
        {
            List<T> ReturnList;
            string filepath = Path.Combine(Properties.Settings.Default.ProgramDataPath, FileName);
            if (File.Exists(filepath))
            {
                XmlSerializer XMLserializer = new XmlSerializer(typeof(List<T>));
                TextReader filestream = new StreamReader(filepath);
                ReturnList = (List<T>)XMLserializer.Deserialize(filestream);
                filestream.Close();
            }
            else
            {
                ReturnList = new List<T>();
            }
            ReturnList.Add(new T());
            return ReturnList;
        }
    }
}
