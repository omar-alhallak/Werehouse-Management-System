using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_inventory_module.CategoryManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string Code { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string category,
                       string code, decimal price, int stock)
        {
            Id = id;
            Name = name;
            CategoryName = category;
            Code = code;
            UnitPrice = price;
            Stock = stock;
        }
    }
}
