using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm_admin_module
{
    public partial class Form_LogIN : Form
    {
        public Form_LogIN()
        {
            InitializeComponent();          
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "UserName")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.White;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "UserName";         
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";   
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.White;
            }
        }

        private void btnSign_IN_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            
            if (txtPassword.UseSystemPasswordChar)
            {     
                txtPassword.UseSystemPasswordChar = false;
                btnShowPassword.BackgroundImage = Properties.Resources.تنزيل__1_;
            
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPassword.BackgroundImage = Properties.Resources.تنزيل;
               
            }
        }

        private void btnMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
