using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Werehouse_Management_System;

namespace WinForm_Werehouse_Management_System
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
            Form_LogIN LogIN = new Form_LogIN();
            LogIN.Show();
            Application.Run();
        }
    }
}
