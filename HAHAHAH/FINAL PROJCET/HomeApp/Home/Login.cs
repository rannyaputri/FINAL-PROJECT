using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Selling Sell = new Selling();
            Sell.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Admin Name and Password");
            }
            else if (UidTb.Text == "Admin" && PasswordTb.Text == "Pass")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Admin Name or Password");
            }
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
