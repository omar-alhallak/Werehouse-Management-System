using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_sales_module
{
    public class Order
    {
        public string Id { set; get; } = Guid.NewGuid().ToString("N").Substring(0, 10);
        public string CustomerName { set; get; }
        public List<CartItem> Items { set; get; }=new List<CartItem>();
        public DateTime Date { set; get; }
        public decimal Total { set; get; }
        public decimal profitable { set; get; }
    }
}
