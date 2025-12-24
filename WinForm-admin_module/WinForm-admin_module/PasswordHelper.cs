using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_admin_module
{
    public static class PasswordHelper
    {
        public static void ApplyLogic(TextBox txt, string placeholder, bool isHidden)
        {
            // إذا كان فارغ لغي التشفير 
            if (string.IsNullOrEmpty(txt.Text) || txt.Text == placeholder)
            {  
                txt.PasswordChar = '\0';
                txt.ForeColor = Color.Gray;
            }
            // وإلا شفر 
            else
            {     
                txt.PasswordChar = isHidden ? '●' : '\0';
                txt.ForeColor = Color.White;
            }
        }
    }
}
