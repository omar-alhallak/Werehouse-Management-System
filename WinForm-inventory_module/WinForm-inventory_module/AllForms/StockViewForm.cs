using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_inventory_module
{
    public partial class StockViewForm : Form
    {
        public StockViewForm()
        {
            InitializeComponent();
        }
        private CategoryManager categoryManager;
        private ProductManager productManager;

        private List<Product> allProducts = new List<Product>();
        private List<Product> filteredProducts = new List<Product>();

        private void StockViewForm_Load(object sender, EventArgs e)
        {
            categoryManager = new CategoryManager();
            productManager = new ProductManager();

            LoadCategoriesIntoFilter();
            SetupStockGrid();

            // نقرأ كل المنتجات مرة واحدة
            allProducts = productManager.GetAll();
            ApplyFilterAndRefreshGrid();
        }
        private void LoadCategoriesIntoFilter()
        {
            cmbCategoryFilter.Items.Clear();

            // أول خيار: كل التصنيفات
            cmbCategoryFilter.Items.Add("All Categories");

            foreach (var c in categoryManager.GetAll())
            {
                cmbCategoryFilter.Items.Add(c.Name);
            }

            cmbCategoryFilter.SelectedIndex = 0; // All Categories
        }
        private void SetupStockGrid()
        {
            dgvStock.AutoGenerateColumns = false;
            dgvStock.Columns.Clear();

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                Width = 50
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Product Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                HeaderText = "Category",
                Width = 120
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCode",
                HeaderText = "Code",
                Width = 100
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrice",
                HeaderText = "Price",
                Width = 80
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Stock",
                Width = 80
            });

        }
        private void ApplyFilterAndRefreshGrid()
        {
            filteredProducts = new List<Product>();

            string selectedCategory = cmbCategoryFilter.SelectedItem?.ToString();
            string searchText = txtSearch.Text.Trim().ToLower();

            foreach (var p in allProducts)
            {
                bool matches = true;

                // فلتر التصنيف
                if (!string.IsNullOrEmpty(selectedCategory) &&
                    selectedCategory != "All Categories")
                {
                    if (!string.Equals(p.CategoryName, selectedCategory,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        matches = false;
                    }
                }

                // فلتر البحث بالاسم أو الكود
                if (!string.IsNullOrEmpty(searchText))
                {
                    string name = p.Name ?? "";
                    string code = p.Code ?? "";

                    bool nameMatch = name.ToLower().Contains(searchText);
                    bool codeMatch = code.ToLower().Contains(searchText);

                    if (!nameMatch && !codeMatch)
                        matches = false;
                }

                if (matches)
                    filteredProducts.Add(p);
            }

            RefreshStockGrid();
        }


        private void RefreshStockGrid()
        {
            dgvStock.Rows.Clear();

            int totalQuantity = 0;

            foreach (var p in filteredProducts)
            {
                dgvStock.Rows.Add(
                    p.Id,
                    p.Name,
                    p.CategoryName,
                    p.Code,
                    p.UnitPrice,
                    p.Stock
                );

                totalQuantity += p.Stock;
            }

            dgvStock.ClearSelection();

            lblTotalProducts.Text = "Total Products: " + filteredProducts.Count;
            lblTotalQuantity.Text = "Total Quantity: " + totalQuantity;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyFilterAndRefreshGrid();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            cmbCategoryFilter.SelectedIndex = 0;
            txtSearch.Text = "";
            ApplyFilterAndRefreshGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InventoryDashboardForm dashboard = new InventoryDashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
