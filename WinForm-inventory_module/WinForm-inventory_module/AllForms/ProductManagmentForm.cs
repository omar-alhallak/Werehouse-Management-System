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
    public partial class ProductManagmentForm : Form
    {
        private CategoryManager categoryManager;
        private ProductManager productManager;
        private void ProductManagmentForm_Load(object sender, EventArgs e)
        {
            categoryManager = new CategoryManager();
            productManager = new ProductManager();

            LoadCategoriesIntoCombo();
            SetupProductGrid();
            RefreshProductGrid();
        }
        private void LoadCategoriesIntoCombo()
        {
            cmbCategory.Items.Clear();

            foreach (var c in categoryManager.GetAll())
            {
                cmbCategory.Items.Add(c.Name);
            }

            cmbCategory.SelectedIndex = -1;
        }
        private void SetupProductGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                Width = 50
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCode",
                HeaderText = "Product Code",
                Width = 100
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Product Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategory",
                HeaderText = "Category",
                Width = 120
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrice",
                HeaderText = "Price",
                Width = 80
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Stock",
                Width = 80
            });

            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void RefreshProductGrid()
        {
            dgvProducts.Rows.Clear();

            foreach (var p in productManager.GetAll())
            {
                dgvProducts.Rows.Add(
                    p.Id,
                    p.Code,
                    p.Name,
                    p.CategoryName,
                    p.UnitPrice,
                    p.Stock
                );
            }

            dgvProducts.ClearSelection();
        }


        private Product BuildProductFromForm()
        {
            string name = txtProductName.Text.Trim();

            // السعر
            decimal price;
            decimal.TryParse(txtPrice.Text.Trim(), out price);

            // الكمية
            int stock;
            int.TryParse(txtQuantity.Text.Trim(), out stock);

            Product product = new Product
            {
                Name = name,
                CategoryName = cmbCategory.SelectedItem?.ToString(),
                Code = txtProductCode.Text.Trim(),
                UnitPrice = price,
                Stock = stock,
            };

            return product;
        }

        private void ClearProductInputs()
        {
            txtProductName.Text = "";
            cmbCategory.SelectedIndex = -1;
            txtProductCode.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtProductName.Focus();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = BuildProductFromForm();

                productManager.Add(product);

                ClearProductInputs();
                RefreshProductGrid();

                MessageBox.Show("تم إضافة المنتج بنجاح.", "لإضافة منتج",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CategoryException ex)
            {
                MessageBox.Show(ex.Message, "خطأ بالتحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ غير متوقع " + ex.Message);
            }
        }

        private int selectedProductId = 0;
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        
            // 1 إذا كبسنا على الهيدر (العناوين فوق) ما نعمل شي
            if (e.RowIndex < 0)
                return;

            // نحصل على الصف الذي نقرنا عليه
            var row = dgvProducts.Rows[e.RowIndex];

            if (row.Cells["colId"].Value == null)
                return;

            // نقرأ  Id ونحفظه في selectedProductId
            selectedProductId = Convert.ToInt32(row.Cells["colId"].Value);

            //  تعبئة الحقول من الجدول
            txtProductName.Text = row.Cells["colName"].Value?.ToString();
            txtPrice.Text = row.Cells["colPrice"].Value?.ToString();
            txtQuantity.Text = row.Cells["colStock"].Value?.ToString();

            string categoryName = row.Cells["colCategory"].Value?.ToString();
            if (!string.IsNullOrEmpty(categoryName))
            {
                cmbCategory.SelectedItem = categoryName;
            }
            else
            {
                cmbCategory.SelectedIndex = -1;
            }

            // تعبئة كود المنتج

            Product selectedProduct = null;
            
            foreach (var p in productManager.GetAll())
            {
                if (p.Id == selectedProductId)
                {
                    selectedProduct = p;
                    break;
                }
            }

            if (selectedProduct != null)
            {
                txtProductCode.Text = selectedProduct.Code ?? "";
            }
        

    }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("الرجاء اختيار المنتج اولا", "تعديل",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Product product = BuildProductFromForm();
                product.Id = selectedProductId;

                productManager.Update(product);

                RefreshProductGrid();

                MessageBox.Show("تم تعديل المنتج بنجاح", "تعديل",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CategoryException ex)
            {
                MessageBox.Show(ex.Message, "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ :" + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           InventoryDashboardForm dash = new InventoryDashboardForm();
            dash.Show();
            this.Close();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == 0)
                {
                    MessageBox.Show("الرجاء اختيار المنتج اولا", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result = MessageBox.Show(
                    "هل انت متأكد من حذف هذا المنتج ",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                productManager.Delete(selectedProductId);

                ClearProductInputs();
                selectedProductId = 0;

                RefreshProductGrid();

                MessageBox.Show("تم الحذف بنجاح", "حذف",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CategoryException ex)
            {
                MessageBox.Show(ex.Message, "خطأ بالحذف",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ غير متوقع" + ex.Message);
            }
        }

        // لملئ الجدول بالبيانات
        private void FillProductGrid(List<Product> data)
        {
            dgvProducts.Rows.Clear();

            foreach (var p in data)
            {
                dgvProducts.Rows.Add(
                    p.Id,
                    p.Name,
                    p.CategoryName,
                    p.Code,
                    p.UnitPrice,
                    p.Stock
                );
            }

            dgvProducts.ClearSelection();
        }


        private void ProductManagmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtProductSearch.Text;
            var result = productManager.Search(text);
            FillProductGrid(result);
        }
    }
}
