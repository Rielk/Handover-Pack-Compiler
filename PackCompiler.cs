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
        private string CommSitePath = "";
        private string MPWarrantyPath = "";
        private string SEWarrantyPath = "";
        private List<InverterData> InverterList = new List<InverterData>();
        private BindingSource InverterSource = new BindingSource();

        public PackCompiler()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ProgramDataPath == "")
            {
                Properties.Settings.Default.ProgramDataPath = Application.UserAppDataPath;
            }
            ProgDataBox.Text = Properties.Settings.Default.ProgramDataPath;
            FindFilePaths();

            InverterSource.DataSource = InverterList;
            InverterGridView.DataSource = InverterSource;
        }
        private void CommSiteButton_Click(object sender, EventArgs e)
        {
            if (CommSitePath == "")
            {
                CommSitePath = Properties.Settings.Default.ProgramDataPath;
            }
            folder_dialog.SelectedPath = CommSitePath;
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                CommSitePath = folder_dialog.SelectedPath;
                CommSiteBox.Text = CommSitePath;
                SaveFilePaths();
            }
        }
        private void MPWarrantyButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (MPWarrantyPath != "")
            {
                file_dialog.InitialDirectory = MPWarrantyPath;
            }
            else if (CommSitePath != "")
            {
                file_dialog.InitialDirectory = CommSitePath;
            }
            else
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.ProgramDataPath;
            }

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                MPWarrantyPath = file_dialog.FileName;
                MPWarrantyBox.Text = MPWarrantyPath;
                SaveFilePaths();
            }
        }
        private void SEWarrantButton_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            file_dialog.FilterIndex = 0;
            if (SEWarrantyPath != "")
            {
                file_dialog.InitialDirectory = SEWarrantyPath;
            }
            else if (CommSitePath != "")
            {
                file_dialog.InitialDirectory = CommSitePath;
            }
            else
            {
                file_dialog.InitialDirectory = Properties.Settings.Default.ProgramDataPath;
            }

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                SEWarrantyPath = file_dialog.FileName;
                SEWarrantyBox.Text = SEWarrantyPath;
                SaveFilePaths();
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
                FindFilePaths();
            }
        }
        private void SaveFilePaths()
        {
            string filepaths = Path.Combine(Properties.Settings.Default.ProgramDataPath, "FilePaths.xml");
            XmlTextWriter textWriter = new XmlTextWriter(filepaths, null)
            {
                Formatting = Formatting.Indented
            };
            //Start XML
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("root");

            //Communication Site Path
            textWriter.WriteComment("The path of the company data, contains the 'Technical Area' and 'Enquiries & Orders Area' folders.");
            if (CommSitePath != "")
            {
                textWriter.WriteElementString("CommSite", CommSitePath);
            }

            //Mypower Warranty Path
            textWriter.WriteComment("The path of the Mypower Warranty");
            if (MPWarrantyPath != "")
            {
                textWriter.WriteElementString("MPWarranty", MPWarrantyPath);
            }

            //Solar Edge Warranty Path
            textWriter.WriteComment("The path of the Solar Edge Warranty");
            if (SEWarrantyPath != "")
            {
                textWriter.WriteElementString("SEWarranty", SEWarrantyPath);
            }

            //Finish XML
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        private void FindFilePaths()
        {
            string filepaths = Path.Combine(Properties.Settings.Default.ProgramDataPath, "FilePaths.xml");
            if (File.Exists(filepaths))
            {
                XmlTextReader textReader = new XmlTextReader(filepaths);
                while (textReader.Read())
                {
                    if (textReader.LocalName == "CommSite" & textReader.NodeType == XmlNodeType.Element)
                    {
                        textReader.Read();
                        CommSitePath = textReader.Value;
                        CommSiteBox.Text = CommSitePath;
                    }
                    else if (textReader.LocalName == "MPWarranty" & textReader.NodeType == XmlNodeType.Element)
                    {
                        textReader.Read();
                        MPWarrantyPath = textReader.Value;
                        MPWarrantyBox.Text = MPWarrantyPath;
                    }
                    else if (textReader.LocalName == "SEWarranty" & textReader.NodeType == XmlNodeType.Element)
                    {
                        textReader.Read();
                        SEWarrantyPath = textReader.Value;
                        SEWarrantyBox.Text = SEWarrantyPath;
                    }
                }
                textReader.Close();
            }
        }

        private void AddInverterButton_Click(object sender, EventArgs e)
        {
            InverterData data = new InverterData
            {
                Name = "Test" + (InverterList.Count+1).ToString(),
                Datasheet = "This/is/a/path",
                SolarEdge = false
            };
            InverterList.Add(data);
            InverterList.Sort();
            InverterSource.ResetBindings(false);
        }

        private void DeleteInverterButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in InverterGridView.SelectedRows)
            {
                InverterList.Remove(new InverterData() { Name = row.Cells[0].Value.ToString() });
            }
            InverterList.Sort();
            InverterSource.ResetBindings(false);
        }
    }
}
