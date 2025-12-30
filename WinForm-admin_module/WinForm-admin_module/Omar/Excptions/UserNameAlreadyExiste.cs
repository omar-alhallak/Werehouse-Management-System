using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_admin_module.Excptions
{
    public class UserNameAlreadyExiste : FatherExceptions
    {
        public UserNameAlreadyExiste() : base("_أسم المستخدم موجود مسبقاً.\n_يرجى أختيار أسم آخر.") { }
    }
}
