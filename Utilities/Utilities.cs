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
        public static void WriteToFile<T>(List<T> CompareList, string FileName, bool RemoveNull) where T : NameCompare, new()
        {
            string filepath = Path.Combine(Properties.Settings.Default.ProgramDataPath, FileName);
            XmlSerializer XMLserializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter filestream = new StreamWriter(filepath))
            {
                if (RemoveNull)
                {
                    IEnumerable<T> CompareEnumerable = CompareList;
                    XMLserializer.Serialize(filestream, CompareEnumerable.Where(d => d.Name != null).ToList());
                }
                else
                {
                    XMLserializer.Serialize(filestream, CompareList);
                }
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
            return ReturnList;
        }
        public static List<string> FolderStarting(string Start, string InPath)
        {
            DirectoryInfo SearchDirectory = new DirectoryInfo(InPath);
            List<string> Files = (from f in SearchDirectory.GetDirectories("*") where f.Name.StartsWith(Start) select f.FullName).ToList();
            return Files;
        }
        public static string OpenFolderNumber(int Folder, string InPath)
        {
            string Search = Folder.ToString() + ". ";
            List<string> results = FolderStarting(Search, InPath);
            if (results.Count > 1)
            {
                throw new NotImplementedException("Could be refering to many different folders.");
            }
            else if (results.Count == 0)
            {
                return null;
            }
            else
            {
                return results[0];
            }
        }
    }
}
