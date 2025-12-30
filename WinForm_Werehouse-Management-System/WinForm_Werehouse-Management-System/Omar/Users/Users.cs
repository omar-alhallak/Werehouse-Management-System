using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    public class Users
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        public UserRole Role { set; get; }

        public bool IsActive { get; set; }

        public Users()
        {
            IsActive = true;
        }
    }
}