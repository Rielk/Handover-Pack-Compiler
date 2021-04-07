
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Operation = new System.Windows.Forms.TabControl();
            this.Compile = new System.Windows.Forms.TabPage();
            this.Files = new System.Windows.Forms.TabPage();
            this.Module = new System.Windows.Forms.TabPage();
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
            this.Inverter = new System.Windows.Forms.TabPage();
            this.InverterDropBox = new System.Windows.Forms.ComboBox();
            this.EditInverterButton = new System.Windows.Forms.Button();
            this.DeleteInverterButton = new System.Windows.Forms.Button();
            this.AddInverterButton = new System.Windows.Forms.Button();
            this.InverterGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasheetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solarEdgeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.Operation.SuspendLayout();
            this.Module.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InverterDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridView)).BeginInit();
            this.Inverter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InverterGridView)).BeginInit();
            this.Settings.SuspendLayout();
            this.SEWarrantyGroup.SuspendLayout();
            this.MPWarrantyGroup.SuspendLayout();
            this.ProgDataGroup.SuspendLayout();
            this.CommSiteGroup.SuspendLayout();
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
            this.Module.Controls.Add(this.ModuleDropBox);
            this.Module.Controls.Add(this.EditModuleButton);
            this.Module.Controls.Add(this.DeleteModuleButton);
            this.Module.Controls.Add(this.AddModuleButton);
            this.Module.Controls.Add(this.ModuleGridView);
            this.Module.Location = new System.Drawing.Point(4, 22);
            this.Module.Name = "Module";
            this.Module.Padding = new System.Windows.Forms.Padding(3);
            this.Module.Size = new System.Drawing.Size(540, 423);
            this.Module.TabIndex = 1;
            this.Module.Text = "Module";
            this.Module.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModuleGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ModuleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModuleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Warranty});
            this.ModuleGridView.DataSource = this.ModuleDataSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModuleGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ModuleGridView.EnableHeadersVisualStyles = false;
            this.ModuleGridView.Location = new System.Drawing.Point(6, 127);
            this.ModuleGridView.MultiSelect = false;
            this.ModuleGridView.Name = "ModuleGridView";
            this.ModuleGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModuleGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // Inverter
            // 
            this.Inverter.Controls.Add(this.InverterDropBox);
            this.Inverter.Controls.Add(this.EditInverterButton);
            this.Inverter.Controls.Add(this.DeleteInverterButton);
            this.Inverter.Controls.Add(this.AddInverterButton);
            this.Inverter.Controls.Add(this.InverterGridView);
            this.Inverter.Location = new System.Drawing.Point(4, 22);
            this.Inverter.Name = "Inverter";
            this.Inverter.Size = new System.Drawing.Size(540, 423);
            this.Inverter.TabIndex = 2;
            this.Inverter.Text = "Inverter";
            this.Inverter.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverterGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InverterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InverterGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.datasheetDataGridViewTextBoxColumn,
            this.solarEdgeDataGridViewCheckBoxColumn});
            this.InverterGridView.DataSource = this.InverterDataSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InverterGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.InverterGridView.EnableHeadersVisualStyles = false;
            this.InverterGridView.Location = new System.Drawing.Point(6, 127);
            this.InverterGridView.MultiSelect = false;
            this.InverterGridView.Name = "InverterGridView";
            this.InverterGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverterGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // PackCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.Operation);
            this.Name = "PackCompiler";
            this.Text = "Mypower Handover Pack Compiler";
            this.Operation.ResumeLayout(false);
            this.Module.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InverterDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridView)).EndInit();
            this.Inverter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InverterGridView)).EndInit();
            this.Settings.ResumeLayout(false);
            this.SEWarrantyGroup.ResumeLayout(false);
            this.SEWarrantyGroup.PerformLayout();
            this.MPWarrantyGroup.ResumeLayout(false);
            this.MPWarrantyGroup.PerformLayout();
            this.ProgDataGroup.ResumeLayout(false);
            this.ProgDataGroup.PerformLayout();
            this.CommSiteGroup.ResumeLayout(false);
            this.CommSiteGroup.PerformLayout();
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
    }
}

