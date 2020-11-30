using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2_Project
{
    public partial class LogIn : Form
    {
        private Admin admin;
        //private LogIn logIn;
        private customerForm customer;
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "shahd" && textBox2.Text == "shahd") {
                admin = new Admin();
                admin.Show();
            } else {

                customer = new customerForm();
                admin.Show();
            }
           // logIn.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
