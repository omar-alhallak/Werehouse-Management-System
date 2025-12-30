using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_sales_module
{
    public partial class ReturnForm: Form
    {
        private readonly IOrderService orderService = Program.OrderService;
        public ReturnForm()
        {
            InitializeComponent();

        }   

        // عرض الطلب 
        private void button1_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text.Trim(); 

            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("الرجاء إدخال رقم الطلب.");
                return;
            }

            var order = orderService.GetOrderById(orderId); 

            if (order == null)
            {
                MessageBox.Show("رقم الطلب غير موجود.");
                return;
            }

            // بناء نص عرض الطلب
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"رقم الطلب: {order.Id}");
            sb.AppendLine($"اسم الزبون: {order.CustomerName}");
            sb.AppendLine($"تاريخ الطلب: {order.Date.ToShortDateString()}");
            sb.AppendLine("المنتجات:");
            sb.AppendLine("-------------------------");

            foreach (var item in order.Items)
            {
                sb.AppendLine($"{item.Product.Name} - الكمية: {item.Quantity} - السعر: {item.Total}");
            }

            sb.AppendLine("-------------------------");
            sb.AppendLine($"المجموع: {order.Total}");
            sb.AppendLine($"الربح: {order.profitable}");
         
            rtbResult.Text = sb.ToString();
        }
        // ارجاع الطلب
        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("أدخل رقم الطلب");
                return;
            }

            bool success = orderService.ReturnOrder(id);

            if (success)
                MessageBox.Show("تم إرجاع الطلب بنجاح");
            else
                MessageBox.Show("رقم الطلب غير موجود");
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "ID")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Wheat;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Gray;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DashboardForm dash = new DashboardForm();
            dash.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void ReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.Count==0)
            {
                Application.Exit();
            }
        }

    
    }
}
