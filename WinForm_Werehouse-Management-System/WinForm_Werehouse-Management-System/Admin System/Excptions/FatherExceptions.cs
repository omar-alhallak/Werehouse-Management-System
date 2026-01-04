using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System.Excptions
{
    public class FatherExceptions : Exception
    {
        public FatherExceptions() 
        { 
            
        }
        public FatherExceptions(string messege) : base(messege) 
        {

        }
        public FatherExceptions(string message,Exception innerException) :base(message,innerException)
        {

        }
    }
}
