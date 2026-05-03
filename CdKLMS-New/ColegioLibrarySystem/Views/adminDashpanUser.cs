using ColegioLibrarySystem.GlobalEnums;
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
            comboRole.DataSource = Enum.GetValues(typeof(Roles));
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

        private void AddUser(object sender, EventArgs e)
        {
            var name = textName.Text.Trim();
            var username = textUserName.Text.Trim();
            var pass = textPass.Text.Trim();
            Roles role = (Roles)comboRole.SelectedItem;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Fields must not be empty or blank", "Null Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name must not contain any digits", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = _userManagement.RegisterUser(username, pass, name, role);
            if (success)
            {
                MessageBox.Show("User Added"); 
            }
            else
            {
                MessageBox.Show("An error occured during operation", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
                ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var name = textName.Text.Trim();
            var username = textUserName.Text.Trim();
            var pass = textPass.Text.Trim();
            Roles role = (Roles)comboRole.SelectedItem;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Fields must not be empty or blank", "Null Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name must not contain any digits", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ////bool success = _userManagement.UpdateUser(username, pass, name, role);//
            //if (success)
            //{
            //    MessageBox.Show("User Added");
            //}
            //else
            //{
            //    MessageBox.Show("An error occured during operation", "Error!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Deleted");
        }
        private void ClearFields()
        {
            textUserName.Clear();
            textName.Clear();
            textPass.Clear();
            comboRole.SelectedIndex = -1;
        }
    }
}
