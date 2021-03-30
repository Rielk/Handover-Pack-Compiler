
namespace Handover_Pack_Compiler
{
    partial class PackCompiler
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
            this.components = new System.ComponentModel.Container();
            this.Operation = new System.Windows.Forms.TabControl();
            this.Compile = new System.Windows.Forms.TabPage();
            this.Files = new System.Windows.Forms.TabPage();
            this.Module = new System.Windows.Forms.TabPage();
            this.Inverter = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Settings = new System.Windows.Forms.TabPage();
            this.SEWarrantyGroup = new System.Windows.Forms.GroupBox();
            this.SEWarrantyBox = new System.Windows.Forms.TextBox();
            this.SEWarrantButton = new System.Windows.Forms.Button();
            this.MPWarrantyGroup = new System.Windows.Forms.GroupBox();
            this.MPWarrantyBox = new System.Windows.Forms.TextBox();
            this.MPWarrantyButton = new System.Windows.Forms.Button();
            this.ProgDataGroup = new System.Windows.Forms.GroupBox();
            this.ProgDataBox = new System.Windows.Forms.TextBox();
            this.ProgDataButton = new System.Windows.Forms.Button();
            this.CommSiteGroup = new System.Windows.Forms.GroupBox();
            this.CommSiteBox = new System.Windows.Forms.TextBox();
            this.CommSiteButton = new System.Windows.Forms.Button();
            this.Pack = new System.Windows.Forms.TabPage();
            this.inverterDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasheetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solarEdgeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Operation.SuspendLayout();
            this.Inverter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Settings.SuspendLayout();
            this.SEWarrantyGroup.SuspendLayout();
            this.MPWarrantyGroup.SuspendLayout();
            this.ProgDataGroup.SuspendLayout();
            this.CommSiteGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inverterDataSourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Operation
            // 
            this.Operation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Operation.Controls.Add(this.Compile);
            this.Operation.Controls.Add(this.Files);
            this.Operation.Controls.Add(this.Module);
            this.Operation.Controls.Add(this.Inverter);
            this.Operation.Controls.Add(this.Settings);
            this.Operation.Controls.Add(this.Pack);
            this.Operation.Location = new System.Drawing.Point(0, 0);
            this.Operation.Name = "Operation";
            this.Operation.SelectedIndex = 0;
            this.Operation.Size = new System.Drawing.Size(548, 449);
            this.Operation.TabIndex = 0;
            // 
            // Compile
            // 
            this.Compile.Location = new System.Drawing.Point(4, 22);
            this.Compile.Name = "Compile";
            this.Compile.Padding = new System.Windows.Forms.Padding(3);
            this.Compile.Size = new System.Drawing.Size(540, 423);
            this.Compile.TabIndex = 0;
            this.Compile.Text = "Compile";
            this.Compile.UseVisualStyleBackColor = true;
            // 
            // Files
            // 
            this.Files.Location = new System.Drawing.Point(4, 22);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(540, 423);
            this.Files.TabIndex = 4;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(4, 22);
            this.Module.Name = "Module";
            this.Module.Padding = new System.Windows.Forms.Padding(3);
            this.Module.Size = new System.Drawing.Size(540, 423);
            this.Module.TabIndex = 1;
            this.Module.Text = "Module";
            this.Module.UseVisualStyleBackColor = true;
            // 
            // Inverter
            // 
            this.Inverter.Controls.Add(this.dataGridView1);
            this.Inverter.Location = new System.Drawing.Point(4, 22);
            this.Inverter.Name = "Inverter";
            this.Inverter.Size = new System.Drawing.Size(540, 423);
            this.Inverter.TabIndex = 2;
            this.Inverter.Text = "Inverter";
            this.Inverter.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.datasheetDataGridViewTextBoxColumn,
            this.solarEdgeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.inverterDataSourceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 289);
            this.dataGridView1.TabIndex = 2;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.SEWarrantyGroup);
            this.Settings.Controls.Add(this.MPWarrantyGroup);
            this.Settings.Controls.Add(this.ProgDataGroup);
            this.Settings.Controls.Add(this.CommSiteGroup);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(540, 423);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // SEWarrantyGroup
            // 
            this.SEWarrantyGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SEWarrantyGroup.Controls.Add(this.SEWarrantyBox);
            this.SEWarrantyGroup.Controls.Add(this.SEWarrantButton);
            this.SEWarrantyGroup.Location = new System.Drawing.Point(3, 159);
            this.SEWarrantyGroup.Name = "SEWarrantyGroup";
            this.SEWarrantyGroup.Size = new System.Drawing.Size(534, 46);
            this.SEWarrantyGroup.TabIndex = 15;
            this.SEWarrantyGroup.TabStop = false;
            this.SEWarrantyGroup.Text = "SolarEdge Warranty Path";
            // 
            // SEWarrantyBox
            // 
            this.SEWarrantyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SEWarrantyBox.Location = new System.Drawing.Point(6, 19);
            this.SEWarrantyBox.Name = "SEWarrantyBox";
            this.SEWarrantyBox.ReadOnly = true;
            this.SEWarrantyBox.Size = new System.Drawing.Size(490, 20);
            this.SEWarrantyBox.TabIndex = 7;
            // 
            // SEWarrantButton
            // 
            this.SEWarrantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SEWarrantButton.Location = new System.Drawing.Point(502, 19);
            this.SEWarrantButton.Name = "SEWarrantButton";
            this.SEWarrantButton.Size = new System.Drawing.Size(26, 20);
            this.SEWarrantButton.TabIndex = 6;
            this.SEWarrantButton.Text = "...";
            this.SEWarrantButton.UseVisualStyleBackColor = true;
            this.SEWarrantButton.Click += new System.EventHandler(this.SEWarrantButton_Click);
            // 
            // MPWarrantyGroup
            // 
            this.MPWarrantyGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MPWarrantyGroup.Controls.Add(this.MPWarrantyBox);
            this.MPWarrantyGroup.Controls.Add(this.MPWarrantyButton);
            this.MPWarrantyGroup.Location = new System.Drawing.Point(3, 107);
            this.MPWarrantyGroup.Name = "MPWarrantyGroup";
            this.MPWarrantyGroup.Size = new System.Drawing.Size(534, 46);
            this.MPWarrantyGroup.TabIndex = 14;
            this.MPWarrantyGroup.TabStop = false;
            this.MPWarrantyGroup.Text = "Mypower Warranty Path";
            // 
            // MPWarrantyBox
            // 
            this.MPWarrantyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MPWarrantyBox.Location = new System.Drawing.Point(6, 19);
            this.MPWarrantyBox.Name = "MPWarrantyBox";
            this.MPWarrantyBox.ReadOnly = true;
            this.MPWarrantyBox.Size = new System.Drawing.Size(490, 20);
            this.MPWarrantyBox.TabIndex = 7;
            // 
            // MPWarrantyButton
            // 
            this.MPWarrantyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MPWarrantyButton.Location = new System.Drawing.Point(502, 19);
            this.MPWarrantyButton.Name = "MPWarrantyButton";
            this.MPWarrantyButton.Size = new System.Drawing.Size(26, 20);
            this.MPWarrantyButton.TabIndex = 6;
            this.MPWarrantyButton.Text = "...";
            this.MPWarrantyButton.UseVisualStyleBackColor = true;
            this.MPWarrantyButton.Click += new System.EventHandler(this.MPWarrantyButton_Click);
            // 
            // ProgDataGroup
            // 
            this.ProgDataGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgDataGroup.Controls.Add(this.ProgDataBox);
            this.ProgDataGroup.Controls.Add(this.ProgDataButton);
            this.ProgDataGroup.Location = new System.Drawing.Point(3, 3);
            this.ProgDataGroup.Name = "ProgDataGroup";
            this.ProgDataGroup.Size = new System.Drawing.Size(534, 46);
            this.ProgDataGroup.TabIndex = 13;
            this.ProgDataGroup.TabStop = false;
            this.ProgDataGroup.Text = "Program Data Path";
            // 
            // ProgDataBox
            // 
            this.ProgDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgDataBox.Location = new System.Drawing.Point(5, 19);
            this.ProgDataBox.Name = "ProgDataBox";
            this.ProgDataBox.ReadOnly = true;
            this.ProgDataBox.Size = new System.Drawing.Size(491, 20);
            this.ProgDataBox.TabIndex = 0;
            // 
            // ProgDataButton
            // 
            this.ProgDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgDataButton.Location = new System.Drawing.Point(502, 19);
            this.ProgDataButton.Name = "ProgDataButton";
            this.ProgDataButton.Size = new System.Drawing.Size(26, 20);
            this.ProgDataButton.TabIndex = 4;
            this.ProgDataButton.Text = "...";
            this.ProgDataButton.UseVisualStyleBackColor = true;
            this.ProgDataButton.Click += new System.EventHandler(this.ProgDataButton_Click);
            // 
            // CommSiteGroup
            // 
            this.CommSiteGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommSiteGroup.Controls.Add(this.CommSiteBox);
            this.CommSiteGroup.Controls.Add(this.CommSiteButton);
            this.CommSiteGroup.Location = new System.Drawing.Point(3, 55);
            this.CommSiteGroup.Name = "CommSiteGroup";
            this.CommSiteGroup.Size = new System.Drawing.Size(534, 46);
            this.CommSiteGroup.TabIndex = 12;
            this.CommSiteGroup.TabStop = false;
            this.CommSiteGroup.Text = "Communication Site Path";
            // 
            // CommSiteBox
            // 
            this.CommSiteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommSiteBox.Location = new System.Drawing.Point(6, 19);
            this.CommSiteBox.Name = "CommSiteBox";
            this.CommSiteBox.ReadOnly = true;
            this.CommSiteBox.Size = new System.Drawing.Size(490, 20);
            this.CommSiteBox.TabIndex = 7;
            // 
            // CommSiteButton
            // 
            this.CommSiteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommSiteButton.Location = new System.Drawing.Point(502, 19);
            this.CommSiteButton.Name = "CommSiteButton";
            this.CommSiteButton.Size = new System.Drawing.Size(26, 20);
            this.CommSiteButton.TabIndex = 6;
            this.CommSiteButton.Text = "...";
            this.CommSiteButton.UseVisualStyleBackColor = true;
            this.CommSiteButton.Click += new System.EventHandler(this.CommSiteButton_Click);
            // 
            // Pack
            // 
            this.Pack.Location = new System.Drawing.Point(4, 22);
            this.Pack.Name = "Pack";
            this.Pack.Size = new System.Drawing.Size(540, 423);
            this.Pack.TabIndex = 5;
            this.Pack.Text = "Pack";
            this.Pack.UseVisualStyleBackColor = true;
            // 
            // inverterDataSourceBindingSource
            // 
            this.inverterDataSourceBindingSource.DataSource = typeof(InverterDataSource);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // datasheetDataGridViewTextBoxColumn
            // 
            this.datasheetDataGridViewTextBoxColumn.DataPropertyName = "Datasheet";
            this.datasheetDataGridViewTextBoxColumn.HeaderText = "Datasheet";
            this.datasheetDataGridViewTextBoxColumn.Name = "datasheetDataGridViewTextBoxColumn";
            // 
            // solarEdgeDataGridViewCheckBoxColumn
            // 
            this.solarEdgeDataGridViewCheckBoxColumn.DataPropertyName = "SolarEdge";
            this.solarEdgeDataGridViewCheckBoxColumn.HeaderText = "SolarEdge";
            this.solarEdgeDataGridViewCheckBoxColumn.Name = "solarEdgeDataGridViewCheckBoxColumn";
            // 
            // PackCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.Operation);
            this.Name = "PackCompiler";
            this.Text = "Mypower Handover Pack Compiler";
            this.Operation.ResumeLayout(false);
            this.Inverter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Settings.ResumeLayout(false);
            this.SEWarrantyGroup.ResumeLayout(false);
            this.SEWarrantyGroup.PerformLayout();
            this.MPWarrantyGroup.ResumeLayout(false);
            this.MPWarrantyGroup.PerformLayout();
            this.ProgDataGroup.ResumeLayout(false);
            this.ProgDataGroup.PerformLayout();
            this.CommSiteGroup.ResumeLayout(false);
            this.CommSiteGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inverterDataSourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Compile;
        private System.Windows.Forms.TabPage Module;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.TabPage Inverter;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage Pack;
        private System.Windows.Forms.TabControl Operation;
        private System.Windows.Forms.TextBox ProgDataBox;
        private System.Windows.Forms.Button ProgDataButton;
        private System.Windows.Forms.TextBox CommSiteBox;
        private System.Windows.Forms.Button CommSiteButton;
        private System.Windows.Forms.GroupBox CommSiteGroup;
        private System.Windows.Forms.GroupBox ProgDataGroup;
        private System.Windows.Forms.GroupBox MPWarrantyGroup;
        private System.Windows.Forms.TextBox MPWarrantyBox;
        private System.Windows.Forms.Button MPWarrantyButton;
        private System.Windows.Forms.GroupBox SEWarrantyGroup;
        private System.Windows.Forms.TextBox SEWarrantyBox;
        private System.Windows.Forms.Button SEWarrantButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasheetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solarEdgeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource inverterDataSourceBindingSource;
    }
}

