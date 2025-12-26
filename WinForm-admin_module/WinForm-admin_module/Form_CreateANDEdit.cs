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

namespace WinForm_admin_module
{
    public partial class Form_CreateANDEdit : Form
    {
        public Form_CreateANDEdit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool isHidden = true;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isHidden = !isHidden;
            PasswordHelper.ApplyLogic(txtPassword, "Password", isHidden);
            PasswordHelper.ApplyLogic(txtConfirm, "Confirm Password", isHidden);
            if(isHidden)
            {
                btnShowPassword.BackgroundImage =Properties.Resources.تنزيل;
            }
            else
            {
                btnShowPassword.BackgroundImage = Properties.Resources.تنزيل__1_;
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

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm Password")
            {
                    txtConfirm.Text = "";
                    txtConfirm.ForeColor = Color.White; 
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Confirm Password";
                txtConfirm.ForeColor = Color.Gray;
            }
        }

        private void Form_CreateANDEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
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
       
        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Full Name")
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = Color.White;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Full Name";
                txtFullName.ForeColor = Color.Gray;
            }
        }

        private readonly UserService userserver1=new UserService();
        private void btnCreate_Edit_Click(object sender, EventArgs e)
        {
            if(!RegexValidator.RegexFromUserName(txtUserName.Text,out string error))
            {
                MessageBox.Show(error,"UserName :",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (!RegexValidator.RegexFromFullName(txtFullName.Text, out error))
            {
                MessageBox.Show(error, "Full Name :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }
            if (!RegexValidator.RegexFromPassword(txtPassword.Text, out error))
            {
                MessageBox.Show(error, "Password :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if(txtPassword.Text!=txtConfirm.Text)
            {
                MessageBox.Show("- كلمتا السر غير متطابقتان.", "Confirm Password :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.Focus();
                return;
            }
            if (ComBoxRole.SelectedIndex == 0)
            {
                MessageBox.Show("- يرجى أختيار صلاحيات للحساب.", "Select Role :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComBoxRole.Focus();
                return;
            }
            string selectedText = ComBoxRole.SelectedItem.ToString();

            // تحويل النص إلى enum
            UserRole selectedRole =
                (UserRole)Enum.Parse(typeof(UserRole), selectedText);

            // إنشاء المستخدم
            var user = new Users
            {
                UserName = txtUserName.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Role = selectedRole
            };

            string plainPassword = txtPassword.Text;
   
            try
            {
                // للتحقق من عملية الإضافة كاملة
                userserver1.AddUser(user, plainPassword);
                
                MessageBox.Show( $"_تم إنشاء الحساب بنجاح.\nرقم الحساب (ID): {user.Id}",   "Save Successful:", MessageBoxButtons.OK,   MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (UserNameAlreadyExiste Error) 
            {
                MessageBox.Show(Error.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) 
            {
                MessageBox.Show("حدث خطأ غير متوقع يرجى المحاولة لاحقاً.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtConfirm.Enabled = false;
                return;
            }
            if (RegexValidator.RegexFromPassword(txtPassword.Text, out string error))
            {
                txtConfirm.Enabled = true;
            }
            else
            {
                txtConfirm.Text = "Confirm Password";
                txtConfirm.UseSystemPasswordChar = false;
                txtConfirm.Enabled = false;
            }
            PasswordHelper.ApplyLogic(txtPassword, "Password", isHidden);
        }

        private void ComBoxRole_Enter(object sender, EventArgs e)
        {
            if (ComBoxRole.SelectedIndex == 0)
            {
                ComBoxRole.ForeColor = Color.White;
            }    
        }

        private void ComBoxRole_Leave(object sender, EventArgs e)
        {
            if (ComBoxRole.SelectedIndex == 0)
            { 
                ComBoxRole.ForeColor = Color.Gray;
            }
        }

        private void Form_CreateANDEdit_Load(object sender, EventArgs e)
        {
            ComBoxRole.SelectedIndex = 0;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            PasswordHelper.ApplyLogic(txtConfirm, "Confirm Password", isHidden);
        }
    }
}
