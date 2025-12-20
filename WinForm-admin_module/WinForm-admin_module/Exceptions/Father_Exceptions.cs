using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_admin_module.Exceptions
{
    public class Father_Exceptions : Exception
    {
        public Father_Exceptions()
        {

        }

        public Father_Exceptions(string message)  : base(message)
        {

        }

        public Father_Exceptions(string message, Exception innerException)   : base(message, innerException)
        {

        }
    }
}
