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
    public partial class ReturnForm: Form
    {
        private readonly IOrderService orderService = new OrderService();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form_DashboardSalse dash = new Form_DashboardSalse();
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

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            PlaceholderHelper.PlaceholderFromTextBox(txtId,"ID");
        }
    }
}