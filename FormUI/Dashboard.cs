using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;
            string userCountry = txtCountry.Text;
            if (userName.Equals(""))
            {
               MessageBox.Show("Please Enter Your Name");
            } else
            if (userEmail.Equals(""))
            {
                MessageBox.Show("Please Enter Your Email");
            } else
            if (userPassword.Equals(""))
            {
                MessageBox.Show("Please Enter Your Password");
            }else
            if (userCountry.Equals(""))
            {
                MessageBox.Show("Please select Your Country");
            }
            else
            {

            }
        }
    }
}
