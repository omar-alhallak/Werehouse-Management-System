using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_admin_module.Excptions
{
    public class RegexException : Exception
    {
        public RegexException(string message) : base(message)
        { 

        }
    }
}
