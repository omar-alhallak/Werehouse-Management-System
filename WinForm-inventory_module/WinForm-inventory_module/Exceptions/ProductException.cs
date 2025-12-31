using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_inventory_module.Exceptions
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base(message) { }
    }
}
