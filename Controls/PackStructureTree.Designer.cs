﻿
namespace Handover_Pack_Compiler
{
    partial class PackStructureTree
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
            this.TreeView = new System.Windows.Forms.TreeView();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.AddPropertiesConPathButton = new Handover_Pack_Compiler.FilePathButton();
            this.AddPropertiesGenGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.FolderLabel = new System.Windows.Forms.Label();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MultipleCheckBox = new System.Windows.Forms.CheckBox();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.SEWarrantyCheckBox = new System.Windows.Forms.CheckBox();
            this.ModuleDataCheckBox = new System.Windows.Forms.CheckBox();
            this.OptimiserDataCheckBox = new System.Windows.Forms.CheckBox();
            this.ConstantCheckBox = new System.Windows.Forms.CheckBox();
            this.InverterDataCheckBox = new System.Windows.Forms.CheckBox();
            this.ModuleWarrantyCheckBox = new System.Windows.Forms.CheckBox();
            this.GenericCheckBox = new System.Windows.Forms.CheckBox();
            this.SummaryCheckBox = new System.Windows.Forms.CheckBox();
            this.RequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.GroupBox.SuspendLayout();
            this.AddPropertiesGenGroupBox.SuspendLayout();
            this.FileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.AllowDrop = true;
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView.LabelEdit = true;
            this.TreeView.Location = new System.Drawing.Point(0, 0);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(275, 333);
            this.TreeView.TabIndex = 0;
            this.TreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.TreeView_AfterLabelEdit);
            this.TreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            this.TreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            this.TreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.TreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            this.TreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_DragOver);
            this.TreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeView_KeyDown);
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.Controls.Add(this.AddPropertiesConPathButton);
            this.GroupBox.Controls.Add(this.AddPropertiesGenGroupBox);
            this.GroupBox.Controls.Add(this.MultipleCheckBox);
            this.GroupBox.Controls.Add(this.FileGroupBox);
            this.GroupBox.Controls.Add(this.RequiredCheckBox);
            this.GroupBox.Controls.Add(this.DescriptionTextBox);
            this.GroupBox.Controls.Add(this.NameTextBox);
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(221, 329);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Properties";
            // 
            // AddPropertiesConPathButton
            // 
            this.AddPropertiesConPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPropertiesConPathButton.Description = null;
            this.AddPropertiesConPathButton.Location = new System.Drawing.Point(6, 241);
            this.AddPropertiesConPathButton.MaximumSize = new System.Drawing.Size(5000, 46);
            this.AddPropertiesConPathButton.MinimumSize = new System.Drawing.Size(0, 46);
            this.AddPropertiesConPathButton.Name = "AddPropertiesConPathButton";
            this.AddPropertiesConPathButton.Size = new System.Drawing.Size(209, 46);
            this.AddPropertiesConPathButton.TabIndex = 0;
            this.AddPropertiesConPathButton.Text = "Properties - Constant File Path";
            this.AddPropertiesConPathButton.Value = "";
            this.AddPropertiesConPathButton.ValueUpdate += new System.EventHandler(this.AddPropertiesConPathButton_ValueUpdate);
            // 
            // AddPropertiesGenGroupBox
            // 
            this.AddPropertiesGenGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPropertiesGenGroupBox.Controls.Add(this.SearchLabel);
            this.AddPropertiesGenGroupBox.Controls.Add(this.FolderLabel);
            this.AddPropertiesGenGroupBox.Controls.Add(this.FolderTextBox);
            this.AddPropertiesGenGroupBox.Controls.Add(this.SearchTextBox);
            this.AddPropertiesGenGroupBox.Location = new System.Drawing.Point(6, 241);
            this.AddPropertiesGenGroupBox.Name = "AddPropertiesGenGroupBox";
            this.AddPropertiesGenGroupBox.Size = new System.Drawing.Size(209, 82);
            this.AddPropertiesGenGroupBox.TabIndex = 9;
            this.AddPropertiesGenGroupBox.TabStop = false;
            this.AddPropertiesGenGroupBox.Text = "Properties - Generic File Location";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(3, 39);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(76, 13);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search Terms:";
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = true;
            this.FolderLabel.Location = new System.Drawing.Point(3, 19);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Size = new System.Drawing.Size(73, 13);
            this.FolderLabel.TabIndex = 5;
            this.FolderLabel.Text = "Find in Folder:";
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTextBox.Location = new System.Drawing.Point(76, 16);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(127, 20);
            this.FolderTextBox.TabIndex = 3;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            this.FolderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FolderTextBox_KeyPress);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(6, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(197, 20);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // MultipleCheckBox
            // 
            this.MultipleCheckBox.AutoSize = true;
            this.MultipleCheckBox.Location = new System.Drawing.Point(115, 100);
            this.MultipleCheckBox.Name = "MultipleCheckBox";
            this.MultipleCheckBox.Size = new System.Drawing.Size(90, 17);
            this.MultipleCheckBox.TabIndex = 8;
            this.MultipleCheckBox.Text = "Allow Multiple";
            this.MultipleCheckBox.UseVisualStyleBackColor = true;
            this.MultipleCheckBox.CheckedChanged += new System.EventHandler(this.MultipleCheckBox_CheckedChanged);
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileGroupBox.Controls.Add(this.SEWarrantyCheckBox);
            this.FileGroupBox.Controls.Add(this.ModuleDataCheckBox);
            this.FileGroupBox.Controls.Add(this.OptimiserDataCheckBox);
            this.FileGroupBox.Controls.Add(this.ConstantCheckBox);
            this.FileGroupBox.Controls.Add(this.InverterDataCheckBox);
            this.FileGroupBox.Controls.Add(this.ModuleWarrantyCheckBox);
            this.FileGroupBox.Controls.Add(this.GenericCheckBox);
            this.FileGroupBox.Controls.Add(this.SummaryCheckBox);
            this.FileGroupBox.Location = new System.Drawing.Point(6, 125);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(209, 110);
            this.FileGroupBox.TabIndex = 7;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "File Type";
            // 
            // SEWarrantyCheckBox
            // 
            this.SEWarrantyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SEWarrantyCheckBox.AutoSize = true;
            this.SEWarrantyCheckBox.Location = new System.Drawing.Point(6, 88);
            this.SEWarrantyCheckBox.Name = "SEWarrantyCheckBox";
            this.SEWarrantyCheckBox.Size = new System.Drawing.Size(86, 17);
            this.SEWarrantyCheckBox.TabIndex = 7;
            this.SEWarrantyCheckBox.Tag = "";
            this.SEWarrantyCheckBox.Text = "SE Warranty";
            this.SEWarrantyCheckBox.UseVisualStyleBackColor = true;
            this.SEWarrantyCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // ModuleDataCheckBox
            // 
            this.ModuleDataCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModuleDataCheckBox.AutoSize = true;
            this.ModuleDataCheckBox.Location = new System.Drawing.Point(96, 42);
            this.ModuleDataCheckBox.Name = "ModuleDataCheckBox";
            this.ModuleDataCheckBox.Size = new System.Drawing.Size(87, 17);
            this.ModuleDataCheckBox.TabIndex = 6;
            this.ModuleDataCheckBox.Tag = "";
            this.ModuleDataCheckBox.Text = "Module Data";
            this.ModuleDataCheckBox.UseVisualStyleBackColor = true;
            this.ModuleDataCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // OptimiserDataCheckBox
            // 
            this.OptimiserDataCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptimiserDataCheckBox.AutoSize = true;
            this.OptimiserDataCheckBox.Location = new System.Drawing.Point(96, 88);
            this.OptimiserDataCheckBox.Name = "OptimiserDataCheckBox";
            this.OptimiserDataCheckBox.Size = new System.Drawing.Size(95, 17);
            this.OptimiserDataCheckBox.TabIndex = 5;
            this.OptimiserDataCheckBox.Tag = "";
            this.OptimiserDataCheckBox.Text = "Optimiser Data";
            this.OptimiserDataCheckBox.UseVisualStyleBackColor = true;
            this.OptimiserDataCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // ConstantCheckBox
            // 
            this.ConstantCheckBox.AutoSize = true;
            this.ConstantCheckBox.Location = new System.Drawing.Point(6, 42);
            this.ConstantCheckBox.Name = "ConstantCheckBox";
            this.ConstantCheckBox.Size = new System.Drawing.Size(87, 17);
            this.ConstantCheckBox.TabIndex = 4;
            this.ConstantCheckBox.Tag = "";
            this.ConstantCheckBox.Text = "Constant File";
            this.ConstantCheckBox.UseVisualStyleBackColor = true;
            this.ConstantCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // InverterDataCheckBox
            // 
            this.InverterDataCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InverterDataCheckBox.AutoSize = true;
            this.InverterDataCheckBox.Location = new System.Drawing.Point(96, 65);
            this.InverterDataCheckBox.Name = "InverterDataCheckBox";
            this.InverterDataCheckBox.Size = new System.Drawing.Size(88, 17);
            this.InverterDataCheckBox.TabIndex = 3;
            this.InverterDataCheckBox.Tag = "";
            this.InverterDataCheckBox.Text = "Inverter Data";
            this.InverterDataCheckBox.UseVisualStyleBackColor = true;
            this.InverterDataCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // ModuleWarrantyCheckBox
            // 
            this.ModuleWarrantyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModuleWarrantyCheckBox.AutoSize = true;
            this.ModuleWarrantyCheckBox.Location = new System.Drawing.Point(96, 19);
            this.ModuleWarrantyCheckBox.Name = "ModuleWarrantyCheckBox";
            this.ModuleWarrantyCheckBox.Size = new System.Drawing.Size(107, 17);
            this.ModuleWarrantyCheckBox.TabIndex = 2;
            this.ModuleWarrantyCheckBox.Tag = "";
            this.ModuleWarrantyCheckBox.Text = "Module Warranty";
            this.ModuleWarrantyCheckBox.UseVisualStyleBackColor = true;
            this.ModuleWarrantyCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // GenericCheckBox
            // 
            this.GenericCheckBox.AutoSize = true;
            this.GenericCheckBox.Location = new System.Drawing.Point(6, 19);
            this.GenericCheckBox.Name = "GenericCheckBox";
            this.GenericCheckBox.Size = new System.Drawing.Size(82, 17);
            this.GenericCheckBox.TabIndex = 1;
            this.GenericCheckBox.Tag = "";
            this.GenericCheckBox.Text = "Generic File";
            this.GenericCheckBox.UseVisualStyleBackColor = true;
            this.GenericCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // SummaryCheckBox
            // 
            this.SummaryCheckBox.AutoSize = true;
            this.SummaryCheckBox.Location = new System.Drawing.Point(6, 65);
            this.SummaryCheckBox.Name = "SummaryCheckBox";
            this.SummaryCheckBox.Size = new System.Drawing.Size(88, 17);
            this.SummaryCheckBox.TabIndex = 0;
            this.SummaryCheckBox.Tag = "";
            this.SummaryCheckBox.Text = "Summary File";
            this.SummaryCheckBox.UseVisualStyleBackColor = true;
            this.SummaryCheckBox.CheckedChanged += new System.EventHandler(this.FileCheckBox_CheckedChanged);
            // 
            // RequiredCheckBox
            // 
            this.RequiredCheckBox.AutoSize = true;
            this.RequiredCheckBox.Location = new System.Drawing.Point(6, 100);
            this.RequiredCheckBox.Name = "RequiredCheckBox";
            this.RequiredCheckBox.Size = new System.Drawing.Size(105, 17);
            this.RequiredCheckBox.TabIndex = 2;
            this.RequiredCheckBox.Text = "Always Required";
            this.RequiredCheckBox.UseVisualStyleBackColor = true;
            this.RequiredCheckBox.CheckedChanged += new System.EventHandler(this.RequiredCheckBox_CheckedChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(6, 45);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(209, 49);
            this.DescriptionTextBox.TabIndex = 1;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(6, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.TreeView);
            this.SplitContainer.Panel1MinSize = 250;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.GroupBox);
            this.SplitContainer.Panel2MinSize = 220;
            this.SplitContainer.Size = new System.Drawing.Size(500, 333);
            this.SplitContainer.SplitterDistance = 275;
            this.SplitContainer.TabIndex = 2;
            // 
            // PackStructureTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer);
            this.MinimumSize = new System.Drawing.Size(500, 333);
            this.Name = "PackStructureTree";
            this.Size = new System.Drawing.Size(500, 333);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.AddPropertiesGenGroupBox.ResumeLayout(false);
            this.AddPropertiesGenGroupBox.PerformLayout();
            this.FileGroupBox.ResumeLayout(false);
            this.FileGroupBox.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.CheckBox RequiredCheckBox;
        private System.Windows.Forms.Label FolderLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.CheckBox GenericCheckBox;
        private System.Windows.Forms.CheckBox SummaryCheckBox;
        private System.Windows.Forms.CheckBox InverterDataCheckBox;
        private System.Windows.Forms.CheckBox ModuleWarrantyCheckBox;
        private System.Windows.Forms.CheckBox OptimiserDataCheckBox;
        private System.Windows.Forms.CheckBox ConstantCheckBox;
        private System.Windows.Forms.CheckBox SEWarrantyCheckBox;
        private System.Windows.Forms.CheckBox ModuleDataCheckBox;
        private System.Windows.Forms.CheckBox MultipleCheckBox;
        private System.Windows.Forms.GroupBox AddPropertiesGenGroupBox;
        private FilePathButton AddPropertiesConPathButton;
    }
}
