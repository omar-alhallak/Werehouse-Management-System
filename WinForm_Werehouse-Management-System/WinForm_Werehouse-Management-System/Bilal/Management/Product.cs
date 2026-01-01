using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public decimal Cost { get; set; } = 0;
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string category,
                       decimal cost , decimal price, int stock)
        {
            Id = id;
            Name = name;
            CategoryName = category;
            Cost = cost;
            UnitPrice = price;
            Stock = stock;
        }
    }
}