using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Werehouse_Management_System.Excptions;
using WinForm_Werehouse_Management_System.Omar.Excptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm_Werehouse_Management_System
{
    public partial class Form_LogIN : Form
    { 
        public Form_LogIN()
        {
            InitializeComponent();          
        }

        private void btnSign_IN_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = new User_AuthService();
                User loggedUser = auth.Login(txtUserName.Text, txtPassword.Text);

                Program.LogedINUser = loggedUser;

                Form nextForm = null;

                switch (loggedUser.Role)
                {
                    case UserRole.Admin:
                        nextForm = new Form_DashboardAdmin();
                        break;

                    case UserRole.Sales_man:
                        nextForm = new Form_DashboardSalse();
                        break;

                    case UserRole.Inventory:
                        nextForm = new InventoryDashboardForm();
                        break;
                }

                nextForm.Show();
                this.Close();
            }
            catch (UserNameORPasswordEmptyException error)
            {
                MessageBox.Show(error.Message , "Waring :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UserNotFoundException)
            {
                MessageBox.Show("_ اسم المستخدم أو كلمة المرور غير صحيحة.","Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AcountDisableException error)
            {
                MessageBox.Show(error.Message, "Account Disabled :", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Form_LogIN_Load(object sender, EventArgs e)
        {
            PlaceholderHelper.PlaceholderFromTextBox(txtUserName, "UserName");
            PlaceholderHelper.PlaceholderFromTextBox(txtPassword, "Password");
        }
    }
}