
namespace Handover_Pack_Compiler
{
    partial class InverterSelector
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
            this.DropBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DropBox
            // 
            this.DropBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropBox.FormattingEnabled = true;
            this.DropBox.Location = new System.Drawing.Point(26, 0);
            this.DropBox.Name = "DropBox";
            this.DropBox.Size = new System.Drawing.Size(372, 21);
            this.DropBox.TabIndex = 0;
            this.DropBox.DropDown += new System.EventHandler(this.DropBox_DropDown);
            this.DropBox.SelectedIndexChanged += new System.EventHandler(this.DropBox_SelectedIndexChanged);
            // 
            // SerialNumberBox
            // 
            this.SerialNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialNumberBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SerialNumberBox.Location = new System.Drawing.Point(404, 0);
            this.SerialNumberBox.Name = "SerialNumberBox";
            this.SerialNumberBox.Size = new System.Drawing.Size(213, 20);
            this.SerialNumberBox.TabIndex = 1;
            this.SerialNumberBox.Text = "Serial Number...";
            this.SerialNumberBox.Enter += new System.EventHandler(this.SerialNumberBox_Enter);
            this.SerialNumberBox.Leave += new System.EventHandler(this.SerialNumberBox_Leave);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(0, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(21, 21);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "X";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InverterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SerialNumberBox);
            this.Controls.Add(this.DropBox);
            this.MaximumSize = new System.Drawing.Size(5000, 21);
            this.MinimumSize = new System.Drawing.Size(0, 21);
            this.Name = "InverterSelector";
            this.Size = new System.Drawing.Size(617, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DropBox;
        private System.Windows.Forms.TextBox SerialNumberBox;
        private System.Windows.Forms.Button RemoveButton;
    }
}
