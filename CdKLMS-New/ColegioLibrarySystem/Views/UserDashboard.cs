using ColegioLibrarySystem.Service;

namespace librarymanagement.views
{
    public partial class UserDashboard : Form
    {
        public string UserRole = "User";
        private readonly BookManagement _bookManagement;
        private readonly UserManagement _userManagement;
        private readonly TransactionManagement _transactionManagement;
        public UserDashboard(BookManagement bookManagement, UserManagement userManagement, TransactionManagement transactionManagement)
        {
            InitializeComponent();
            _transactionManagement = transactionManagement;
            _bookManagement = bookManagement;
            _userManagement = userManagement;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOut(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                LoginForm login = new LoginForm(_userManagement, _bookManagement, _transactionManagement);
                login.Show();

                this.Close();


            }           
        }

        private void BrowseBooks(object sender, EventArgs e)
        {
            userBRbDashpan b = new userBRbDashpan(_bookManagement);
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void BorrowBooks(object sender, EventArgs e)
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

        private void Transactions(object sender, EventArgs e)
        {
            userTRDashpan b = new userTRDashpan();
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                LoginForm login = new LoginForm(_userManagement, _bookManagement, _transactionManagement);
                login.Show();

                this.Close();


            }
        }
    }
}
