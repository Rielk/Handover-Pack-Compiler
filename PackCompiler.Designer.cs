
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OperationTabs = new System.Windows.Forms.TabControl();
            this.StructureTab = new System.Windows.Forms.TabPage();
            this.PackTabSplit = new System.Windows.Forms.SplitContainer();
            this.DeletePackStructureButton = new System.Windows.Forms.Button();
            this.DuplicatePackStructureButton = new System.Windows.Forms.Button();
            this.PackStructureGridView = new System.Windows.Forms.DataGridView();
            this.PackStructureGridViewNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackStructureGridViewDescriptionTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackStructureSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddPackStructureButton = new System.Windows.Forms.Button();
            this.PackStructureDropBox = new System.Windows.Forms.ComboBox();
            this.PackTree = new Handover_Pack_Compiler.PackStructureTree();
            this.PacksTab = new System.Windows.Forms.TabPage();
            this.FilesTab = new System.Windows.Forms.TabPage();
            this.CompileTab = new System.Windows.Forms.TabPage();
            this.ModuleTab = new System.Windows.Forms.TabPage();
            this.ModuleDropBox = new System.Windows.Forms.ComboBox();
            this.InverterDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModuleDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditModuleButton = new System.Windows.Forms.Button();
            this.DeleteModuleButton = new System.Windows.Forms.Button();
            this.AddModuleButton = new System.Windows.Forms.Button();
            this.ModuleGridView = new System.Windows.Forms.DataGridView();
            this.ModuleGridViewNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleGridViewDatasheetTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleGridViewWarrantyTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InverterTab = new System.Windows.Forms.TabPage();
            this.InverterDropBox = new System.Windows.Forms.ComboBox();
            this.EditInverterButton = new System.Windows.Forms.Button();
            this.DeleteInverterButton = new System.Windows.Forms.Button();
            this.AddInverterButton = new System.Windows.Forms.Button();
            this.InverterGridView = new System.Windows.Forms.DataGridView();
            this.InverterGridViewNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InverterGridViewDatasheetTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InverterGridViewSolarEdgeCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.CommSiteButton = new Handover_Pack_Compiler.FolderPathButton();
            this.ProgDataButton = new Handover_Pack_Compiler.FolderPathButton();
            this.OperationTabs.SuspendLayout();
            this.StructureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PackTabSplit)).BeginInit();
            this.PackTabSplit.Panel1.SuspendLayout();
            this.PackTabSplit.Panel2.SuspendLayout();
            this.PackTabSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PackStructureGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackStructureSource)).BeginInit();
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
            this.OperationTabs.Controls.Add(this.StructureTab);
            this.OperationTabs.Controls.Add(this.PacksTab);
            this.OperationTabs.Controls.Add(this.FilesTab);
            this.OperationTabs.Controls.Add(this.CompileTab);
            this.OperationTabs.Controls.Add(this.ModuleTab);
            this.OperationTabs.Controls.Add(this.InverterTab);
            this.OperationTabs.Controls.Add(this.SettingsTab);
            this.OperationTabs.Location = new System.Drawing.Point(0, 0);
            this.OperationTabs.Name = "OperationTabs";
            this.OperationTabs.SelectedIndex = 0;
            this.OperationTabs.Size = new System.Drawing.Size(685, 535);
            this.OperationTabs.TabIndex = 0;
            // 
            // StructureTab
            // 
            this.StructureTab.Controls.Add(this.PackTabSplit);
            this.StructureTab.Location = new System.Drawing.Point(4, 22);
            this.StructureTab.Name = "StructureTab";
            this.StructureTab.Size = new System.Drawing.Size(677, 509);
            this.StructureTab.TabIndex = 5;
            this.StructureTab.Text = "Structure";
            this.StructureTab.UseVisualStyleBackColor = true;
            // 
            // PackTabSplit
            // 
            this.PackTabSplit.BackColor = System.Drawing.Color.Transparent;
            this.PackTabSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PackTabSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackTabSplit.Location = new System.Drawing.Point(0, 0);
            this.PackTabSplit.Name = "PackTabSplit";
            this.PackTabSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PackTabSplit.Panel1
            // 
            this.PackTabSplit.Panel1.Controls.Add(this.DeletePackStructureButton);
            this.PackTabSplit.Panel1.Controls.Add(this.DuplicatePackStructureButton);
            this.PackTabSplit.Panel1.Controls.Add(this.PackStructureGridView);
            this.PackTabSplit.Panel1.Controls.Add(this.AddPackStructureButton);
            this.PackTabSplit.Panel1MinSize = 100;
            // 
            // PackTabSplit.Panel2
            // 
            this.PackTabSplit.Panel2.Controls.Add(this.PackStructureDropBox);
            this.PackTabSplit.Panel2.Controls.Add(this.PackTree);
            this.PackTabSplit.Panel2MinSize = 355;
            this.PackTabSplit.Size = new System.Drawing.Size(677, 509);
            this.PackTabSplit.SplitterDistance = 134;
            this.PackTabSplit.TabIndex = 11;
            this.PackTabSplit.TabStop = false;
            // 
            // DeletePackStructureButton
            // 
            this.DeletePackStructureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeletePackStructureButton.Location = new System.Drawing.Point(242, 109);
            this.DeletePackStructureButton.Name = "DeletePackStructureButton";
            this.DeletePackStructureButton.Size = new System.Drawing.Size(114, 20);
            this.DeletePackStructureButton.TabIndex = 9;
            this.DeletePackStructureButton.Text = "Delete Structure";
            this.DeletePackStructureButton.UseVisualStyleBackColor = true;
            this.DeletePackStructureButton.Click += new System.EventHandler(this.DeletePackStructureButton_Click);
            // 
            // DuplicatePackStructureButton
            // 
            this.DuplicatePackStructureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DuplicatePackStructureButton.Location = new System.Drawing.Point(122, 109);
            this.DuplicatePackStructureButton.Name = "DuplicatePackStructureButton";
            this.DuplicatePackStructureButton.Size = new System.Drawing.Size(114, 20);
            this.DuplicatePackStructureButton.TabIndex = 10;
            this.DuplicatePackStructureButton.Text = "Duplicate Structure";
            this.DuplicatePackStructureButton.UseVisualStyleBackColor = true;
            this.DuplicatePackStructureButton.Click += new System.EventHandler(this.DuplicatePackStructureButton_Click);
            // 
            // PackStructureGridView
            // 
            this.PackStructureGridView.AllowUserToAddRows = false;
            this.PackStructureGridView.AllowUserToDeleteRows = false;
            this.PackStructureGridView.AllowUserToResizeColumns = false;
            this.PackStructureGridView.AllowUserToResizeRows = false;
            this.PackStructureGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackStructureGridView.AutoGenerateColumns = false;
            this.PackStructureGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PackStructureGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PackStructureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackStructureGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackStructureGridViewNameTextBoxColumn,
            this.PackStructureGridViewDescriptionTextBoxColumn});
            this.PackStructureGridView.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.PackStructureSource, "NameIsNull", true));
            this.PackStructureGridView.DataSource = this.PackStructureSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PackStructureGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PackStructureGridView.EnableHeadersVisualStyles = false;
            this.PackStructureGridView.Location = new System.Drawing.Point(3, 3);
            this.PackStructureGridView.MultiSelect = false;
            this.PackStructureGridView.Name = "PackStructureGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PackStructureGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PackStructureGridView.RowHeadersVisible = false;
            this.PackStructureGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PackStructureGridView.Size = new System.Drawing.Size(669, 100);
            this.PackStructureGridView.TabIndex = 2;
            this.PackStructureGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PackStructureGridView_CellBeginEdit);
            this.PackStructureGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PackStructureGridView_CellEndEdit);
            this.PackStructureGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.PackStructureGridView_CellValidating);
            this.PackStructureGridView.SelectionChanged += new System.EventHandler(this.PackStructure_SelectionChanged);
            // 
            // PackStructureGridViewNameTextBoxColumn
            // 
            this.PackStructureGridViewNameTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PackStructureGridViewNameTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.NullValue = "Default";
            this.PackStructureGridViewNameTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PackStructureGridViewNameTextBoxColumn.HeaderText = "Name";
            this.PackStructureGridViewNameTextBoxColumn.Name = "PackStructureGridViewNameTextBoxColumn";
            this.PackStructureGridViewNameTextBoxColumn.Width = 60;
            // 
            // PackStructureGridViewDescriptionTextBoxColumn
            // 
            this.PackStructureGridViewDescriptionTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PackStructureGridViewDescriptionTextBoxColumn.DataPropertyName = "Description";
            this.PackStructureGridViewDescriptionTextBoxColumn.HeaderText = "Description";
            this.PackStructureGridViewDescriptionTextBoxColumn.Name = "PackStructureGridViewDescriptionTextBoxColumn";
            this.PackStructureGridViewDescriptionTextBoxColumn.ReadOnly = true;
            // 
            // PackStructureSource
            // 
            this.PackStructureSource.DataSource = typeof(Handover_Pack_Compiler.PackStructure);
            // 
            // AddPackStructureButton
            // 
            this.AddPackStructureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPackStructureButton.Location = new System.Drawing.Point(2, 109);
            this.AddPackStructureButton.Name = "AddPackStructureButton";
            this.AddPackStructureButton.Size = new System.Drawing.Size(114, 20);
            this.AddPackStructureButton.TabIndex = 8;
            this.AddPackStructureButton.Text = "Add Structure";
            this.AddPackStructureButton.UseVisualStyleBackColor = true;
            this.AddPackStructureButton.Click += new System.EventHandler(this.AddPackStructureButton_Click);
            // 
            // PackStructureDropBox
            // 
            this.PackStructureDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackStructureDropBox.DataBindings.Add(new System.Windows.Forms.Binding("DisplayMember", this.PackStructureSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Default"));
            this.PackStructureDropBox.DataSource = this.PackStructureSource;
            this.PackStructureDropBox.DisplayMember = "Name";
            this.PackStructureDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackStructureDropBox.FormattingEnabled = true;
            this.PackStructureDropBox.Location = new System.Drawing.Point(3, 3);
            this.PackStructureDropBox.Name = "PackStructureDropBox";
            this.PackStructureDropBox.Size = new System.Drawing.Size(669, 21);
            this.PackStructureDropBox.TabIndex = 1;
            this.PackStructureDropBox.ValueMember = "Name";
            this.PackStructureDropBox.SelectionChangeCommitted += new System.EventHandler(this.PackStructure_SelectionChanged);
            // 
            // PackTree
            // 
            this.PackTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackTree.CurrentPack = null;
            this.PackTree.Location = new System.Drawing.Point(3, 30);
            this.PackTree.MinimumSize = new System.Drawing.Size(500, 333);
            this.PackTree.Name = "PackTree";
            this.PackTree.Size = new System.Drawing.Size(669, 333);
            this.PackTree.TabIndex = 0;
            // 
            // PacksTab
            // 
            this.PacksTab.Location = new System.Drawing.Point(4, 22);
            this.PacksTab.Name = "PacksTab";
            this.PacksTab.Padding = new System.Windows.Forms.Padding(3);
            this.PacksTab.Size = new System.Drawing.Size(677, 509);
            this.PacksTab.TabIndex = 6;
            this.PacksTab.Text = "Packs";
            this.PacksTab.UseVisualStyleBackColor = true;
            // 
            // FilesTab
            // 
            this.FilesTab.Location = new System.Drawing.Point(4, 22);
            this.FilesTab.Name = "FilesTab";
            this.FilesTab.Size = new System.Drawing.Size(677, 509);
            this.FilesTab.TabIndex = 4;
            this.FilesTab.Text = "Files";
            this.FilesTab.UseVisualStyleBackColor = true;
            // 
            // CompileTab
            // 
            this.CompileTab.Location = new System.Drawing.Point(4, 22);
            this.CompileTab.Name = "CompileTab";
            this.CompileTab.Padding = new System.Windows.Forms.Padding(3);
            this.CompileTab.Size = new System.Drawing.Size(677, 509);
            this.CompileTab.TabIndex = 0;
            this.CompileTab.Text = "Compile";
            this.CompileTab.UseVisualStyleBackColor = true;
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
            this.ModuleTab.Size = new System.Drawing.Size(677, 509);
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
            this.ModuleDropBox.Location = new System.Drawing.Point(3, 3);
            this.ModuleDropBox.Name = "ModuleDropBox";
            this.ModuleDropBox.Size = new System.Drawing.Size(668, 21);
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
            this.EditModuleButton.Location = new System.Drawing.Point(276, 483);
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
            this.DeleteModuleButton.Location = new System.Drawing.Point(557, 483);
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
            this.AddModuleButton.Location = new System.Drawing.Point(6, 483);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModuleGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ModuleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModuleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleGridViewNameTextBoxColumn,
            this.ModuleGridViewDatasheetTextBoxColumn,
            this.ModuleGridViewWarrantyTextBoxColumn});
            this.ModuleGridView.DataSource = this.ModuleDataSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ModuleGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ModuleGridView.EnableHeadersVisualStyles = false;
            this.ModuleGridView.Location = new System.Drawing.Point(6, 127);
            this.ModuleGridView.MultiSelect = false;
            this.ModuleGridView.Name = "ModuleGridView";
            this.ModuleGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ModuleGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ModuleGridView.RowHeadersVisible = false;
            this.ModuleGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ModuleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModuleGridView.Size = new System.Drawing.Size(665, 350);
            this.ModuleGridView.TabIndex = 9;
            this.ModuleGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ModuleGridView_DataBindingComplete);
            this.ModuleGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModuleGridView_RowValidated);
            // 
            // ModuleGridViewNameTextBoxColumn
            // 
            this.ModuleGridViewNameTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ModuleGridViewNameTextBoxColumn.DataPropertyName = "Name";
            this.ModuleGridViewNameTextBoxColumn.Frozen = true;
            this.ModuleGridViewNameTextBoxColumn.HeaderText = "Name";
            this.ModuleGridViewNameTextBoxColumn.Name = "ModuleGridViewNameTextBoxColumn";
            this.ModuleGridViewNameTextBoxColumn.ReadOnly = true;
            this.ModuleGridViewNameTextBoxColumn.Width = 60;
            // 
            // ModuleGridViewDatasheetTextBoxColumn
            // 
            this.ModuleGridViewDatasheetTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModuleGridViewDatasheetTextBoxColumn.DataPropertyName = "Datasheet";
            this.ModuleGridViewDatasheetTextBoxColumn.HeaderText = "Datasheet";
            this.ModuleGridViewDatasheetTextBoxColumn.Name = "ModuleGridViewDatasheetTextBoxColumn";
            this.ModuleGridViewDatasheetTextBoxColumn.ReadOnly = true;
            // 
            // ModuleGridViewWarrantyTextBoxColumn
            // 
            this.ModuleGridViewWarrantyTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModuleGridViewWarrantyTextBoxColumn.DataPropertyName = "Warranty";
            this.ModuleGridViewWarrantyTextBoxColumn.HeaderText = "Warranty";
            this.ModuleGridViewWarrantyTextBoxColumn.Name = "ModuleGridViewWarrantyTextBoxColumn";
            this.ModuleGridViewWarrantyTextBoxColumn.ReadOnly = true;
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
            this.InverterTab.Size = new System.Drawing.Size(677, 509);
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
            this.InverterDropBox.Location = new System.Drawing.Point(3, 3);
            this.InverterDropBox.Name = "InverterDropBox";
            this.InverterDropBox.Size = new System.Drawing.Size(668, 21);
            this.InverterDropBox.TabIndex = 8;
            this.InverterDropBox.ValueMember = "Name";
            // 
            // EditInverterButton
            // 
            this.EditInverterButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditInverterButton.Location = new System.Drawing.Point(276, 483);
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
            this.DeleteInverterButton.Location = new System.Drawing.Point(557, 483);
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
            this.AddInverterButton.Location = new System.Drawing.Point(6, 483);
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverterGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.InverterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InverterGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InverterGridViewNameTextBoxColumn,
            this.InverterGridViewDatasheetTextBoxColumn,
            this.InverterGridViewSolarEdgeCheckBoxColumn});
            this.InverterGridView.DataSource = this.InverterDataSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InverterGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.InverterGridView.EnableHeadersVisualStyles = false;
            this.InverterGridView.Location = new System.Drawing.Point(6, 127);
            this.InverterGridView.MultiSelect = false;
            this.InverterGridView.Name = "InverterGridView";
            this.InverterGridView.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverterGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.InverterGridView.RowHeadersVisible = false;
            this.InverterGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.InverterGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InverterGridView.Size = new System.Drawing.Size(665, 350);
            this.InverterGridView.TabIndex = 2;
            this.InverterGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.InverterGridView_DataBindingComplete);
            this.InverterGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.InverterGridView_RowValidated);
            // 
            // InverterGridViewNameTextBoxColumn
            // 
            this.InverterGridViewNameTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InverterGridViewNameTextBoxColumn.DataPropertyName = "Name";
            this.InverterGridViewNameTextBoxColumn.Frozen = true;
            this.InverterGridViewNameTextBoxColumn.HeaderText = "Name";
            this.InverterGridViewNameTextBoxColumn.Name = "InverterGridViewNameTextBoxColumn";
            this.InverterGridViewNameTextBoxColumn.ReadOnly = true;
            this.InverterGridViewNameTextBoxColumn.Width = 60;
            // 
            // InverterGridViewDatasheetTextBoxColumn
            // 
            this.InverterGridViewDatasheetTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InverterGridViewDatasheetTextBoxColumn.DataPropertyName = "Datasheet";
            this.InverterGridViewDatasheetTextBoxColumn.HeaderText = "Datasheet";
            this.InverterGridViewDatasheetTextBoxColumn.Name = "InverterGridViewDatasheetTextBoxColumn";
            this.InverterGridViewDatasheetTextBoxColumn.ReadOnly = true;
            // 
            // InverterGridViewSolarEdgeCheckBoxColumn
            // 
            this.InverterGridViewSolarEdgeCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InverterGridViewSolarEdgeCheckBoxColumn.DataPropertyName = "SolarEdge";
            this.InverterGridViewSolarEdgeCheckBoxColumn.HeaderText = "SolarEdge";
            this.InverterGridViewSolarEdgeCheckBoxColumn.Name = "InverterGridViewSolarEdgeCheckBoxColumn";
            this.InverterGridViewSolarEdgeCheckBoxColumn.ReadOnly = true;
            this.InverterGridViewSolarEdgeCheckBoxColumn.Width = 62;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.CommSiteButton);
            this.SettingsTab.Controls.Add(this.ProgDataButton);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(677, 509);
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // CommSiteButton
            // 
            this.CommSiteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommSiteButton.Location = new System.Drawing.Point(3, 55);
            this.CommSiteButton.MaximumSize = new System.Drawing.Size(5000, 46);
            this.CommSiteButton.MinimumSize = new System.Drawing.Size(0, 46);
            this.CommSiteButton.Name = "CommSiteButton";
            this.CommSiteButton.Size = new System.Drawing.Size(671, 46);
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
            this.ProgDataButton.Size = new System.Drawing.Size(671, 46);
            this.ProgDataButton.TabIndex = 0;
            this.ProgDataButton.Text = "Program Data Path";
            this.ProgDataButton.Value = "";
            this.ProgDataButton.ValueUpdate += new System.EventHandler(this.ProgDataButton_ValueUpdate);
            // 
            // PackCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 536);
            this.Controls.Add(this.OperationTabs);
            this.Name = "PackCompiler";
            this.Text = "Mypower Handover Pack Compiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PackCompiler_FormClosing);
            this.OperationTabs.ResumeLayout(false);
            this.StructureTab.ResumeLayout(false);
            this.PackTabSplit.Panel1.ResumeLayout(false);
            this.PackTabSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PackTabSplit)).EndInit();
            this.PackTabSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PackStructureGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackStructureSource)).EndInit();
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
        private System.Windows.Forms.TabPage StructureTab;
        private System.Windows.Forms.TabControl OperationTabs;
        private System.Windows.Forms.DataGridView InverterGridView;
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
        private FolderPathButton CommSiteButton;
        private FolderPathButton ProgDataButton;
        private System.Windows.Forms.DataGridView PackStructureGridView;
        private System.Windows.Forms.BindingSource PackStructureSource;
        private System.Windows.Forms.Button DuplicatePackStructureButton;
        private System.Windows.Forms.Button DeletePackStructureButton;
        private System.Windows.Forms.Button AddPackStructureButton;
        private System.Windows.Forms.SplitContainer PackTabSplit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleGridViewNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleGridViewDatasheetTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleGridViewWarrantyTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InverterGridViewNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InverterGridViewDatasheetTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InverterGridViewSolarEdgeCheckBoxColumn;
        private PackStructureTree PackTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackStructureGridViewNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackStructureGridViewDescriptionTextBoxColumn;
        private System.Windows.Forms.TabPage PacksTab;
        private System.Windows.Forms.ComboBox PackStructureDropBox;
    }
}

