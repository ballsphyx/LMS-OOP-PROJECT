using ColegioLibrarySystem.Service;
using librarymanagement.views;

namespace librarymanagement
{
    public partial class LoginForm : Form
    {
        private readonly BookManagement _bookManagement;
        private readonly UserManagement _userManagement;
        private readonly TransactionManagement _transactionManagement;
        public LoginForm(UserManagement userManagement, BookManagement bookManagement, TransactionManagement transactionManagement )
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
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminDashboard ad = new AdminDashboard(_bookManagement, _userManagement, _transactionManagement);
                ad.Show();
                this.Hide();
            }
            else if (textBox1.Text == "user" && textBox2.Text == "user")
            {
                UserDashboard userD = new UserDashboard("User");
                userD.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


