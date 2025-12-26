using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_inventory_module.CategoryManagement;

namespace WinForm_inventory_module
{
    public partial class ProductManagmentForm : Form
    {
        private CategoryManager categoryManager;

        public ProductManagmentForm()
        {
            InitializeComponent();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductManagmentForm_Load(object sender, EventArgs e)
        {
            categoryManager = new CategoryManager();

              LoadCategoriesIntoCombo();
        }

        private void LoadCategoriesIntoCombo()
        {
            cmbCategory.Items.Clear();

            foreach (var c in categoryManager.GetAll())
            {
                cmbCategory.Items.Add(c.Name);
            }

            cmbCategory.SelectedIndex = -1;   // لا يختار شيء بالبداية
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
