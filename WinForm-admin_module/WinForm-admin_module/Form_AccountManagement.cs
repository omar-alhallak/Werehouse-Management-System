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
        public Form_AccountManagement()
        {
            InitializeComponent();
        }
 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Form_Dashboard Dashboard = new Form_Dashboard();
            Dashboard.Show();
            this.Close(); 
        }
    }
}
