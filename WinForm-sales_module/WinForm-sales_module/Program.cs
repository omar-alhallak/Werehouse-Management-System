using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_sales_module
{
    static class Program
    {
        public static IOrderService OrderService = new OrderService();
        public static IInvoiceService InvoiceService = new InvoiceService();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DashboardForm dash = new DashboardForm();
            dash.Show();
            Application.Run();

        }
    }
}
