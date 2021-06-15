
namespace Handover_Pack_Compiler
{
    partial class CommSiteRequest
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
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.CommSiteButton = new Handover_Pack_Compiler.FolderPathButton();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageText = new System.Windows.Forms.Label();
            this.ButtonPanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.CommSiteButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 87);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(281, 46);
            this.ButtonPanel.TabIndex = 7;
            // 
            // CommSiteButton
            // 
            this.CommSiteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommSiteButton.Location = new System.Drawing.Point(0, 0);
            this.CommSiteButton.MaximumSize = new System.Drawing.Size(5000, 46);
            this.CommSiteButton.MinimumSize = new System.Drawing.Size(0, 46);
            this.CommSiteButton.Name = "CommSiteButton";
            this.CommSiteButton.Size = new System.Drawing.Size(281, 46);
            this.CommSiteButton.TabIndex = 0;
            this.CommSiteButton.Text = "Communication Site Path";
            this.CommSiteButton.Value = "";
            this.CommSiteButton.ValueUpdate += new System.EventHandler(this.CommSiteButton_ValueUpdate);
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
            this.MessagePanel.Size = new System.Drawing.Size(281, 81);
            this.MessagePanel.TabIndex = 6;
            // 
            // MessageText
            // 
            this.MessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Name = "MessageText";
            this.MessageText.Padding = new System.Windows.Forms.Padding(12);
            this.MessageText.Size = new System.Drawing.Size(281, 81);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "\"The Communication site path doesn\'t contain the required folders. The folder sho" +
    "uld contain the folders named: \'Enquiries & Orders Area\' and \'Technical Area\'\"";
            this.MessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommSiteRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 133);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.ButtonPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommSiteRequest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Communication Site Path";
            this.TopMost = true;
            this.ButtonPanel.ResumeLayout(false);
            this.MessagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.Label MessageText;
        private FolderPathButton CommSiteButton;
    }
}