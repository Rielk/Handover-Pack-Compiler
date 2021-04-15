
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OperationTabs = new System.Windows.Forms.TabControl();
            this.CompileTab = new System.Windows.Forms.TabPage();
            this.FilesTab = new System.Windows.Forms.TabPage();
            this.ModuleTab = new System.Windows.Forms.TabPage();
            this.ModuleDropBox = new System.Windows.Forms.ComboBox();
            this.InverterDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModuleDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditModuleButton = new System.Windows.Forms.Button();
            this.DeleteModuleButton = new System.Windows.Forms.Button();
            this.AddModuleButton = new System.Windows.Forms.Button();
            this.ModuleGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InverterTab = new System.Windows.Forms.TabPage();
            this.InverterDropBox = new System.Windows.Forms.ComboBox();
            this.EditInverterButton = new System.Windows.Forms.Button();
            this.DeleteInverterButton = new System.Windows.Forms.Button();
            this.AddInverterButton = new System.Windows.Forms.Button();
            this.InverterGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasheetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solarEdgeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SEWarrantyButton = new Handover_Pack_Compiler.FilePathButton();
            this.MPWarrantyButton = new Handover_Pack_Compiler.FilePathButton();
            this.CommSiteButton = new Handover_Pack_Compiler.FolderPathButton();
            this.ProgDataButton = new Handover_Pack_Compiler.FolderPathButton();
            this.PackTab = new System.Windows.Forms.TabPage();
            this.OperationTabs.SuspendLayout();
            this.ModuleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InverterDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridView)).BeginInit();
            this.InverterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InverterGridView)).BeginInit();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationTabs
            // 
            this.OperationTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OperationTabs.Controls.Add(this.CompileTab);
            this.OperationTabs.Controls.Add(this.FilesTab);
            this.OperationTabs.Controls.Add(this.ModuleTab);
            this.OperationTabs.Controls.Add(this.InverterTab);
            this.OperationTabs.Controls.Add(this.SettingsTab);
            this.OperationTabs.Controls.Add(this.PackTab);
            this.OperationTabs.Location = new System.Drawing.Point(0, 0);
            this.OperationTabs.Name = "OperationTabs";
            this.OperationTabs.SelectedIndex = 0;
            this.OperationTabs.Size = new System.Drawing.Size(548, 449);
            this.OperationTabs.TabIndex = 0;
            // 
            // CompileTab
            // 
            this.CompileTab.Location = new System.Drawing.Point(4, 22);
            this.CompileTab.Name = "CompileTab";
            this.CompileTab.Padding = new System.Windows.Forms.Padding(3);
            this.CompileTab.Size = new System.Drawing.Size(540, 423);
            this.CompileTab.TabIndex = 0;
            this.CompileTab.Text = "Compile";
            this.CompileTab.UseVisualStyleBackColor = true;
            // 
            // FilesTab
            // 
            this.FilesTab.Location = new System.Drawing.Point(4, 22);
            this.FilesTab.Name = "FilesTab";
            this.FilesTab.Size = new System.Drawing.Size(540, 423);
            this.FilesTab.TabIndex = 4;
            this.FilesTab.Text = "Files";
            this.FilesTab.UseVisualStyleBackColor = true;
            // 
            // ModuleTab
            // 
            this.ModuleTab.Controls.Add(this.ModuleDropBox);
            this.ModuleTab.Controls.Add(this.EditModuleButton);
            this.ModuleTab.Controls.Add(this.DeleteModuleButton);
            this.ModuleTab.Controls.Add(this.AddModuleButton);
            this.ModuleTab.Controls.Add(this.ModuleGridView);
            this.ModuleTab.Location = new System.Drawing.Point(4, 22);
            this.ModuleTab.Name = "ModuleTab";
            this.ModuleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModuleTab.Size = new System.Drawing.Size(540, 423);
            this.ModuleTab.TabIndex = 1;
            this.ModuleTab.Text = "Module";
            this.ModuleTab.UseVisualStyleBackColor = true;
            // 
            // ModuleDropBox
            // 
            this.ModuleDropBox.DataBindings.Add(new System.Windows.Forms.Binding("DisplayMember", this.InverterDataSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Please Select..."));
            this.ModuleDropBox.DataSource = this.ModuleDataSource;
            this.ModuleDropBox.DisplayMember = "Name";
            this.ModuleDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModuleDropBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ModuleDropBox.FormattingEnabled = true;
            this.ModuleDropBox.Location = new System.Drawing.Point(8, 19);
            this.ModuleDropBox.Name = "ModuleDropBox";
            this.ModuleDropBox.Size = new System.Drawing.Size(522, 21);
            this.ModuleDropBox.TabIndex = 13;
            this.ModuleDropBox.ValueMember = "Name";
            // 
            // InverterDataSource
            // 
            this.InverterDataSource.DataSource = typeof(InverterData);
            // 
            // ModuleDataSource
            // 
            this.ModuleDataSource.DataSource = typeof(ModuleData);
            // 
            // EditModuleButton
            // 
            this.EditModuleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditModuleButton.Location = new System.Drawing.Point(212, 396);
            this.EditModuleButton.Name = "EditModuleButton";
            this.EditModuleButton.Size = new System.Drawing.Size(114, 20);
            this.EditModuleButton.TabIndex = 12;
            this.EditModuleButton.Text = "Edit Module";
            this.EditModuleButton.UseVisualStyleBackColor = true;
            this.EditModuleButton.Click += new System.EventHandler(this.EditModuleButton_Click);
            // 
            // DeleteModuleButton
            // 
            this.DeleteModuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteModuleButton.Location = new System.Drawing.Point(417, 396);
            this.DeleteModuleButton.Name = "DeleteModuleButton";
            this.DeleteModuleButton.Size = new System.Drawing.Size(114, 20);
            this.DeleteModuleButton.TabIndex = 11;
            this.DeleteModuleButton.Text = "Delete Module";
            this.DeleteModuleButton.UseVisualStyleBackColor = true;
            this.DeleteModuleButton.Click += new System.EventHandler(this.DeleteModuleButton_Click);
            // 
            // AddModuleButton
            // 
            this.AddModuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddModuleButton.Location = new System.Drawing.Point(8, 396);
            this.AddModuleButton.Name = "AddModuleButton";
            this.AddModuleButton.Size = new System.Drawing.Size(114, 20);
            this.AddModuleButton.TabIndex = 10;
            this.AddModuleButton.Text = "Add Module";
            this.AddModuleButton.UseVisualStyleBackColor = true;
            this.AddModuleButton.Click += new System.EventHandler(this.AddModuleButton_Click);
            // 
            // ModuleGridView
            // 
            this.ModuleGridView.AllowUserToAddRows = false;
            this.ModuleGridView.AllowUserToDeleteRows = false;
            this.ModuleGridView.AllowUserToResizeColumns = false;
            this.ModuleGridView.AllowUserToResizeRows = false;
            this.ModuleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModuleGridView.AutoGenerateColumns = false;
            this.ModuleGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModuleGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ModuleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModuleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Warranty});
            this.ModuleGridView.DataSource = this.ModuleDataSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModuleGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.ModuleGridView.EnableHeadersVisualStyles = false;
            this.ModuleGridView.Location = new System.Drawing.Point(6, 127);
            this.ModuleGridView.MultiSelect = false;
            this.ModuleGridView.Name = "ModuleGridView";
            this.ModuleGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModuleGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ModuleGridView.RowHeadersVisible = false;
            this.ModuleGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ModuleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModuleGridView.Size = new System.Drawing.Size(528, 263);
            this.ModuleGridView.TabIndex = 9;
            this.ModuleGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ModuleGridView_DataBindingComplete);
            this.ModuleGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModuleGridView_RowValidated);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datasheet";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datasheet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Warranty
            // 
            this.Warranty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Warranty.DataPropertyName = "Warranty";
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            this.Warranty.ReadOnly = true;
            // 
            // InverterTab
            // 
            this.InverterTab.Controls.Add(this.InverterDropBox);
            this.InverterTab.Controls.Add(this.EditInverterButton);
            this.InverterTab.Controls.Add(this.DeleteInverterButton);
            this.InverterTab.Controls.Add(this.AddInverterButton);
            this.InverterTab.Controls.Add(this.InverterGridView);
            this.InverterTab.Location = new System.Drawing.Point(4, 22);
            this.InverterTab.Name = "InverterTab";
            this.InverterTab.Size = new System.Drawing.Size(540, 423);
            this.InverterTab.TabIndex = 2;
            this.InverterTab.Text = "Inverter";
            this.InverterTab.UseVisualStyleBackColor = true;
            // 
            // InverterDropBox
            // 
            this.InverterDropBox.DataBindings.Add(new System.Windows.Forms.Binding("DisplayMember", this.InverterDataSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Please Select..."));
            this.InverterDropBox.DataSource = this.InverterDataSource;
            this.InverterDropBox.DisplayMember = "Name";
            this.InverterDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InverterDropBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InverterDropBox.FormattingEnabled = true;
            this.InverterDropBox.Location = new System.Drawing.Point(8, 19);
            this.InverterDropBox.Name = "InverterDropBox";
            this.InverterDropBox.Size = new System.Drawing.Size(522, 21);
            this.InverterDropBox.TabIndex = 8;
            this.InverterDropBox.ValueMember = "Name";
            // 
            // EditInverterButton
            // 
            this.EditInverterButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditInverterButton.Location = new System.Drawing.Point(212, 396);
            this.EditInverterButton.Name = "EditInverterButton";
            this.EditInverterButton.Size = new System.Drawing.Size(114, 20);
            this.EditInverterButton.TabIndex = 7;
            this.EditInverterButton.Text = "Edit Inverter";
            this.EditInverterButton.UseVisualStyleBackColor = true;
            this.EditInverterButton.Click += new System.EventHandler(this.EditInverterButton_Click);
            // 
            // DeleteInverterButton
            // 
            this.DeleteInverterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteInverterButton.Location = new System.Drawing.Point(417, 396);
            this.DeleteInverterButton.Name = "DeleteInverterButton";
            this.DeleteInverterButton.Size = new System.Drawing.Size(114, 20);
            this.DeleteInverterButton.TabIndex = 6;
            this.DeleteInverterButton.Text = "Delete Inverter";
            this.DeleteInverterButton.UseVisualStyleBackColor = true;
            this.DeleteInverterButton.Click += new System.EventHandler(this.DeleteInverterButton_Click);
            // 
            // AddInverterButton
            // 
            this.AddInverterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddInverterButton.Location = new System.Drawing.Point(8, 396);
            this.AddInverterButton.Name = "AddInverterButton";
            this.AddInverterButton.Size = new System.Drawing.Size(114, 20);
            this.AddInverterButton.TabIndex = 5;
            this.AddInverterButton.Text = "Add Inverter";
            this.AddInverterButton.UseVisualStyleBackColor = true;
            this.AddInverterButton.Click += new System.EventHandler(this.AddInverterButton_Click);
            // 
            // InverterGridView
            // 
            this.InverterGridView.AllowUserToAddRows = false;
            this.InverterGridView.AllowUserToDeleteRows = false;
            this.InverterGridView.AllowUserToResizeColumns = false;
            this.InverterGridView.AllowUserToResizeRows = false;
            this.InverterGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InverterGridView.AutoGenerateColumns = false;
            this.InverterGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverterGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.InverterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InverterGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.datasheetDataGridViewTextBoxColumn,
            this.solarEdgeDataGridViewCheckBoxColumn});
            this.InverterGridView.DataSource = this.InverterDataSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InverterGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.InverterGridView.EnableHeadersVisualStyles = false;
            this.InverterGridView.Location = new System.Drawing.Point(6, 127);
            this.InverterGridView.MultiSelect = false;
            this.InverterGridView.Name = "InverterGridView";
            this.InverterGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverterGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.InverterGridView.RowHeadersVisible = false;
            this.InverterGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.InverterGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InverterGridView.Size = new System.Drawing.Size(528, 263);
            this.InverterGridView.TabIndex = 2;
            this.InverterGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.InverterGridView_DataBindingComplete);
            this.InverterGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.InverterGridView_RowValidated);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // datasheetDataGridViewTextBoxColumn
            // 
            this.datasheetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datasheetDataGridViewTextBoxColumn.DataPropertyName = "Datasheet";
            this.datasheetDataGridViewTextBoxColumn.HeaderText = "Datasheet";
            this.datasheetDataGridViewTextBoxColumn.Name = "datasheetDataGridViewTextBoxColumn";
            this.datasheetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solarEdgeDataGridViewCheckBoxColumn
            // 
            this.solarEdgeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.solarEdgeDataGridViewCheckBoxColumn.DataPropertyName = "SolarEdge";
            this.solarEdgeDataGridViewCheckBoxColumn.HeaderText = "SolarEdge";
            this.solarEdgeDataGridViewCheckBoxColumn.Name = "solarEdgeDataGridViewCheckBoxColumn";
            this.solarEdgeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.solarEdgeDataGridViewCheckBoxColumn.Width = 62;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.SEWarrantyButton);
            this.SettingsTab.Controls.Add(this.MPWarrantyButton);
            this.SettingsTab.Controls.Add(this.CommSiteButton);
            this.SettingsTab.Controls.Add(this.ProgDataButton);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(540, 423);
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // SEWarrantyButton
            // 
            this.SEWarrantyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SEWarrantyButton.Location = new System.Drawing.Point(3, 159);
            this.SEWarrantyButton.MaximumSize = new System.Drawing.Size(5000, 46);
            this.SEWarrantyButton.MinimumSize = new System.Drawing.Size(0, 46);
            this.SEWarrantyButton.Name = "SEWarrantyButton";
            this.SEWarrantyButton.Size = new System.Drawing.Size(534, 46);
            this.SEWarrantyButton.TabIndex = 3;
            this.SEWarrantyButton.Text = "SolarEdge Warranty Path";
            this.SEWarrantyButton.Value = "";
            this.SEWarrantyButton.ValueUpdate += new System.EventHandler(this.SEWarrantyButton_ValueUpdate);
            // 
            // MPWarrantyButton
            // 
            this.MPWarrantyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MPWarrantyButton.Location = new System.Drawing.Point(3, 107);
            this.MPWarrantyButton.MaximumSize = new System.Drawing.Size(5000, 46);
            this.MPWarrantyButton.MinimumSize = new System.Drawing.Size(0, 46);
            this.MPWarrantyButton.Name = "MPWarrantyButton";
            this.MPWarrantyButton.Size = new System.Drawing.Size(534, 46);
            this.MPWarrantyButton.TabIndex = 2;
            this.MPWarrantyButton.Text = "Mypower Warranty Path";
            this.MPWarrantyButton.Value = "";
            this.MPWarrantyButton.ValueUpdate += new System.EventHandler(this.MPWarrantyButton_ValueUpdate);
            // 
            // CommSiteButton
            // 
            this.CommSiteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommSiteButton.Location = new System.Drawing.Point(3, 55);
            this.CommSiteButton.MaximumSize = new System.Drawing.Size(5000, 46);
            this.CommSiteButton.MinimumSize = new System.Drawing.Size(0, 46);
            this.CommSiteButton.Name = "CommSiteButton";
            this.CommSiteButton.Size = new System.Drawing.Size(534, 46);
            this.CommSiteButton.TabIndex = 1;
            this.CommSiteButton.Text = "Communication Site Path";
            this.CommSiteButton.Value = "";
            this.CommSiteButton.ValueUpdate += new System.EventHandler(this.CommSiteButton_ValueUpdate);
            // 
            // ProgDataButton
            // 
            this.ProgDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgDataButton.Location = new System.Drawing.Point(3, 3);
            this.ProgDataButton.MaximumSize = new System.Drawing.Size(5000, 46);
            this.ProgDataButton.MinimumSize = new System.Drawing.Size(0, 46);
            this.ProgDataButton.Name = "ProgDataButton";
            this.ProgDataButton.Size = new System.Drawing.Size(534, 46);
            this.ProgDataButton.TabIndex = 0;
            this.ProgDataButton.Text = "Program Data Path";
            this.ProgDataButton.Value = "";
            this.ProgDataButton.ValueUpdate += new System.EventHandler(this.ProgDataButton_ValueUpdate);
            // 
            // PackTab
            // 
            this.PackTab.Location = new System.Drawing.Point(4, 22);
            this.PackTab.Name = "PackTab";
            this.PackTab.Size = new System.Drawing.Size(540, 423);
            this.PackTab.TabIndex = 5;
            this.PackTab.Text = "Pack";
            this.PackTab.UseVisualStyleBackColor = true;
            // 
            // PackCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.OperationTabs);
            this.Name = "PackCompiler";
            this.Text = "Mypower Handover Pack Compiler";
            this.OperationTabs.ResumeLayout(false);
            this.ModuleTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InverterDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridView)).EndInit();
            this.InverterTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InverterGridView)).EndInit();
            this.SettingsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage CompileTab;
        private System.Windows.Forms.TabPage ModuleTab;
        private System.Windows.Forms.TabPage FilesTab;
        private System.Windows.Forms.TabPage InverterTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TabPage PackTab;
        private System.Windows.Forms.TabControl OperationTabs;
        private System.Windows.Forms.DataGridView InverterGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasheetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solarEdgeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource InverterDataSource;
        private System.Windows.Forms.Button AddInverterButton;
        private System.Windows.Forms.Button DeleteInverterButton;
        private System.Windows.Forms.Button EditInverterButton;
        private System.Windows.Forms.ComboBox InverterDropBox;
        private System.Windows.Forms.ComboBox ModuleDropBox;
        private System.Windows.Forms.Button EditModuleButton;
        private System.Windows.Forms.Button DeleteModuleButton;
        private System.Windows.Forms.Button AddModuleButton;
        private System.Windows.Forms.DataGridView ModuleGridView;
        private System.Windows.Forms.BindingSource ModuleDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warranty;
        private FilePathButton SEWarrantyButton;
        private FilePathButton MPWarrantyButton;
        private FolderPathButton CommSiteButton;
        private FolderPathButton ProgDataButton;
    }
}

