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
    public partial class FilePathButton : UserControl
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
        private Func<string> InitialPathFunction;
        private string Filter = "All files (*.*)|*.*";
        private OpenFileDialog file_dialog = new OpenFileDialog();
        public FilePathButton()
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
            file_dialog.Filter = Filter;
            file_dialog.FilterIndex = 0;
            file_dialog.InitialDirectory = InitialPathFunction();
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                Value = file_dialog.FileName;
            }
        }
    }
}
