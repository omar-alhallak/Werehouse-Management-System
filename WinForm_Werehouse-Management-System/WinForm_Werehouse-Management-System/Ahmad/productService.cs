using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    using System.Collections.Generic;
    using System.Linq;
    using WinForm_Werehouse_Management_System.Omar;

    public static partial class ProductService
    {
        private static readonly JsonFileStorage<Product> storage =
              new JsonFileStorage<Product>("Products.txt");


        public static Product GetProductByName(string Name)
        {
            var products = storage.Load();

            return products
                .FirstOrDefault(p => p.Name == Name);
        }

        public static List<Product> GetAllProducts()
        {
            return storage.Load();
        }
        public static void ReduceQuantity(int Id, int qty)
        {

            var products = storage.Load();

            var product = products.FirstOrDefault(p => p.Id == Id);

            if (product == null)
                throw new Exception("المنتج غير موجود");

            if (qty > product.Stock)
                throw new Exception("الكمية المطلوبة أكبر من المخزون المتوفر");

            product.Stock -= qty;

            // حفظ التغييرات في الملف
            storage.Save(products);

        }
        
        public static void IncreaseQuantity(int Id, int quantity)
        {
            var products = storage.Load();

            var product = products.FirstOrDefault(p => p.Id == Id);

            if (product == null)
                throw new Exception("المنتج غير موجود");

            product.Stock += quantity;

            // حفظ التغييرات في الملف
            storage.Save(products);
        }
    }
}