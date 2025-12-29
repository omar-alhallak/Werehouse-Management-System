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
    public partial class InventoryDashboardForm : Form
    {
        public InventoryDashboardForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageCategories_Click_1(object sender, EventArgs e)
        {
            CategoryManagementForm product = new CategoryManagementForm();
            product.Show();
            this.Close();
        }

        private void btnManageProducts_Click_1(object sender, EventArgs e)
        {
            ProductManagmentForm product=new ProductManagmentForm();
            product.Show();
            this.Close();
           
        }

        private void InventoryDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            StockViewForm stockViewForm = new StockViewForm();
            stockViewForm.Show();
            this.Close();
        }
    }
}
