using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Werehouse_Management_System
{
    public partial class Form_AccountManagement : Form
    {
        private readonly UserService userserver1 = new UserService();
        public Form_AccountManagement()
        {
            InitializeComponent();
        }
 
        private void LoadUsers(List<User> source = null)
        {
            var users = source ?? userserver1.GetAllUsers();

            DataGrid.DataSource = LoadUserGrid.BuildGridData(users);

            DataGrid.Columns["Id"].HeaderText = "ID";
            DataGrid.Columns["UserName"].HeaderText = "UserName";
            DataGrid.Columns["FullName"].HeaderText = "Full Name";
            DataGrid.Columns["Role"].HeaderText = "Role";
            DataGrid.Columns["Status"].HeaderText = "Status";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form_DashboardAdmin Dashboard = new Form_DashboardAdmin();
            Dashboard.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new Form_CreateAccount())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void Form_AccountManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_AccountManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
            PlaceholderHelper.PlaceholderFromTextBox(txtSearch, "Search");
        }
   
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(term) || term == "Search")
            {
                lblUserNotFound.Visible = false;
                LoadUsers();
                return;
            }

            var allUsers = userserver1.GetAllUsers();

            var filtered = allUsers.Where(u => (!string.IsNullOrEmpty(u.UserName) && u.UserName.StartsWith(term, StringComparison.OrdinalIgnoreCase))
                 || (!string.IsNullOrEmpty(u.FullName) && u.FullName.StartsWith(term, StringComparison.OrdinalIgnoreCase))).ToList();

            if (filtered.Count == 0)
            {
                lblUserNotFound.Visible = true;
                DataGrid.DataSource = null;
                return;
            }
            lblUserNotFound.Visible = false;
            LoadUsers(filtered);
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            string userName = DataGrid.CurrentRow.Cells["UserName"].Value?.ToString();

            if (string.IsNullOrEmpty(userName))
                return;

            txtSelect.ForeColor = Color.White;
            txtSelect.Text = userName; 

            var user = userserver1.FindByUsername(userName);

            if (user != null)
            {
                btnDisable.Text = user.IsActive ? "Disable" : "Enable";
                btnDisable.BackColor = user.IsActive ? Color.Maroon : Color.SeaGreen;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectedUserName = txtSelect.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedUserName) || selectedUserName == "Select Account")
            {
                MessageBox.Show("_يرجى اختيار حساب أولاً.", "Warning :",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSelect.Focus();
                return;
            }

            var user = userserver1.FindByUsername(selectedUserName);

            using (var form = new Form_EditAccount(user))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadUsers();

                    txtSelect.Text = "Select Account";
                    txtSelect.ForeColor = Color.Gray;
                }
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            string userName = txtSelect.Text?.Trim();

            if (string.IsNullOrEmpty(userName) || userName == "Select Account")
            {
                MessageBox.Show("_ يرجى اختيار حساب أولاً.", "Select Account :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var user = userserver1.FindByUsername(userName);

                if (user.IsActive)
                {
                    if (MessageBox.Show($"_ هل أنت متأكد من تعطيل هذا الحساب:\n{user.UserName} ؟","Disable Account :", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userserver1.DisableUser(user.Id);
                    }
                }
                else
                {
                    if (MessageBox.Show($"_ هل أنت متأكد من تفعيل هذا الحساب:\n{user.UserName} ؟","Enable Account :", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userserver1.EnableUser(user.Id);
                    }
                }

                LoadUsers();

                txtSelect.Text = user.UserName;
                txtSelect.ForeColor = Color.White;
            
                btnDisable.Text = user.IsActive ? "Disable" : "Enable";
            }
            catch (Exception)
            {
                MessageBox.Show("_ حدث خطأ غير متوقع.\n", "Error :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}