using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Multi_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pf.fr = this;
        }

        PayForm pf = new PayForm();
        private void button1_Click(object sender, EventArgs e)
        {
            pf.Show();
        }
        SearchForm sf = new SearchForm();

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Contains("moti"))
            {
                txtNumber.Text = "140112028035";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }
    }
}
