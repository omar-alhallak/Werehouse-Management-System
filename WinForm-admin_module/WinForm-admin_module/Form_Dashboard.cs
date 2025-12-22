using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_admin_module
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }
  
        private void btnMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccountMang_Click(object sender, EventArgs e)
        {
            Form_AccountManagement AccountManagement = new Form_AccountManagement();
            AccountManagement.Show();
            this.Close(); 
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            if (Program.LogedINUser != null)
            {
                labName.Text= "Welcoom " + Program.LogedINUser.FullName + " (Admin)";
            }
        }

        private void Form_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
