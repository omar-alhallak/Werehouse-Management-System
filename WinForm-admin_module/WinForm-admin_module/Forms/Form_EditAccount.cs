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

    public partial class Form_EditAccount : Form
    {
        private readonly Users users;

        public Form_EditAccount(Users user)
        {
            InitializeComponent();
            users = user ?? throw new ArgumentException(nameof(user));
            LoadUserToForm();
        }

        private void LoadUserToForm()
        {
            txtUserName.Text = users.UserName;
            txtFullName.Text = users.FullName;
            txtUserName.ForeColor = Color.White;
            txtFullName.ForeColor = Color.White;
            ComBoxRole.ForeColor = Color.White;

            string roleText = users.Role.ToString();

            int index = ComBoxRole.FindStringExact(roleText);
            if (index >= 0)
            {
                ComBoxRole.SelectedIndex = index;
            }
            else
                ComBoxRole.SelectedIndex = 0; 
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(lblPass.Visible==true)
            {
                lblPass.Visible = false;
            }
            else
            {
                lblPass.Visible = true;
            }
        }

        bool isHidden = true;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isHidden = !isHidden;
            PasswordHelper.ApplyLogic(txtPassword, "Password", isHidden);
            PasswordHelper.ApplyLogic(txtConfirm, "Confirm Password", isHidden);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!RegexValidator.RegexFromFullName(txtFullName.Text, out string error))
            {
                MessageBox.Show(error, "Full Name :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }

            if (ComBoxRole.SelectedIndex <= 0)
            {
                MessageBox.Show("_ يرجى أختيار صلاحيات للحساب.", "Select Role :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComBoxRole.Focus();
                return;
            }

            bool isPasswordProvided = txtPassword.Visible && !string.IsNullOrWhiteSpace(txtPassword.Text);

            if (isPasswordProvided)
            {
                if (!RegexValidator.RegexFromPassword(txtPassword.Text, out error))
                {
                    MessageBox.Show(error, "Password :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("_كلمتا السر غير متطابقتان.", "Confirm Password :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirm.Focus();
                    return;
                }
    
                var q = MessageBox.Show(
                    "هل تريد بالتأكيد تغيير كلمة السر لهذا الحساب؟",
                    "Confirm :",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (q == DialogResult.No)
                {
                    return; 
                }
                users.PasswordHash = HashingFromPassword.HashPassword(txtPassword.Text.Trim());
            }

            string roleText = ComBoxRole.SelectedItem?.ToString();
            if (Enum.TryParse(roleText, out UserRole role))
            {
                users.Role = role;
            }
            users.FullName = txtFullName.Text.Trim();

            try
            {
                var service = new UserService();
                service.UpdateUser(users);
                MessageBox.Show("_تم تعديل الحساب بنجاح.", "Save Successful :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            PasswordHelper.ApplyLogic(txtConfirm, "Confirm Password", isHidden);
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

        private void Form_EditAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void Form_EditAccount_Load(object sender, EventArgs e)
        {
            PlaceholderHelper.PlaceholderFromTextBox(txtFullName, "Full Name");
            PlaceholderHelper.PlaceholderFromComboBox(ComBoxRole, "Select Role ");
            PlaceholderHelper.PlaceholderFromTextBox(txtPassword, "Password");
            PlaceholderHelper.PlaceholderFromTextBox(txtConfirm, "Confirm Password");     
        }
    }
}