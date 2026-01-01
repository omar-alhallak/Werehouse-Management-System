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
    public partial class Form_DashboardSalse: Form
    {
        public Form_DashboardSalse()
        {
            InitializeComponent();      
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            CartForm sales = new CartForm();
            sales.Show();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm Order = new OrderForm();
            Order.Show();
            this.Close();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm Invoice = new InvoiceForm();
            Invoice.Show();
            this.Close();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnForm Return = new ReturnForm();
            Return.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_LogIN LogIN = new Form_LogIN();
            LogIN.Show();
            this.Close();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            Form_DashboardAdmin DashboardAdmin = new Form_DashboardAdmin();
            DashboardAdmin.Show();
            this.Close();
        }

        private void Form_DashboardSalse_Load(object sender, EventArgs e)
        {
            btnBack1.Visible = Program.LogedINUser != null && Program.LogedINUser.Role == UserRole.Admin;
            if (Program.LogedINUser != null)
            {
                label1.Text = "Welcoom " + Program.LogedINUser.FullName;
            }
        }
    }
}
