using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace librarymanagement.views
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminDashboard a = new AdminDashboard();
            a.TopLevel = false;
            contentpnl.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            adminDashpanBooks b = new adminDashpanBooks();
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            adminDashpanUser u = new adminDashpanUser();
            u.TopLevel = false;
            contentpnl.Controls.Add(u);
            u.BringToFront();
            u.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
               // LoginForm login = new LoginForm();
                //login.Show();

                this.Close();


            }
        }
    }
}

