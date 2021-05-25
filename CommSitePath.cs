using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Handover_Pack_Compiler
{
    public class CommSitePath
    {
        public string Extension = null;
        public bool InCommSite = true;

        [XmlIgnore]
        public string FullPath
        {
            get { return GetFullPath(); }
            set { SetFullPath(value); }
        }

        public CommSitePath() { }

        public CommSitePath(string value)
        {
            FullPath = value;
        }

        public string GetFullPath()
        {
            if (InCommSite)
            { return (Extension == null) ? null : Path.Combine(Properties.Settings.Default.CommSitePath, Extension); }
            else
            { return Extension; }
        }

        public void SetFullPath(string value)
        {
            string parent = value;
            string ext = "";
            while (!string.IsNullOrEmpty(parent))
            {
                if (parent == Properties.Settings.Default.CommSitePath)
                {
                    Extension = ext;
                    InCommSite = true;
                    return;
                }
                ext = Path.Combine(Path.GetFileName(parent), ext);
                parent = Directory.GetParent(parent).FullName;
            }
            Extension = value;
            InCommSite = false;

        }
    }
}
