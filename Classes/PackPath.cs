using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handover_Pack_Compiler
{
    public static class PackPaths
    {
        public static string CustomerNumber = "0000";
        public static CommSitePath CSCustFold = new CommSitePath(null);
        public static string CommunicationSite
        {
            get
            {
                bool clear = false;
                while (!clear)
                {
                    string commSitePath = Properties.Settings.Default.CommSitePath;
                    bool check1 = commSitePath == ""; //If it's blank
                    bool check2 = !Directory.Exists(commSitePath); //If is doesn't exist
                    bool check3 = !Directory.Exists(Path.Combine(commSitePath, "Enquiries & Orders Area"));//If it doesn't contain
                    bool check4 = !Directory.Exists(Path.Combine(commSitePath, "Technical Area"));         //the correct folders
                    string message = null;
                    bool ask = false;
                    if (check1 | check2)
                    {
                        ask = true;
                        message = "The Communication site path hasn't been set. It may have been moved or changed. Please set it now.";
                    }
                    else if (check3 | check4)
                    {
                        ask = true;
                        message = "The Communication site path doesn't contain the required folders. The folder should contain the" +
                            " folders named: 'Enquiries & Orders Area' and 'Technical Area'";
                    }
                    else
                    {
                        clear = true;
                    }
                    if (ask)
                    {
                        CommSiteRequest csr = new CommSiteRequest(message);
                        if (csr.ShowDialog() == DialogResult.Cancel)
                        {
                            clear = true;
                            Application.Exit();
                        }
                    }
                }
                return Properties.Settings.Default.CommSitePath;
            }
        }
        public static string EnquiriesAndOrders { get { return Path.Combine(CommunicationSite, "Enquiries & Orders Area"); } }
        public static string TechnicalArea { get { return Path.Combine(CommunicationSite, "Technical Area"); } }
        public static string CustomerFolder { get { return CSCustFold.FullPath; } set { CSCustFold.FullPath = value; } }
        public static string TempZip { get { return Path.Combine(CustomerFolderNumberN(11), IDCustomerName + " Handover Pack"); } }
        public static bool SetCustomerNumber(string cn)
        {
            List<string> results = Utilities.FolderStarting(cn, EnquiriesAndOrders);
            if (results.Count > 1)
            {
                throw new NotImplementedException("Could be refering to many different customers.");
            }
            else if (results.Count == 0)
            {
                return false;
            }
            else
            {
                CustomerNumber = cn;
                CustomerFolder = results[0];
                return true;
            }
        }
        public static void SetCustomerNumber(int cn)
        {
            SetCustomerNumber(cn.ToString("D4"));
        }
        public static string IDCustomerName { get { return new DirectoryInfo(CustomerFolder).Name; } }
        public static string CustomerName { get { string IDCN = IDCustomerName; return IDCN.Remove(0, IDCN.IndexOf(" ") + 1); } }
        public static string Archive { get { return Path.Combine(CustomerFolderNumberN(11), "Archive"); } }
        public static string CustomerFolderNumberN(int Folder)
        {
            return Utilities.OpenFolderNumber(Folder, CustomerFolder);
        }
    }
}
