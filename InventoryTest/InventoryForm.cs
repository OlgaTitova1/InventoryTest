using Inventory.BLL.DTO;
using Inventory.BLL.Interfaces;

using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InventoryTest
{
    public partial class InventoryForm : Form
    {
        private readonly IInventoryService productService;
        private const string DELIVERY_PATH = "DeliveryReport.rdlc";
        private const string DELIVERY_REPORT_DATASOURCE_NAME = "dsDeliveryReport";

        public InventoryForm(IInventoryService productService)
        {
            this.productService = productService;
            InitializeComponent();
        }

        private async void ShowReportButton_Click(object sender, EventArgs e)
        {
            var reportData = await productService.GetDeliveryReportAsync(startDateTimePicker.Value, finishDateTimePicker.Value);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = DELIVERY_PATH;
            ReportDataSource dataset = new ReportDataSource(DELIVERY_REPORT_DATASOURCE_NAME, reportData);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            dataset.Value = reportData;

        }

        private async void SupplyButton_Click(object sender, EventArgs e)
        {
            var delivery = new CreateDeliveryDto
            {
                SupplierId = long.Parse(suppliersComboBox.SelectedValue.ToString()),
                Products = new List<DeliveryProductDto>()
            };

            foreach (DataGridViewRow row in productsDataGridView.Rows)
            {
                var checkBoxValue = row.Cells["Check"].Value;
                if (checkBoxValue != null && checkBoxValue.Equals(true))
                {
                    var product = new DeliveryProductDto
                    {
                        ProductId = long.Parse((row.DataBoundItem as DataRowView).Row["ProductId"].ToString()),
                        Weight = short.Parse(row.Cells["Weight"].EditedFormattedValue.ToString())
                    };

                    delivery.Products.Add(product);
                }
            }

            if (!delivery.Products.Any())
            {
                MessageBox.Show($"No item was selected");
                return;
            }

            await productService.CreateDeliveryAsync(delivery);

            var supplierName = (suppliersComboBox.SelectedItem as DataRowView).Row["Name"];
            MessageBox.Show($"Delivery was successfully supplied from {supplierName}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productsDataGridView.Columns["Weight"].DefaultCellStyle.NullValue = "1";

            suppliersTableAdapter.Fill(this.suppliersDataSet.Suppliers);
            UpdateProductsViewTable();
         

            var deliveries = new List<ReportDeliveryDataDto>();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath =DELIVERY_PATH;
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new ReportDataSource(DELIVERY_REPORT_DATASOURCE_NAME, deliveries);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = deliveries ;

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report

        }

        private void suppliersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProductsViewTable();
        }

        private void UpdateProductsViewTable()
        {
            if (suppliersComboBox.SelectedValue == null) return;
            productsViewTableAdapter.FillBy2(this.productsViewDataSet.ProductsView, long.Parse(suppliersComboBox.SelectedValue?.ToString()));
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
