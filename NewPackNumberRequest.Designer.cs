
namespace Handover_Pack_Compiler
{
    partial class NewPackNumberRequest
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
            this.CancelButt = new System.Windows.Forms.Button();
            this.OkButt = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageText = new System.Windows.Forms.Label();
            this.ButtonPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButt
            // 
            this.CancelButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButt.Location = new System.Drawing.Point(194, 6);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(75, 23);
            this.CancelButt.TabIndex = 3;
            this.CancelButt.Text = "Cancel";
            this.CancelButt.UseVisualStyleBackColor = true;
            // 
            // OkButt
            // 
            this.OkButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButt.Location = new System.Drawing.Point(113, 6);
            this.OkButt.Name = "OkButt";
            this.OkButt.Size = new System.Drawing.Size(75, 23);
            this.OkButt.TabIndex = 4;
            this.OkButt.Text = "Ok";
            this.OkButt.UseVisualStyleBackColor = true;
            // 
            // NumberBox
            // 
            this.NumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberBox.Location = new System.Drawing.Point(12, 7);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(95, 20);
            this.NumberBox.TabIndex = 5;
            this.NumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.CancelButt);
            this.ButtonPanel.Controls.Add(this.NumberBox);
            this.ButtonPanel.Controls.Add(this.OkButt);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 57);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(281, 41);
            this.ButtonPanel.TabIndex = 7;
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessagePanel.Controls.Add(this.MessageText);
            this.MessagePanel.Location = new System.Drawing.Point(0, 0);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(281, 57);
            this.MessagePanel.TabIndex = 6;
            // 
            // MessageText
            // 
            this.MessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Padding = new System.Windows.Forms.Padding(12);
            this.MessageText.Size = new System.Drawing.Size(281, 57);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Loading Structure as a new Pack.\r\nPlease enter the Customer Number Below.\r\n";
            this.MessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewPackNumberRequest
            // 
            this.AcceptButton = this.OkButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButt;
            this.ClientSize = new System.Drawing.Size(281, 98);
            this.ControlBox = false;
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.ButtonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPackNumberRequest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pack Number";
            this.TopMost = true;
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelButt;
        private System.Windows.Forms.Button OkButt;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.Label MessageText;
    }
}