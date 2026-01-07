using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm_Werehouse_Management_System.Excptions;

namespace WinForm_Werehouse_Management_System.Omar.Excptions
{
    public class AcountDisableException : Exception
    {
        public AcountDisableException() : base("_ هذا الحساب معطل.")  { }
    }
}