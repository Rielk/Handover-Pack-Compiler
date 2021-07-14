
namespace Handover_Pack_Compiler
{
    partial class SummaryInformation
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
            this.PredictedOutputBox = new System.Windows.Forms.NumericUpDown();
            this.SystemSizeBox = new System.Windows.Forms.NumericUpDown();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PredictesUnitsLabel = new System.Windows.Forms.Label();
            this.SizeUnitsLabel = new System.Windows.Forms.Label();
            this.PredictedOutputLabel = new System.Windows.Forms.Label();
            this.SystemSizeLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictedOutputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemSizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.PredictedOutputBox);
            this.GroupBox.Controls.Add(this.SystemSizeBox);
            this.GroupBox.Controls.Add(this.ConfirmButton);
            this.GroupBox.Controls.Add(this.PredictesUnitsLabel);
            this.GroupBox.Controls.Add(this.SizeUnitsLabel);
            this.GroupBox.Controls.Add(this.PredictedOutputLabel);
            this.GroupBox.Controls.Add(this.SystemSizeLabel);
            this.GroupBox.Controls.Add(this.DatePicker);
            this.GroupBox.Controls.Add(this.DateLabel);
            this.GroupBox.Controls.Add(this.AddressLabel);
            this.GroupBox.Controls.Add(this.AddressBox);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(530, 123);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Summary Information";
            // 
            // PredictedOutputBox
            // 
            this.PredictedOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictedOutputBox.Location = new System.Drawing.Point(418, 45);
            this.PredictedOutputBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PredictedOutputBox.Name = "PredictedOutputBox";
            this.PredictedOutputBox.Size = new System.Drawing.Size(74, 20);
            this.PredictedOutputBox.TabIndex = 12;
            this.PredictedOutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PredictedOutputBox.ValueChanged += new System.EventHandler(this.PredictedOutputBox_ValueChanged);
            // 
            // SystemSizeBox
            // 
            this.SystemSizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemSizeBox.DecimalPlaces = 2;
            this.SystemSizeBox.Location = new System.Drawing.Point(395, 19);
            this.SystemSizeBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SystemSizeBox.Name = "SystemSizeBox";
            this.SystemSizeBox.Size = new System.Drawing.Size(97, 20);
            this.SystemSizeBox.TabIndex = 11;
            this.SystemSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SystemSizeBox.ValueChanged += new System.EventHandler(this.SystemSizeBox_ValueChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Location = new System.Drawing.Point(468, 97);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(56, 20);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PredictesUnitsLabel
            // 
            this.PredictesUnitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictesUnitsLabel.AutoSize = true;
            this.PredictesUnitsLabel.Location = new System.Drawing.Point(494, 48);
            this.PredictesUnitsLabel.Name = "PredictesUnitsLabel";
            this.PredictesUnitsLabel.Size = new System.Drawing.Size(30, 13);
            this.PredictesUnitsLabel.TabIndex = 9;
            this.PredictesUnitsLabel.Text = "kWh";
            // 
            // SizeUnitsLabel
            // 
            this.SizeUnitsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeUnitsLabel.AutoSize = true;
            this.SizeUnitsLabel.Location = new System.Drawing.Point(494, 22);
            this.SizeUnitsLabel.Name = "SizeUnitsLabel";
            this.SizeUnitsLabel.Size = new System.Drawing.Size(30, 13);
            this.SizeUnitsLabel.TabIndex = 8;
            this.SizeUnitsLabel.Text = "kWp";
            // 
            // PredictedOutputLabel
            // 
            this.PredictedOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PredictedOutputLabel.AutoSize = true;
            this.PredictedOutputLabel.Location = new System.Drawing.Point(330, 48);
            this.PredictedOutputLabel.Name = "PredictedOutputLabel";
            this.PredictedOutputLabel.Size = new System.Drawing.Size(90, 13);
            this.PredictedOutputLabel.TabIndex = 7;
            this.PredictedOutputLabel.Text = "Predicted Output:";
            // 
            // SystemSizeLabel
            // 
            this.SystemSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemSizeLabel.AutoSize = true;
            this.SystemSizeLabel.Location = new System.Drawing.Point(330, 22);
            this.SystemSizeLabel.Name = "SystemSizeLabel";
            this.SystemSizeLabel.Size = new System.Drawing.Size(67, 13);
            this.SystemSizeLabel.TabIndex = 4;
            this.SystemSizeLabel.Text = "System Size:";
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.Location = new System.Drawing.Point(396, 71);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(119, 20);
            this.DatePicker.TabIndex = 3;
            this.DatePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(330, 74);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(63, 13);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Install Date:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 22);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressBox
            // 
            this.AddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBox.Location = new System.Drawing.Point(54, 19);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(274, 98);
            this.AddressBox.TabIndex = 0;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // SummaryInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox);
            this.Name = "SummaryInformation";
            this.Size = new System.Drawing.Size(530, 123);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictedOutputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemSizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label SystemSizeLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label PredictesUnitsLabel;
        private System.Windows.Forms.Label SizeUnitsLabel;
        private System.Windows.Forms.Label PredictedOutputLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.NumericUpDown SystemSizeBox;
        private System.Windows.Forms.NumericUpDown PredictedOutputBox;
    }
}
