
namespace Handover_Pack_Compiler
{
    partial class InverterValuesForm
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
            this.SolarEdgeGroup = new System.Windows.Forms.GroupBox();
            this.SolarEdgeBox = new System.Windows.Forms.CheckBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.DatasheetGroup.SuspendLayout();
            this.NameGroup.SuspendLayout();
            this.SolarEdgeGroup.SuspendLayout();
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
            this.DatasheetGroup.TabIndex = 14;
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
            // 
            // DatasheetButton
            // 
            this.DatasheetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatasheetButton.Location = new System.Drawing.Point(431, 19);
            this.DatasheetButton.Name = "DatasheetButton";
            this.DatasheetButton.Size = new System.Drawing.Size(26, 20);
            this.DatasheetButton.TabIndex = 4;
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
            this.NameGroup.Size = new System.Drawing.Size(382, 46);
            this.NameGroup.TabIndex = 15;
            this.NameGroup.TabStop = false;
            this.NameGroup.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(5, 19);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(371, 20);
            this.NameBox.TabIndex = 0;
            // 
            // SolarEdgeGroup
            // 
            this.SolarEdgeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SolarEdgeGroup.Controls.Add(this.SolarEdgeBox);
            this.SolarEdgeGroup.Location = new System.Drawing.Point(400, 12);
            this.SolarEdgeGroup.Name = "SolarEdgeGroup";
            this.SolarEdgeGroup.Size = new System.Drawing.Size(75, 46);
            this.SolarEdgeGroup.TabIndex = 16;
            this.SolarEdgeGroup.TabStop = false;
            this.SolarEdgeGroup.Text = "SolarEdge";
            // 
            // SolarEdgeBox
            // 
            this.SolarEdgeBox.AutoSize = true;
            this.SolarEdgeBox.Location = new System.Drawing.Point(30, 21);
            this.SolarEdgeBox.Name = "SolarEdgeBox";
            this.SolarEdgeBox.Size = new System.Drawing.Size(15, 14);
            this.SolarEdgeBox.TabIndex = 0;
            this.SolarEdgeBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(12, 116);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(114, 20);
            this.ConfirmButton.TabIndex = 17;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton2
            // 
            this.CancelButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton2.Location = new System.Drawing.Point(361, 116);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(114, 20);
            this.CancelButton2.TabIndex = 18;
            this.CancelButton2.Text = "Cancel";
            this.CancelButton2.UseVisualStyleBackColor = true;
            // 
            // InverterValuesForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton2;
            this.ClientSize = new System.Drawing.Size(487, 143);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SolarEdgeGroup);
            this.Controls.Add(this.NameGroup);
            this.Controls.Add(this.DatasheetGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InverterValuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inverter Properties";
            this.DatasheetGroup.ResumeLayout(false);
            this.DatasheetGroup.PerformLayout();
            this.NameGroup.ResumeLayout(false);
            this.NameGroup.PerformLayout();
            this.SolarEdgeGroup.ResumeLayout(false);
            this.SolarEdgeGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DatasheetGroup;
        private System.Windows.Forms.TextBox DatasheetBox;
        private System.Windows.Forms.Button DatasheetButton;
        private System.Windows.Forms.GroupBox NameGroup;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.GroupBox SolarEdgeGroup;
        private System.Windows.Forms.CheckBox SolarEdgeBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton2;
    }
}