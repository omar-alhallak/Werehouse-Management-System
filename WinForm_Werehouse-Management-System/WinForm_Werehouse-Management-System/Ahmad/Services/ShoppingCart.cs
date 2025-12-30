using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinForm_Werehouse_Management_System
{
    public class ShoppingCart
    {
        // Items مصفوفة منتجات السلة
        public List<CartItem> Items  = new List<CartItem>();


        // ميثود تضيف منتج إلى السلة
        public void AddProduct(Product product, int quantity)
        {
            if (quantity <= 0)
                throw new Exception("الكمية غير صحيحة");

            if (quantity > product.QuantityInStock)
                throw new Exception("الكمية غير متوفرة بالمستودع");
            // يبحث عن المنتج 
            var existing = Items.FirstOrDefault(i => i.Product.Name == product.Name);
            // فس حال كان المنتج موجود مسبقان
            if (existing != null)
                existing.Quantity += quantity;
            else // يضيف المنتج ان لم يكن موجود
                Items.Add(new CartItem { Product = product, Quantity = quantity });

            // تقليل المخزون بعد الإضافة
            ProductService.ReduceQuantity(product.Name, quantity);

        }

        public void RemoveProduct(string productName)
        {
            //جلب العنصر المراد حذفه
            var item = Items.FirstOrDefault(i => i.Product.Name == productName);

            if (item == null)
                throw new Exception("المنتج غير موجود في السلة");

            // إعادة الكمية إلى المخزون
            ProductService.IncreaseQuantity(productName, item.Quantity);

            Items.Remove(item);
        }


        public decimal GetTotal()
        {
            return Items.Sum(i => i.Total);
        }

        public decimal GetTotalProfit()
        {
            return Items.Sum(i => i.Profit);
        }

        public void Clear()
        {
            foreach (var item in Items)
            {
                ProductService.IncreaseQuantity(item.Product.Name, item.Quantity);
            }

            Items.Clear();
        }


    }
}
