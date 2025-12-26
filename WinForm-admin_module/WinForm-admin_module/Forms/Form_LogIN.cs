using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_admin_module.Excptions;
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
                txtPassword.Text = "Password";   
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
            }
        }

        private void btnSign_IN_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = new User_AuthService(new UserStorage());
                Users LogINUser = auth.Login(txtUserName.Text, txtPassword.Text);
                Program.LogedINUser = LogINUser;
                var dashboard = new Form_Dashboard();
                dashboard.Show();
                this.Close(); 
            }
            catch (RegexException ex)
            {
                MessageBox.Show(ex.Message, "Warning :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UserNotFoundException)
            {
                MessageBox.Show("الحساب غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool isHidden = true;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isHidden = !isHidden;
            PasswordHelper.ApplyLogic(txtPassword, "Password", isHidden);
            if (isHidden)
            {
                btnShowPassword.BackgroundImage = Properties.Resources.تنزيل;
            }
            else
            {
                btnShowPassword.BackgroundImage = Properties.Resources.تنزيل__1_;
            }
        }

        private void btnMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_LogIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.Count==0)
            {
                Application.Exit();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordHelper.ApplyLogic(txtPassword, "Password", isHidden);
        }
    }
}
