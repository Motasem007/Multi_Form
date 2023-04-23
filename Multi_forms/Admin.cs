using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        Form1 fr = new Form1();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Contains("admin") || txtPassword.Text.Contains("admin"))
            {
                MessageBox.Show("Welcome");
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Try again", "User name or Password is wrong");
                txtUser.Focus();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
