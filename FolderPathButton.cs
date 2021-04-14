using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Handover_Pack_Compiler
{
    public partial class FolderPathButton : UserControl
    {
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return ControlGroup.Text; }
            set { ControlGroup.Text = value; }
        }
        public string Value
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }
        public Func<string> InitialPathFunction;
        private readonly FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
        public FolderPathButton()
        {
            InitializeComponent();
            InitialPathFunction = DefaultPathFunction;
            Text = "";
            Value = "";
        }
        private string DefaultPathFunction()
        {
            return Properties.Settings.Default.CommSitePath;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            folder_dialog.SelectedPath = InitialPathFunction();
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                Value = folder_dialog.SelectedPath;
            }
        }
    }
}
