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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            var show = new Form_Dashboard();
            show.Show();
        }

        private void Form_AccountManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
