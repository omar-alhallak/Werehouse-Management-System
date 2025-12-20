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
        private Users userEnter;

        public Form_Dashboard(Users user)
        {
            InitializeComponent();
            userEnter = user;
        }
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
            var show = new Form_AccountManagement();
            show.Show(); 
        }
    }
}
