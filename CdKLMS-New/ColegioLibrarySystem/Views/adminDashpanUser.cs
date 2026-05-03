using ColegioLibrarySystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace librarymanagement.views
{
    public partial class adminDashpanUser : Form
    {
        private readonly UserManagement _userManagement;
        public adminDashpanUser(UserManagement userManagement)
        {
            InitializeComponent();
            this._userManagement = userManagement;
        }

        private void adminDashpanUser_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Added");
            ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Deleted");
        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }
    }
}
