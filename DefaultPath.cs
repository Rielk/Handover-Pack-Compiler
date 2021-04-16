using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handover_Pack_Compiler
{
    static class DefaultPath
    {
        public static string Default()
        {
            return Properties.Settings.Default.CommSitePath;
        }
        public static string ProgData()
        {
            return Properties.Settings.Default.ProgramDataPath;
        }
        public static string CommSite()
        {
            if (Properties.Settings.Default.CommSitePath == "")
            {
                Properties.Settings.Default.CommSitePath = Properties.Settings.Default.ProgramDataPath;
            }
            return Properties.Settings.Default.CommSitePath;
        }
        public static string MPWarranty()
        {
            if (Properties.Settings.Default.MPWarrantyPath != "")
            {
                return Path.GetDirectoryName(Properties.Settings.Default.MPWarrantyPath);
            }
            else if (Properties.Settings.Default.CommSitePath != "")
            {
                return Properties.Settings.Default.CommSitePath;
            }
            else
            {
                return Properties.Settings.Default.ProgramDataPath;
            }
        }
        public static string SEWarrant()
        {
            if (Properties.Settings.Default.SEWarrantyPath != "")
            {
                return Path.GetDirectoryName(Properties.Settings.Default.SEWarrantyPath);
            }
            else if (Properties.Settings.Default.CommSitePath != "")
            {
                return Properties.Settings.Default.CommSitePath;
            }
            else
            {
                return Properties.Settings.Default.ProgramDataPath;
            }
        }
    }
}
