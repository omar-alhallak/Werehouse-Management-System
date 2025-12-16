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
    public partial class Form1 : Form
    {
        public Form1()
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
           
            string username = txtUserName.Text; 
            string password = txtPassword.Text; 

            if (!WinForm_admin_module.RegexValidator.RegexFromUserName(username))
            {
                txtUserName.Focus(); 
                return;         
            }
        
            if (!WinForm_admin_module.RegexValidator.RegexFromPassword(password))
            {
                txtPassword.Focus(); 
                return;           
            }
       
            MessageBox.Show("تم التحقق من المدخلات بنجاح",
                    "نجاح التحقق", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
