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
    public partial class Form_DashboardAdmin : Form
    {
        public Form_DashboardAdmin()
        {
            InitializeComponent();
        }
  
        private void btnMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccountMang_Click(object sender, EventArgs e)
        {
            Form_AccountManagement AccountManagement = new Form_AccountManagement();
            AccountManagement.Show();
            this.Close(); 
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            if (Program.LogedINUser != null)
            {
                labName.Text= "Welcoom " + Program.LogedINUser.FullName + " (Admin)";
            }
        }

        private void Form_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form_LogIN LogIN = new Form_LogIN();
            LogIN.Show();
            this.Close();
        }

        private void btnsales_man_Click(object sender, EventArgs e)
        {
            Form_DashboardSalse DashboardSalse = new Form_DashboardSalse();
            DashboardSalse.Show();
            DashboardSalse.btnBack1.Visible = true;
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryDashboardForm InventoryDashboard = new InventoryDashboardForm();
            InventoryDashboard.Show();
            InventoryDashboard.btnBack2.Visible = true;
            this.Close();
        }
    }
}