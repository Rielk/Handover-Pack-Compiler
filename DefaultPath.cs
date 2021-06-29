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
        private static string LoopToExisting(string value)
        {
            string ret = value;
            while (!Directory.Exists(ret))
            {
                ret = Directory.GetParent(ret).FullName;
            }
            return ret;
        }
        public static string Default(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Properties.Settings.Default.CommSitePath;
            }
            else
            {
                return LoopToExisting(value);
            }
        }
        public static string ProgData(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Properties.Settings.Default.ProgramDataPath;
            }
            else
            {
                return LoopToExisting(value);
            }
        }
        public static string CommSite(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                if (Properties.Settings.Default.CommSitePath == "")
                {
                    Properties.Settings.Default.CommSitePath = Properties.Settings.Default.ProgramDataPath;
                }
                return Properties.Settings.Default.CommSitePath;
            }
            else
            {
                return LoopToExisting(value);
            }
        }
        public static string CustomerFile(string value, int? DefaultFolder)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                if (DefaultFolder != null)
                {
                    try
                    {
                        return PackPaths.CustomerFolderNumberN((int)DefaultFolder);
                    }
                    catch
                    {
                        return PackPaths.CustomerFolder.FullPath;
                    }
                }
                else
                {
                    return PackPaths.CustomerFolder.FullPath;
                }
            }
            else
            {
                return LoopToExisting(value);
            }
        }
    }
}
