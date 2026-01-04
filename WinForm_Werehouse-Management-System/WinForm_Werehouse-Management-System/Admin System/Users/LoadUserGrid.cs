using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    public static class LoadUserGrid
    {
        public static List<object> BuildGridData(List<Users> users)
        {
            return users.Select(u => new
            {
                u.Id,
                u.UserName,
                u.FullName,
                Role = u.Role.ToString(),
                Status = u.IsActive ? "Active" : "Disabled"
            }).Cast<object>().ToList();
        }
    }
}