using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WinForm_inventory_module.CategoryManagement;

namespace WinForm_inventory_module
{
    public partial class CategoryManagementForm : Form
    {
       
        private CategoryManager Manager;
        public CategoryManagementForm()
        {
            InitializeComponent();

        }
       

        private void SetupGrid()
        {
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.Columns.Clear();

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                Width = 60
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Category Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCategories.ReadOnly = true;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void RefreshGrid()
        {
            dgvCategories.Rows.Clear();

            foreach (var c in Manager.GetAll())

            {
                dgvCategories.Rows.Add(c.Id, c.Name);
            }

            dgvCategories.ClearSelection();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtCategoryName.Text =
                dgvCategories.Rows[e.RowIndex].Cells[1].Value?.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.Add(txtCategoryName.Text);

                txtCategoryName.Clear();
                txtCategoryName.Focus();

                RefreshGrid();
            }
            catch (CategoryException ex)
            {
                MessageBox.Show(ex.Message, "Add Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void CategoryManagementForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            Manager = new CategoryManager();
            RefreshGrid();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            // 1) لازم المستخدم يختار صف من الجدول
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category first.", "Update Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 2) أخذ الـ Id من العمود الأول (Id)
                int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);

                // 3) أخذ الاسم الجديد من textbox
                string newName = txtCategoryName.Text;

                // 4) نداء على المانجر (هو يعمل validation + حفظ)
                Manager.Update(id, newName);

                // 5) تنظيف وتحديث
                txtCategoryName.Clear();
                txtCategoryName.Focus();
                RefreshGrid();
            }
            catch (CategoryException ex)
            {
                MessageBox.Show(ex.Message, "Update Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category first.", "Delete Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);

            DialogResult res = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (res != DialogResult.Yes)
                return;

            try
            {
                Manager.Delete(id);

                txtCategoryName.Clear();
                txtCategoryName.Focus();
                RefreshGrid();
            }
            catch (CategoryException ex)
            {
                MessageBox.Show(ex.Message, "Delete Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


