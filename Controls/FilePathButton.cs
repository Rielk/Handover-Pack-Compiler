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
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(false)]
        public string Description
        {
            get
            {
                if (DescLabel == null)
                {
                    return null;
                }
                else
                {
                    return DescLabel.Text;
                }
            }
            set
            {
                if (value == null)
                {
                    if (DescLabel != null)
                    {
                        ControlGroup.Controls.Remove(DescLabel);
                        DescLabel = null;
                        this.MaximumSize = new Size(5000, 46);
                        this.MinimumSize = new Size(0, 46);
                    }
                }
                else
                {
                    DescLabel = new Label
                    {
                        Text = value,
                        Padding = new Padding(0, 0, 0, 5),
                        Dock = DockStyle.Bottom,
                        AutoSize = true,
                        MaximumSize = new Size(this.Width-5, 0)
                    };
                    ControlGroup.Controls.Add(DescLabel);
                    FilePathButton_Resize(null, null);
                }
            }
        }
        private Label DescLabel = null;
        public Func<string, string> InitialPathFunction = DefaultPath.Default;
        public string Filter = "All files (*.*)|*.*";
        private readonly OpenFileDialog file_dialog = new OpenFileDialog();
        public FilePathButton()
        {
            InitializeComponent();
            Text = "";
            Value = "";
        }
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when Value updates")]
        public event EventHandler ValueUpdate;

        private void Button_Click(object sender, EventArgs e)
        {
            file_dialog.Filter = Filter;
            file_dialog.FilterIndex = 0;
            file_dialog.InitialDirectory = InitialPathFunction(Value);
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                Value = file_dialog.FileName;
                ValueUpdate?.Invoke(this, e);
            }
        }

        private void FilePathButton_Resize(object sender, EventArgs e)
        {
            if (DescLabel != null)
            {
                DescLabel.MaximumSize = new Size(this.Width-5, 0);
                this.MaximumSize = new Size(5000, 46 + DescLabel.Height);
                this.MinimumSize = new Size(0, 46 + DescLabel.Height);
            }
        }
    }
}
