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

       

        private void btnManageCategories_Click(object sender, EventArgs e)
        {

        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageCategories_Click_1(object sender, EventArgs e)
        {
            new CategoryManagementForm().Show();

        }
    }
}
