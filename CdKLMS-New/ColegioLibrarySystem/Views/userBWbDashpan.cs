using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace librarymanagement.views
{
    public partial class userBKbDashpan : Form
    {
        string role;
        public userBKbDashpan(string userRole)
        {
            InitializeComponent();
            role = userRole;
        }

        private void userBKbDashpan_Load(object sender, EventArgs e)
        {
            if (role == "Student")
            {
                txtQntyBrw.Text = "1";
                txtQntyBrw.Enabled = false;
            }
            else
            {
                txtQntyBrw.Enabled = true;
            }
        }

        private void btnBrw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrowed Successfully!");
           
        }
    }
}
