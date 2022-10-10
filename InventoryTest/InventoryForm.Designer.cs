
namespace InventoryTest
{
    partial class InventoryForm
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
            this.deliveryReportDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.supplyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersDataSet = new InventoryTest.suppliersDataSet();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsViewDataSet = new InventoryTest.productsViewDataSet();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.productsViewTableAdapter = new InventoryTest.productsViewDataSetTableAdapters.ProductsViewTableAdapter();
            this.suppliersTableAdapter = new InventoryTest.suppliersDataSet3TableAdapters.SuppliersTableAdapter();
            this.suppliersComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.finishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showReportButton = new System.Windows.Forms.Button();
            this.deliveryReportDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryReportDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryReportDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
           
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier";
            // 
            // supplyButton
            // 
            this.supplyButton.Location = new System.Drawing.Point(23, 843);
            this.supplyButton.Name = "supplyButton";
            this.supplyButton.Size = new System.Drawing.Size(205, 53);
            this.supplyButton.TabIndex = 3;
            this.supplyButton.Text = "Create Delivery";
            this.supplyButton.UseVisualStyleBackColor = true;
            this.supplyButton.Click += new System.EventHandler(this.SupplyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Products";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.suppliersDataSet;
            // 
            // suppliersDataSet3
            // 
            this.suppliersDataSet.DataSetName = "suppliersDataSet3";
            this.suppliersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToOrderColumns = true;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Weight,
            this.ProductId,
            this.ProductName,
            this.Description,
            this.Category,
            this.Type,
            this.SupplierId,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productsViewBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(18, 156);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 72;
            this.productsDataGridView.RowTemplate.Height = 31;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(1850, 617);
            this.productsDataGridView.TabIndex = 8;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.MinimumWidth = 9;
            this.Check.Name = "Check";
            this.Check.Width = 50;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 9;
            this.Weight.Name = "Weight";
            this.Weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Weight.ToolTipText = "Input weight here";
            this.Weight.Width = 50;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 9;
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            this.ProductId.Width = 175;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 9;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 120;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 9;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 120;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 9;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 120;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 9;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 120;
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.MinimumWidth = 9;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            this.SupplierId.Visible = false;
            this.SupplierId.Width = 175;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 175;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 175;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 175;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // productsViewBindingSource
            // 
            this.productsViewBindingSource.DataMember = "ProductsView";
            this.productsViewBindingSource.DataSource = this.productsViewDataSet;
            // 
            // productsViewDataSet
            // 
            this.productsViewDataSet.DataSetName = "productsViewDataSet";
            this.productsViewDataSet.EnforceConstraints = false;
            this.productsViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // productsViewTableAdapter
            // 
            this.productsViewTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersComboBox
            // 
            this.suppliersComboBox.DataSource = this.suppliersBindingSource;
            this.suppliersComboBox.DisplayMember = "Name";
            this.suppliersComboBox.FormattingEnabled = true;
            this.suppliersComboBox.Location = new System.Drawing.Point(18, 46);
            this.suppliersComboBox.Name = "suppliersComboBox";
            this.suppliersComboBox.Size = new System.Drawing.Size(325, 32);
            this.suppliersComboBox.TabIndex = 7;
            this.suppliersComboBox.ValueMember = "Id";
            this.suppliersComboBox.SelectedIndexChanged += new System.EventHandler(this.suppliersComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1821, 1150);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.supplyButton);
            this.tabPage1.Controls.Add(this.productsDataGridView);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.suppliersComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1813, 1113);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deliveries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.finishDateTimePicker);
            this.tabPage2.Controls.Add(this.startDateTimePicker);
            this.tabPage2.Controls.Add(this.showReportButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1813, 1113);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventoryTest.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 249);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1686, 441);
            this.reportViewer1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Finish Date";
            // 
            // finishDateTimePicker
            // 
            this.finishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finishDateTimePicker.Location = new System.Drawing.Point(289, 83);
            this.finishDateTimePicker.Name = "finishDateTimePicker";
            this.finishDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.finishDateTimePicker.TabIndex = 10;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(34, 83);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.startDateTimePicker.TabIndex = 9;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // showReportButton
            // 
            this.showReportButton.Location = new System.Drawing.Point(34, 159);
            this.showReportButton.Name = "showReportButton";
            this.showReportButton.Size = new System.Drawing.Size(455, 47);
            this.showReportButton.TabIndex = 0;
            this.showReportButton.Text = "Show Report";
            this.showReportButton.UseVisualStyleBackColor = true;
            this.showReportButton.Click += new System.EventHandler(this.ShowReportButton_Click);
            // 
            // deliveryReportDtoBindingSource
            // 
           // this.deliveryReportDtoBindingSource.DataSource = typeof(Inventory.BLL.DTO.DeliveryReportDto);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 1150);
            this.Controls.Add(this.tabControl1);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryReportDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryReportDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button supplyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private productsViewDataSet productsViewDataSet;
        private System.Windows.Forms.BindingSource productsViewBindingSource;
        private productsViewDataSetTableAdapters.ProductsViewTableAdapter productsViewTableAdapter;
        private suppliersDataSet suppliersDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private suppliersDataSet3TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker finishDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button showReportButton;
        private System.Windows.Forms.BindingSource deliveryReportDtoBindingSource;
        private System.Windows.Forms.BindingSource deliveryReportDtoBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

