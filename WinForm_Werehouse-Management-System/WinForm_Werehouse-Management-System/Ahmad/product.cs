using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    using System.Collections.Generic;
    using System.Linq;

    public static class ProductService
    {
        private static List<Product> products = new List<Product>()
        {
            new Product { Id=1, Name = "سكر", Price = 5000, Cost = 4000, QuantityInStock = 100 },
            new Product { Id=2,Name = "رز", Price = 10000, Cost = 8000, QuantityInStock = 80 },
            new Product { Id=3, Name = "زيت", Price = 12000, Cost = 9500, QuantityInStock = 60 },
            new Product { Id=4, Name = "طحين", Price = 4500, Cost = 3500, QuantityInStock = 90 }
        };

        public static Product GetProductByName(string Name)
        {
            return products
                .FirstOrDefault(p => p.Name == Name);
        }

        public static List<Product> GetAllProducts()
        {
            return products;
        }
        public static void ReduceQuantity(int Id, int qut)
        {
            Product produc = products.FirstOrDefault(p => p.Id == Id);


            if (qut > produc.QuantityInStock)
            {
                throw new Exception("الكمية المطلوبة أكبر من المخزون المتوفر");
            }

            produc.QuantityInStock -= qut;

        }
        public static void IncreaseQuantity(int Id, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Id == Id);

            if (product == null)
                throw new Exception("المنتج غير موجود");

            product.QuantityInStock += quantity;
        }
    }
}
