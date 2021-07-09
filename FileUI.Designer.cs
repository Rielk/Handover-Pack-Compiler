
namespace Handover_Pack_Compiler
{
    partial class FileUI
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.RequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.DescriptionLabel);
            this.GroupBox.Controls.Add(this.ConfirmButton);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(456, 40);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "     GroupBox";
            this.GroupBox.Resize += new System.EventHandler(this.GroupBox_Resize);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(394, 14);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(56, 20);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // RequiredCheckBox
            // 
            this.RequiredCheckBox.AutoSize = true;
            this.RequiredCheckBox.Checked = true;
            this.RequiredCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RequiredCheckBox.Location = new System.Drawing.Point(6, 0);
            this.RequiredCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.RequiredCheckBox.Name = "RequiredCheckBox";
            this.RequiredCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RequiredCheckBox.TabIndex = 0;
            this.RequiredCheckBox.UseVisualStyleBackColor = true;
            this.RequiredCheckBox.CheckedChanged += new System.EventHandler(this.RequiredCheckBox_CheckedChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 14);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description";
            // 
            // FileUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.RequiredCheckBox);
            this.Controls.Add(this.GroupBox);
            this.MaximumSize = new System.Drawing.Size(456, 40);
            this.MinimumSize = new System.Drawing.Size(456, 40);
            this.Name = "FileUI";
            this.Size = new System.Drawing.Size(456, 40);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.CheckBox RequiredCheckBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}
