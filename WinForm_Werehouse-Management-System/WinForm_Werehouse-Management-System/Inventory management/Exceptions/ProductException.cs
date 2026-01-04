using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System.Exceptions
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base(message) { }
    }
}