using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm_sales_module
{
    public partial class InvoiceForm: Form
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceForm()
        {
            InitializeComponent();
            _invoiceService = Program.InvoiceService;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            this.ActiveControl = btnShow;         
            // جماليات لزر البحث
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShow.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            string customerName = txtUsername.Text;
            //تحذير في حال عدم إدخال اسم الزبون
            if (txtUsername.Text == "User Name")
            {
                MessageBox.Show("الرجاء إدخال اسم الزبون", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // البحث عن الفواتير الخاصة بالزبون وعرضها في مربع النص
            rtbResult.Text = _invoiceService.GetInvoicesByCustomerName(customerName);
        }




        // النص الافتراضي لحقل اسم الزبون
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "User Name")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "User Name";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  

        private void InvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
