using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Service;
using librarymanagement.views;
using Microsoft.VisualBasic.ApplicationServices;
using User = ColegioLibrarySystem.Models.User;

namespace librarymanagement
{
    public partial class LoginForm : Form
    {
        private readonly BookManagement _bookManagement;
        private readonly UserManagement _userManagement;
        private readonly TransactionManagement _transactionManagement;
        public LoginForm(UserManagement userManagement, BookManagement bookManagement, TransactionManagement transactionManagement)
        {
            InitializeComponent();
            _userManagement = userManagement;
            _transactionManagement = transactionManagement;
            _bookManagement = bookManagement;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User current = _userManagement.GetUserByCredentials(textBox1.Text, textBox2.Text);
                Session.Login(current);
                if (current.Role.RoleName == RoleEnum.Admin)
                {
                    AdminDashboard ad = new AdminDashboard(_bookManagement, _userManagement, _transactionManagement);
                    ad.Show();
                }
                else
                {
                    MessageBox.Show("IsInstructor: " + Session.IsInstructor.ToString() + "\nIsStudent: " + Session.IsStudent.ToString());
                    UserDashboard userD = new UserDashboard(_bookManagement, _userManagement, _transactionManagement);
                    userD.Show();
                }
                    this.Hide();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Login Failure: " + ex.Message, "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


