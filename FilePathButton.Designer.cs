
namespace Handover_Pack_Compiler
{
    partial class FilePathButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.ControlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlGroup
            // 
            this.ControlGroup.Controls.Add(this.TextBox);
            this.ControlGroup.Controls.Add(this.Button);
            this.ControlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlGroup.Location = new System.Drawing.Point(0, 0);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Size = new System.Drawing.Size(534, 46);
            this.ControlGroup.TabIndex = 14;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "Text";
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(5, 19);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(491, 20);
            this.TextBox.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(502, 19);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(26, 20);
            this.Button.TabIndex = 4;
            this.Button.Text = "...";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // FilePathButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlGroup);
            this.MaximumSize = new System.Drawing.Size(5000, 46);
            this.MinimumSize = new System.Drawing.Size(0, 46);
            this.Name = "FilePathButton";
            this.Size = new System.Drawing.Size(534, 46);
            this.Resize += new System.EventHandler(this.FilePathButton_Resize);
            this.ControlGroup.ResumeLayout(false);
            this.ControlGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Button;
    }
}
