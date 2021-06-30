
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
            this.OpenAllButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.RequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.OpenAllButton);
            this.GroupBox.Controls.Add(this.AddFileButton);
            this.GroupBox.Controls.Add(this.RequiredCheckBox);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(456, 46);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "GroupBox";
            // 
            // OpenAllButton
            // 
            this.OpenAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenAllButton.Location = new System.Drawing.Point(375, 19);
            this.OpenAllButton.Name = "OpenAllButton";
            this.OpenAllButton.Size = new System.Drawing.Size(75, 21);
            this.OpenAllButton.TabIndex = 2;
            this.OpenAllButton.Text = "Open All";
            this.OpenAllButton.UseVisualStyleBackColor = true;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFileButton.Location = new System.Drawing.Point(6, 19);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(75, 21);
            this.AddFileButton.TabIndex = 1;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // RequiredCheckBox
            // 
            this.RequiredCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequiredCheckBox.AutoSize = true;
            this.RequiredCheckBox.Checked = true;
            this.RequiredCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RequiredCheckBox.Location = new System.Drawing.Point(387, 0);
            this.RequiredCheckBox.Name = "RequiredCheckBox";
            this.RequiredCheckBox.Size = new System.Drawing.Size(69, 17);
            this.RequiredCheckBox.TabIndex = 0;
            this.RequiredCheckBox.Text = "Required";
            this.RequiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox);
            this.Name = "FileUI";
            this.Size = new System.Drawing.Size(456, 46);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.CheckBox RequiredCheckBox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button OpenAllButton;
    }
}
