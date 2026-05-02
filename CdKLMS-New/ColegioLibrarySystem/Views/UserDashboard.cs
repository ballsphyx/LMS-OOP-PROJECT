using ColegioLibrarySystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace librarymanagement.views
{
    public partial class UserDashboard : Form
    {
        private readonly AppServices _services;
        public UserDashboard(AppServices services)
        {
            _services = services;
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                LoginForm login = new LoginForm(_services);
                login.Show();

                this.Close();


            }

        }

        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            userBRbDashpan b = new userBRbDashpan();
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            userBKbDashpan b = new userBKbDashpan("User");
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userTRDashpan b = new userTRDashpan();
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }
    }
}
