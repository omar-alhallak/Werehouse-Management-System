using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System.Excptions
{
    public class UserNameAlreadyExiste : Exception
    {
        public UserNameAlreadyExiste() : base("_أسم المستخدم موجود مسبقاً.\n_يرجى أختيار أسم آخر.") { }
    }
}