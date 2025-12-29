using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_admin_module
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      
         public static Users LogedINUser;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_LogIN LogIn=new Form_LogIN();
            LogIn.Show();
            Application.Run();
        }
    }
}