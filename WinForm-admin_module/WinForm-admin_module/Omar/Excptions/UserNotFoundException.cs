using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_admin_module.Excptions
{
    public class UserNotFoundException : FatherExceptions
    {
        public UserNotFoundException() : base("User not found.")
        {

        }
    }
}
