using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    // تجريبية لمنتج
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int QuantityInStock { get; set; }
    }

    // عنصر في السلة
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        // في حال تغيرت تفاصيل المنتج
        public decimal Price => Product.Price;
        public decimal Cost => Product.Cost;
        public string ProductName => Product.Name;
        // _____________________________________
        public decimal Total => Price * Quantity;
        public decimal Profit => (Price - Cost) * Quantity;
    }
}
