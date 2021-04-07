
namespace Handover_Pack_Compiler
{
    partial class ModuleValuesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatasheetGroup = new System.Windows.Forms.GroupBox();
            this.DatasheetBox = new System.Windows.Forms.TextBox();
            this.DatasheetButton = new System.Windows.Forms.Button();
            this.NameGroup = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.WarrantyGroup = new System.Windows.Forms.GroupBox();
            this.WarrantyBox = new System.Windows.Forms.TextBox();
            this.WarrantyButton = new System.Windows.Forms.Button();
            this.DatasheetGroup.SuspendLayout();
            this.NameGroup.SuspendLayout();
            this.WarrantyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatasheetGroup
            // 
            this.DatasheetGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatasheetGroup.Controls.Add(this.DatasheetBox);
            this.DatasheetGroup.Controls.Add(this.DatasheetButton);
            this.DatasheetGroup.Location = new System.Drawing.Point(12, 64);
            this.DatasheetGroup.Name = "DatasheetGroup";
            this.DatasheetGroup.Size = new System.Drawing.Size(463, 46);
            this.DatasheetGroup.TabIndex = 19;
            this.DatasheetGroup.TabStop = false;
            this.DatasheetGroup.Text = "Datasheet Path";
            // 
            // DatasheetBox
            // 
            this.DatasheetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatasheetBox.Location = new System.Drawing.Point(5, 19);
            this.DatasheetBox.Name = "DatasheetBox";
            this.DatasheetBox.ReadOnly = true;
            this.DatasheetBox.Size = new System.Drawing.Size(420, 20);
            this.DatasheetBox.TabIndex = 0;
            this.DatasheetBox.TabStop = false;
            // 
            // DatasheetButton
            // 
            this.DatasheetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatasheetButton.Location = new System.Drawing.Point(431, 19);
            this.DatasheetButton.Name = "DatasheetButton";
            this.DatasheetButton.Size = new System.Drawing.Size(26, 20);
            this.DatasheetButton.TabIndex = 4;
            this.DatasheetButton.TabStop = false;
            this.DatasheetButton.Text = "...";
            this.DatasheetButton.UseVisualStyleBackColor = true;
            this.DatasheetButton.Click += new System.EventHandler(this.DatasheetButton_Click);
            // 
            // NameGroup
            // 
            this.NameGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameGroup.Controls.Add(this.NameBox);
            this.NameGroup.Location = new System.Drawing.Point(12, 12);
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.Size = new System.Drawing.Size(463, 46);
            this.NameGroup.TabIndex = 20;
            this.NameGroup.TabStop = false;
            this.NameGroup.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(5, 19);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(452, 20);
            this.NameBox.TabIndex = 0;
            // 
            // CancelButton2
            // 
            this.CancelButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton2.Location = new System.Drawing.Point(361, 168);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(114, 20);
            this.CancelButton2.TabIndex = 23;
            this.CancelButton2.Text = "Cancel";
            this.CancelButton2.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(12, 168);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(114, 20);
            this.ConfirmButton.TabIndex = 22;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // WarrantyGroup
            // 
            this.WarrantyGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarrantyGroup.Controls.Add(this.WarrantyBox);
            this.WarrantyGroup.Controls.Add(this.WarrantyButton);
            this.WarrantyGroup.Location = new System.Drawing.Point(12, 116);
            this.WarrantyGroup.Name = "WarrantyGroup";
            this.WarrantyGroup.Size = new System.Drawing.Size(463, 46);
            this.WarrantyGroup.TabIndex = 24;
            this.WarrantyGroup.TabStop = false;
            this.WarrantyGroup.Text = "Warranty Path";
            // 
            // WarrantyBox
            // 
            this.WarrantyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarrantyBox.Location = new System.Drawing.Point(5, 19);
            this.WarrantyBox.Name = "WarrantyBox";
            this.WarrantyBox.ReadOnly = true;
            this.WarrantyBox.Size = new System.Drawing.Size(420, 20);
            this.WarrantyBox.TabIndex = 0;
            this.WarrantyBox.TabStop = false;
            // 
            // WarrantyButton
            // 
            this.WarrantyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WarrantyButton.Location = new System.Drawing.Point(431, 19);
            this.WarrantyButton.Name = "WarrantyButton";
            this.WarrantyButton.Size = new System.Drawing.Size(26, 20);
            this.WarrantyButton.TabIndex = 4;
            this.WarrantyButton.TabStop = false;
            this.WarrantyButton.Text = "...";
            this.WarrantyButton.UseVisualStyleBackColor = true;
            this.WarrantyButton.Click += new System.EventHandler(this.WarrantyButton_Click);
            // 
            // ModuleValuesForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton2;
            this.ClientSize = new System.Drawing.Size(487, 195);
            this.Controls.Add(this.WarrantyGroup);
            this.Controls.Add(this.DatasheetGroup);
            this.Controls.Add(this.NameGroup);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.ConfirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuleValuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Module Properties";
            this.DatasheetGroup.ResumeLayout(false);
            this.DatasheetGroup.PerformLayout();
            this.NameGroup.ResumeLayout(false);
            this.NameGroup.PerformLayout();
            this.WarrantyGroup.ResumeLayout(false);
            this.WarrantyGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatasheetGroup;
        private System.Windows.Forms.TextBox DatasheetBox;
        private System.Windows.Forms.Button DatasheetButton;
        private System.Windows.Forms.GroupBox NameGroup;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button CancelButton2;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.GroupBox WarrantyGroup;
        private System.Windows.Forms.TextBox WarrantyBox;
        private System.Windows.Forms.Button WarrantyButton;
    }
}