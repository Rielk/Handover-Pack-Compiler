
namespace Handover_Pack_Compiler
{
    partial class FileDropSelector
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.DropBox = new System.Windows.Forms.ComboBox();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.Location = new System.Drawing.Point(412, 0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(41, 20);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // DropBox
            // 
            this.DropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropBox.FormattingEnabled = true;
            this.DropBox.Location = new System.Drawing.Point(3, 0);
            this.DropBox.Name = "DropBox";
            this.DropBox.Size = new System.Drawing.Size(371, 21);
            this.DropBox.TabIndex = 9;
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(380, 0);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(26, 20);
            this.Button.TabIndex = 10;
            this.Button.Text = "...";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // FileDropSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button);
            this.Controls.Add(this.DropBox);
            this.Controls.Add(this.OpenButton);
            this.MaximumSize = new System.Drawing.Size(5000, 21);
            this.MinimumSize = new System.Drawing.Size(0, 21);
            this.Name = "FileDropSelector";
            this.Size = new System.Drawing.Size(453, 21);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.ComboBox DropBox;
        private System.Windows.Forms.Button Button;
    }
}
