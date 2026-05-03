using ColegioLibrarySystem.Service;
using librarymanagement.views;
using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;

namespace librarymanagement
{
    public partial class LoginForm : Form
    {
        private readonly UserManagement userManagement;
        private readonly BorrowManagement borrowManagement;
        private readonly BookManagement bookManagement;
        public LoginForm(UserManagement userManagement, BorrowManagement borrowManagement, BookManagement bookManagement)
        {
            InitializeComponent();
            this.userManagement = userManagement;
            this.borrowManagement = borrowManagement;
            this.bookManagement = bookManagement;
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

        private void LoginButton(object sender, EventArgs e)
        {
            var user = userManagement.GetUserByCredentials(textBox1.Text, textBox2.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }

            Session.Login(user);

            if (user.Role == Roles.Admin)
            {
                AdminDashboard ad = new AdminDashboard(userManagement, bookManagement, borrowManagement);
                ad.Show();
                this.Hide();
            }
            else
            {
                UserDashboard userD = new UserDashboard(user.FullName);
                userD.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


