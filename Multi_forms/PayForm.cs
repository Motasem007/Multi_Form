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
    public partial class PayForm : Form
    {
        SearchForm sf = new SearchForm();
        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();
        }

        public Form1 fr;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("...پرداخت انجام شد", "عملیات");
            fr.listWork.Items.Add("پرداخت شهریه: " + sf.textBox1.Text + " با کد دانشجویی " + textBox1.Text + " به مبلغ " + textBox2.Text + " تومان");
            textBox1.Text = "";
            textBox2.Text = "";
            sf.textBox1.Text = "";
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

    }
}
