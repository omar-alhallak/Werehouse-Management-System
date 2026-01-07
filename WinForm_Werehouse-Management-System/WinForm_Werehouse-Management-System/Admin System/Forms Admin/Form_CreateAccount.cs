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

namespace WinForm_Werehouse_Management_System
{
    public partial class Form_CreateAccount : Form
    {
        private readonly UserService userserver1 = new UserService();

        public Form_CreateAccount()
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

        private void Form_CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!RegexValidator.RegexFromUserName(txtUserName.Text, out string error))
            {
                MessageBox.Show(error, "UserName :", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtPassword.Text != txtConfirm.Text)
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
            var user = new User
            {
                UserName = txtUserName.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Role = selectedRole
            };

            try
            {
                // للتحقق من عملية الإضافة كاملة  
                userserver1.AddUser(user, txtPassword.Text);

                MessageBox.Show($"_تم إنشاء الحساب بنجاح.\nرقم الحساب (ID): {user.Id}", "Save Successful:", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Form_CreateAccount_Load(object sender, EventArgs e)
        {
            PlaceholderHelper.PlaceholderFromTextBox(txtUserName, "UserName");
            PlaceholderHelper.PlaceholderFromTextBox(txtFullName, "Full Name");
            PlaceholderHelper.PlaceholderFromTextBox(txtPassword, "Password");
            PlaceholderHelper.PlaceholderFromTextBox(txtConfirm, "Confirm Password");
            PlaceholderHelper.PlaceholderFromComboBox(ComBoxRole, "Select Role ");
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            PasswordHelper.ApplyLogic(txtConfirm, "Confirm Password", isHidden);
        }
    }
}