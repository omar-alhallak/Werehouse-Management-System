using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Werehouse_Management_System
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

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Form_DashboardAdmin DashboardAdmin = new Form_DashboardAdmin();
            DashboardAdmin.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_LogIN LogIN = new Form_LogIN();
            LogIN.Show();
            this.Close();
        }

        private void InventoryDashboardForm_Load(object sender, EventArgs e)
        {
            btnBack2.Visible = Program.LogedINUser != null && Program.LogedINUser.Role == UserRole.Admin;
            if (Program.LogedINUser != null)
            {
                label4.Text = "Welcoom " + Program.LogedINUser.FullName;
            }
        }
    }
}
