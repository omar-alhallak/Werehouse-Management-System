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
    public partial class Form_AccountManagement : Form
    {
        private readonly UserService userserver1 = new UserService();
        public Form_AccountManagement()
        {
            InitializeComponent();
        }
        private void LoadUsers(List<Users> source = null)
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
            Form_Dashboard Dashboard = new Form_Dashboard();
            Dashboard.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new Form_CreateANDEdit())
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
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.White;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(term) || term == "Search")
            {
                lblUserNotFound.Visible = false;
                LoadUsers();
                return;
            }

            var allUsers = userserver1.GetAllUsers();

            var filtered = allUsers .Where(u =>(!string.IsNullOrEmpty(u.UserName) && u.UserName.StartsWith(term, StringComparison.OrdinalIgnoreCase))
                 || (!string.IsNullOrEmpty(u.FullName) && u.FullName.StartsWith(term, StringComparison.OrdinalIgnoreCase))).ToList();

            if(filtered.Count==0)
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
            string userName = DataGrid.CurrentRow.Cells["UserName"].Value.ToString(); 
            txtSelect.Text = userName;
        }
    }
}