using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_admin_module
{
    internal class Users
    {
        public int Id { get; set; }

        public string UserName { get; set; }

       // public string Password { get; set; }

        public string FullName { get; set; }

       // public UserRole Role { set; get; }

        public bool IsActive { get; set; } // لتفعيل و تعطيل الحساب

        public Users()
        {
            IsActive = true;
        }

    }
}
