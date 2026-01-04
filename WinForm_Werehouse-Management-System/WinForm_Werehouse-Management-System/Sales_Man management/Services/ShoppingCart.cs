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
        public List<CartItem> Items { get; private set; } = new List<CartItem>();


        // ميثود تضيف منتج إلى السلة
        public void AddProduct(Product product, int quantity)
        {
            if (quantity <= 0)
                throw new Exception("الكمية غير صحيحة");

            if (quantity > product.Stock)
                throw new Exception("الكمية غير متوفرة بالمستودع");
            // يبحث عن المنتج 
            var existing = Items.FirstOrDefault((Func<CartItem, bool>)(i => i.Product.Id == product.Id));

            // فس حال كان المنتج موجود مسبقان
            if (existing != null)
                existing.Quantity += quantity;
            else // يضيف المنتج ان لم يكن موجود
                Items.Add(new CartItem { Product = product, Quantity = quantity });

            // تقليل المخزون بعد الإضافة
            ProductService.ReduceQuantity(product.Id, quantity);
        }

        public void RemoveProduct(int productId)
        {
            //جلب العنصر المراد حذفه
            var item = Items.FirstOrDefault((Func<CartItem, bool>)(i => i.Product.Id == productId));

            if (item == null)
                throw new Exception("المنتج غير موجود في السلة");

            // إعادة الكمية إلى المخزون
            ProductService.IncreaseQuantity(productId, item.Quantity);

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
                ProductService.IncreaseQuantity(item.Product.Id, item.Quantity);
            }

            Items.Clear();
        }
    }
}