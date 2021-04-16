using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handover_Pack_Compiler
{
    class PackStructure
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Folder> Folders = new List<Folder>();
        public PackStructure()
        {

        }
        public class Folder
        {
            public List<File> Files = new List<File>();
            public string Name { get; set; }
            public Folder()
            {

            }
            public class File
            {
                public string Name { get; set; }
                public string Description { get; set; }
                public bool Optional { get; set; }
                public Func<bool> Condition { get; set; }
                public File()
                {

                }
            }
        }
    }
}
