using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Declare
            string username, password, cpassword;

            //Input
            username = txtUsername.Text;
            password = txtPassword.Text;
            cpassword = txtCPassword.Text;

            // Process
            if (username == "admin" && password == "12345" && cpassword == "12345")
            {
                // both password and confirm password match
                MessageBox.Show("Log in successfully!", "YYAYYYY");
            }
            else if (password != cpassword)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Error");
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtCPassword.Clear();
        }
    }
}
