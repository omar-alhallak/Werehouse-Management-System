using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{

    //حتى نحقق مبدأ فصل الواجهة عن التنفيذ interface نستخدم ال
    public interface IOrderService
    {
        void Add(Order order);
        string OrdersInMonth(int month, int year);
        decimal TotalProfit(int month, int year);
        Order GetOrderById(string id);
        bool ReturnOrder(string id);


    }

    public class OrderService : IOrderService
    {
 
        private List<Order> Orders;

        public OrderService()
        {
           // Orders = ExternalStorage.Load<List<Order>>("Orders.json");
        }

        public void Add(Order order)
        {
            Orders.Add(order);
            //ExternalStorage.Save("orders.json", Orders);
        }

        // ميثود تبحث عن جميع الفواتير الخاصة بزبون محدد
        public string OrdersInMonth(int month, int year)
        {
            StringBuilder strb = new StringBuilder();
            // orders وضع الطلبات في الشهر المدخل في 
            var orders = Orders
                .Where(o => o.Date.Month == month && o.Date.Year == year).ToList();
            // في حال عدم وجود طلبات
            if (!orders.Any())
            {
                strb.AppendLine("لا توجد طلبات في هذا الشهر.");
                return strb.ToString();
            }

            foreach (var inv in orders)
            {
                strb.AppendLine($"  رقم الفاتورة :           {inv.Id}");
                strb.AppendLine($"  اسم الزبون :       {inv.CustomerName}");
                strb.AppendLine($"  المبلغ :       {inv.Total}");
                strb.AppendLine($"  المربح :       {inv.profitable}");
                strb.AppendLine($"التاريخ :{inv.Date.ToShortDateString()}");
                strb.AppendLine("==========================");
            }

            return strb.ToString();
        }
        public decimal TotalProfit(int month, int year)
            {
            var orders = Orders
              .Where(o => o.Date.Month == month && o.Date.Year == year).ToList();
            decimal Total = orders.Sum(o => o.profitable);
            return Total;
            }

        // جلب الطلب باستخدام ID
        public Order GetOrderById(string id)
        {
            return Orders.FirstOrDefault(o => o.Id == id);
        }


        // ارجاع الطلب
        public  bool ReturnOrder(string id)
        {
            var order = GetOrderById(id);
            if (order == null)
                return false;

            // إعادة الكميات إلى المخزون
            foreach (var item in order.Items)
            {
                ProductService.IncreaseQuantity(item.Product.Name, item.Quantity);
            }

            // حذف الطلب من السجل
            Orders.Remove(order);
            //ExternalStorage.Save("orders.json", Orders);
            return true;
        }
  

    }
}
