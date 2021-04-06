using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Handover_Pack_Compiler
{
    public partial class PackCompiler : Form
    {

        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        private readonly FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
        private readonly List<InverterData> InverterList = new List<InverterData>();

        public PackCompiler()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ProgramDataPath == "")
            {
                Properties.Settings.Default.ProgramDataPath = Application.UserAppDataPath;
            }
            LoadFilePaths();

            InverterList.Add(new InverterData());
            InverterDataSource.DataSource = InverterList;
        }
        private void CommSiteButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CommSitePath == "")
            {
                Properties.Settings.Default.CommSitePath = Properties.Settings.Default.ProgramDataPath;
            }
            folder_dialog.SelectedPath = Properties.Settings.Default.CommSitePath;
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CommSitePath = folder_dialog.SelectedPath;
                Properties.Settings.Default.Save();
                CommSiteBox.Text = Properties.Settings.Default.CommSitePath;
            }
        }
        private void MPWarrantyButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (Properties.Settings.Default.MPWarrantyPath != "")
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.MPWarrantyPath;
            }
            else if (Properties.Settings.Default.CommSitePath != "")
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.CommSitePath;
            }
            else
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.ProgramDataPath;
            }

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MPWarrantyPath = file_dialog.FileName;
                Properties.Settings.Default.Save();
                MPWarrantyBox.Text = Properties.Settings.Default.MPWarrantyPath;
            }
        }
        private void SEWarrantButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (Properties.Settings.Default.SEWarrantyPath != "")
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.SEWarrantyPath;
            }
            else if (Properties.Settings.Default.CommSitePath != "")
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.CommSitePath;
            }
            else
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.ProgramDataPath;
            }

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.SEWarrantyPath = file_dialog.FileName;
                Properties.Settings.Default.Save();
                SEWarrantyBox.Text = Properties.Settings.Default.SEWarrantyPath;
            }
        }
        private void ProgDataButton_Click(object sender, EventArgs e)
        {
            folder_dialog.SelectedPath = Properties.Settings.Default.ProgramDataPath;
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ProgramDataPath = folder_dialog.SelectedPath;
                Properties.Settings.Default.Save();
                ProgDataBox.Text = Properties.Settings.Default.ProgramDataPath;
            }
        }
        private void LoadFilePaths()
        {
            ProgDataBox.Text = Properties.Settings.Default.ProgramDataPath;
            CommSiteBox.Text = Properties.Settings.Default.CommSitePath;
            MPWarrantyBox.Text = Properties.Settings.Default.MPWarrantyPath;
            SEWarrantyBox.Text = Properties.Settings.Default.SEWarrantyPath;
        }

        //XML Example
        //private void SaveFilePaths()
        //{
        //    string filepaths = Path.Combine(Properties.Settings.Default.ProgramDataPath, "FilePaths.xml");
        //    XmlTextWriter textWriter = new XmlTextWriter(filepaths, null)
        //    {
        //        Formatting = Formatting.Indented
        //    };
        //    //Start XML
        //    textWriter.WriteStartDocument();
        //    textWriter.WriteStartElement("root");

        //    //Communication Site Path
        //    textWriter.WriteComment("The path of the company data, contains the 'Technical Area' and 'Enquiries & Orders Area' folders.");
        //    if (CommSitePath != "")
        //    {
        //        textWriter.WriteElementString("CommSite", CommSitePath);
        //    }

        //    //Mypower Warranty Path
        //    textWriter.WriteComment("The path of the Mypower Warranty");
        //    if (MPWarrantyPath != "")
        //    {
        //        textWriter.WriteElementString("MPWarranty", MPWarrantyPath);
        //    }

        //    //Solar Edge Warranty Path
        //    textWriter.WriteComment("The path of the Solar Edge Warranty");
        //    if (SEWarrantyPath != "")
        //    {
        //        textWriter.WriteElementString("SEWarranty", SEWarrantyPath);
        //    }

        //    //Finish XML
        //    textWriter.WriteEndElement();
        //    textWriter.WriteEndDocument();
        //    textWriter.Close();
        //}

        //private void FindFilePaths()
        //{
        //    string filepaths = Path.Combine(Properties.Settings.Default.ProgramDataPath, "FilePaths.xml");
        //    if (File.Exists(filepaths))
        //    {
        //        XmlTextReader textReader = new XmlTextReader(filepaths);
        //        while (textReader.Read())
        //        {
        //            if (textReader.LocalName == "CommSite" & textReader.NodeType == XmlNodeType.Element)
        //            {
        //                textReader.Read();
        //                CommSitePath = textReader.Value;
        //                CommSiteBox.Text = CommSitePath;
        //            }
        //            else if (textReader.LocalName == "MPWarranty" & textReader.NodeType == XmlNodeType.Element)
        //            {
        //                textReader.Read();
        //                MPWarrantyPath = textReader.Value;
        //                MPWarrantyBox.Text = MPWarrantyPath;
        //            }
        //            else if (textReader.LocalName == "SEWarranty" & textReader.NodeType == XmlNodeType.Element)
        //            {
        //                textReader.Read();
        //                SEWarrantyPath = textReader.Value;
        //                SEWarrantyBox.Text = SEWarrantyPath;
        //            }
        //        }
        //        textReader.Close();
        //    }
        //}
        private void AddInverterButton_Click(object sender, EventArgs e)
        {
            InverterValuesForm IVForm = new InverterValuesForm();
            IVForm.ShowDialog();
            InverterData data = new InverterData
            {
                Name = IVForm.NameVal,
                Datasheet = IVForm.DatasheetVal,
                SolarEdge = IVForm.SolarEdgeVal
            };
            if (InverterList.Contains(data))
            {
                //Ask if user wants to replace existing?
                InverterList.Remove(data);
                InverterList.Add(data);
            }
            else
            {
                InverterList.Add(data);
            }
            InverterList.Sort();
            InverterDataSource.ResetBindings(false);
        }

        private void DeleteInverterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InverterGridView.SelectedRows)
            {
                InverterList.Remove((InverterData)row.DataBoundItem);
            }
            InverterList.Sort();
            InverterDataSource.ResetBindings(false);
        }

        private void EditInverterButton_Click(object sender, EventArgs e)
        {
            InverterData IData = (InverterData)InverterGridView.SelectedRows[0].DataBoundItem; 
            InverterValuesForm IVForm = new InverterValuesForm(IData.Name, IData.Datasheet, IData.SolarEdge);
            if (IVForm.ShowDialog() == DialogResult.OK)
            {
                InverterList.Remove(IData);
                IData.Name = IVForm.NameVal;
                IData.Datasheet = IVForm.DatasheetVal;
                IData.SolarEdge = IVForm.SolarEdgeVal;
                InverterList.Add(IData);
                InverterList.Sort();
                InverterDataSource.ResetBindings(false);
            }
        }
    }
}
