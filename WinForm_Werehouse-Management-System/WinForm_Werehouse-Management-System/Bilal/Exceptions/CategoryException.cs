using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    public class CategoryException : Exception
    {
        public CategoryException(string message) : base(message) { }
    }
}
