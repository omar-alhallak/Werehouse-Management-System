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
    public partial class OrderForm: Form
    {
        private readonly IOrderService _orderService;
        public OrderForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlaceholderHelper.PlaceholderFromTextBox(txtMonth, "MM / YYYY");
            this.ActiveControl = btnShow;
            label4.Text = "0";
            // جماليات لزر البحث
            btnShow.FlatAppearance.BorderSize = 0;          
            btnShow.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShow.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // تحذير ان التاريخ فارغ
            if (txtMonth.Text == "MM / YYYY")
            {
                MessageBox.Show("يجب ادخال تاريخ", "خطأ إدخال ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            //يقوم بفصل التايخ الى قسم شهر و قسم سنة
            string[] parts = txtMonth.Text.Split('/');
            // يتحقق ان التاريخ يتالف من جزءان
            if (parts.Length !=2)
            {
                MessageBox.Show("يجب ادخال الشهر بهذه الصيغا MM/YYYY", "خطأ إدخال ", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
                return;
            }
            //----------------------------------------------------

            // month يحول جزاء الشهر الى رقم و يخزنه بلمتحول 
            if (!int.TryParse(parts[0], out int month))
            {
                MessageBox.Show("الشهر يجب أن يكون رقمًا",
                    "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من أن الشهر بين 1 و 12
            if (month < 1 || month > 12)
            {
                MessageBox.Show("قيمة الشهر يجب أن تكون بين 01 و 12",
                    "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //----------------------------------------------------
            // year يحول جزاء السنة الى رقم و يخزنه بلمتحول 
            if (!int.TryParse(parts[1], out int year))
            {
                MessageBox.Show("الشهر يجب أن يكون رقمًا",
                    "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من أن السنة بين 2000 و التاريخ الحالي
            int currentYear = DateTime.Now.Year;
            if (year < 2000 || year > currentYear)
            {
                MessageBox.Show("قيمة السنة يجب أن تكون بين 2000 و  " + currentYear,
                    "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //----------------------------------------------------
            //عرض الطلبات في الجدول
            rtbResult.Text = _orderService.OrdersInMonth(month, year);
            //----------------------------------------------------
            //يقوم بجمع مربح كل الطلبات
            decimal Total = _orderService.TotalProfit(month, year);
            //عرض المجموع الارباح
            label4.Text = Total.ToString("C");
        }

        // النص الافتراضي لحقل التاريخ
    
        private void button1_Click(object sender, EventArgs e)
        {
            Form_DashboardSalse dash = new Form_DashboardSalse();
            dash.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
