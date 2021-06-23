﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handover_Pack_Compiler
{
    public class PackPaths
    {
        public readonly string CustomerNumber = "0000";
        public readonly CommSitePath CustomerFolder = new CommSitePath(null);
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
        public PackPaths(string cn)
        {
            CustomerNumber = cn;
            List<string> results = Utilities.FileStarting(CustomerNumber, EnquiriesAndOrders);
            if (results.Count > 1)
            {
                throw new NotImplementedException("Could be refering to many different customers.");
            }
            else if (results.Count == 0)
            {
                CustomerFolder.FullPath = null;
            }
            else
            {
                CustomerFolder.FullPath = results[0];
            }
        }
        public PackPaths(int cn) : this(cn.ToString("D4"))
        {
        }
        public string IDCustomerName { get { return new DirectoryInfo(CustomerFolder.FullPath).Name; } }
        public string CustomerName { get { string IDCN = IDCustomerName; return IDCN.Remove(0, IDCN.IndexOf(" ") + 1); } }
    }
}
