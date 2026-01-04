using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Werehouse_Management_System
{
    public enum UserRole
    {
        Admin,
        Inventory,
        Sales_man
    }

    public class Permissions
    {
        public static bool AccessFromUser(UserRole Role)
        {
            return Role ==UserRole.Admin;
        }

        public static bool AccessFromInventory(UserRole Role)
        {
            return Role == UserRole.Admin || Role == UserRole.Inventory;
        }

        public static bool AccessFromSales_man(UserRole Role)
        {
            return Role == UserRole.Admin || Role == UserRole.Sales_man;
        }
    }
}