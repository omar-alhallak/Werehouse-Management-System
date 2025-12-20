using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_admin_module
{
    public class FormUsing : ApplicationContext
    {
        public FormUsing()
        {
            var login = new Form_LogIN();
            login.LoginSucceeded += (user) =>
            {
                var dash = new Form_Dashboard(user);
                dash.FormClosed += (s, e) => Application.Exit();
                dash.Show();
                login.Close();
            };

            login.Show();

        }
    }
}
