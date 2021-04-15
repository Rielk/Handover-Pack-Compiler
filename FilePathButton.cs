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
        public Func<string> InitialPathFunction = DefaultPathFunction;
        public string Filter = "All files (*.*)|*.*";
        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        public FilePathButton()
        {
            InitializeComponent();
            Text = "";
            Value = "";
        }
        private static string DefaultPathFunction()
        {
            return Properties.Settings.Default.CommSitePath;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Value updates")]
        public event EventHandler ValueUpdate;
        private void Button_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = Filter;
            file_dialog.FilterIndex = 0;
            file_dialog.InitialDirectory = InitialPathFunction();
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                Value = file_dialog.FileName;
                ValueUpdate?.Invoke(this, e);
            }
        }
    }
}
