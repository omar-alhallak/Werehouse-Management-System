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
            new Product { Name = "سكر", Price = 5000, Cost = 4000, QuantityInStock = 100 },
            new Product { Name = "رز", Price = 10000, Cost = 8000, QuantityInStock = 80 },
            new Product { Name = "زيت", Price = 12000, Cost = 9500, QuantityInStock = 60 },
            new Product { Name = "طحين", Price = 4500, Cost = 3500, QuantityInStock = 90 }
        };

        public static Product GetProductByName(string name)
        {
            return products
                .FirstOrDefault(p => p.Name == name);
        }

        public static List<Product> GetAllProducts()
        {
            return products;
        }
        public static void ReduceQuantity(string name, int qut)
        {
            Product produc = products.FirstOrDefault(p => p.Name == name);


            if (qut > produc.QuantityInStock)
            {
                throw new Exception("الكمية المطلوبة أكبر من المخزون المتوفر");
            }

            produc.QuantityInStock -= qut;

        }
        public static void IncreaseQuantity(string name, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Name == name);

            if (product == null)
                throw new Exception("المنتج غير موجود");

            product.QuantityInStock += quantity;
        }
    }
}
