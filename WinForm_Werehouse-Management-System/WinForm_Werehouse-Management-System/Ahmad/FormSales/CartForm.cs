using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForm_Werehouse_Management_System
{
    public partial class CartForm: Form
    {
        private readonly IOrderService orderService = new OrderService();
        private readonly IInvoiceService invoiceService = new InvoiceService();

        List<ShoppingCart> carts = new List<ShoppingCart>();
        int currentIndex = 0;
        
        public CartForm()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PlaceholderHelper.PlaceholderFromTextBox(txtsersh , "Sersh");
            PlaceholderHelper.PlaceholderFromTextBox(txtName, "Name");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoGenerateColumns = false;

            // انشاء السلات 
            if (carts.Count == 0)
            {
                for (int i = 0; i < 4; i++)
                    carts.Add(new ShoppingCart());
            }
            // عرض محتويات السلة الأولى
            RefreshCartUI();
            textBox1.Text = carts[currentIndex].GetTotal().ToString("C0");

        }
        // لعرض تفاصيل منتج
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 string Name = txtsersh.Text;

                //  جلب المنتج من قائمة المنتجات
                Product product = ProductService.GetProductByName(Name);

                if (product == null)
                {
                    MessageBox.Show("المنتج غير موجود");
                    return;
                }
                textBox3.Text = product.Name;
                textBox2.Text = product.UnitPrice.ToString("c0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // اضافة منتج للسلة
        private void btmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtsersh.Text;
                int qty = (int)comQuantity.Value;

                //  جلب المنتج من قائمة المنتجات
                Product product = ProductService.GetProductByName(Name);

                if (product == null)
                {
                    MessageBox.Show("المنتج غير موجود");
                    return;
                }

                carts[currentIndex].AddProduct(product, qty);
                RefreshCartUI();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // حذف منتج من السلة
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtsersh.Text;
                Product product = ProductService.GetProductByName(Name);

                if (product == null)
                {
                    MessageBox.Show("المنتج غير موجود");
                    return;
                }

                carts[currentIndex].RemoveProduct(product.Id);
                RefreshCartUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // الغاء الطلب
        private void button2_Click(object sender, EventArgs e)
        {
            carts[currentIndex].Clear();
            RefreshCartUI();
        }
        // تحديث السلة
        void RefreshCartUI()
        {
            dataGridView1.Rows.Clear();
            var currentCart = carts[currentIndex];

            foreach (var item in currentCart.Items)
            {
                dataGridView1.Rows.Add(
                    item.Product.Name,
                    item.Price,
                    item.Quantity,
                    item.Total
                );
            }
            textBox1.Text = currentCart.GetTotal().ToString("C0");
            comQuantity.Value = 0;
        }
        // التنقل بين السلات
        private void btncart1_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            RefreshCartUI();
        }

        private void btncart2_Click_1(object sender, EventArgs e)
        {
            currentIndex = 1;
            RefreshCartUI();
        }

        private void btncart3_Click(object sender, EventArgs e)
        {
            currentIndex = 2;
            RefreshCartUI();

        }

        private void btncart4_Click_1(object sender, EventArgs e)
        {
            currentIndex = 3;
            RefreshCartUI();
        }

   
        // اتمام الطلب
        private void btnorder_Click(object sender, EventArgs e)
        {
            try
            {
                var currentCart = carts[currentIndex];

                if (currentCart.Items.Count == 0)
                {
                    MessageBox.Show("السلة فارغة");
                    return;
                }
                // تحذف المساف من البداية و النهاية Trim
                string customerName = txtName.Text.Trim();

                if (customerName == "" || customerName=="Name")
                {
                    MessageBox.Show("الرجاء إدخال اسم الزبون");
                    return;
                }

                // إنشاء طلب
                Order order = new Order
                {
                    Date = DateTime.Now,
                    CustomerName = customerName,
                    Items = currentCart.Items.ToList(),
                    Total = currentCart.GetTotal(),
                    profitable = currentCart.GetTotalProfit()
                };
                Invoice invoice = new Invoice
                {
                    Id = order.Id ,
                    CustomerName = customerName,
                    InvoiceDate = DateTime.Now,
                    TotalAmount = currentCart.GetTotal(),

                };

                // حفظ الطلب
                orderService.Add(order);
                // حفظ الفاتورة 
                invoiceService.Add(invoice);

                // مسح السلة بعد البيع (بدون إعادة للمخزون)
                currentCart.Items.Clear();
                //افراغ حقل الاسم و حقل البحث و حقول العرض
                txtName.Text = "Name";
                txtName.ForeColor = Color.Gray;
                txtsersh.Text = "Sersh";
                txtsersh.ForeColor = Color.Gray;
                textBox2.Text = "";
                textBox3.Text = "";

                RefreshCartUI();

                MessageBox.Show($" {order.Id} تم الطلب بنجاح رقم الفاتورة ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Form_DashboardSalse dash = new Form_DashboardSalse();
            dash.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
