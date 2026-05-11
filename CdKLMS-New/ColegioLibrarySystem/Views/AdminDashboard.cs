using ColegioLibrarySystem.Service;
using ColegioLibrarySystem.Views;

namespace librarymanagement.views
{
    public partial class AdminDashboard : Form
    {
        private readonly BookManagement _bookManagement;
        private readonly UserManagement _userManagement;
        private readonly TransactionManagement _transactionManagement;
        public AdminDashboard(BookManagement bm, UserManagement um, TransactionManagement tm)
        {
            InitializeComponent();
            adminDashpan adp = new adminDashpan();

            adp.TopLevel = false;
            adp.Dock = DockStyle.Fill;

            contentpnl.Controls.Clear();
            contentpnl.Controls.Add(adp);

            adp.BringToFront();
            adp.Show();
            _bookManagement = bm;
            _userManagement = um;
            _transactionManagement = tm;
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
            AdminDashboard a = new AdminDashboard(_bookManagement, _userManagement, _transactionManagement);
            a.TopLevel = false;
            contentpnl.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            adminDashpanBooks b = new adminDashpanBooks(_bookManagement, _transactionManagement);
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            adminDashpanUser u = new adminDashpanUser(_userManagement, _transactionManagement);
            u.TopLevel = false;
            contentpnl.Controls.Add(u);
            u.BringToFront();
            u.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            adminDashpan u = new adminDashpan();
            u.TopLevel = false;
            contentpnl.Controls.Add(u);
            u.BringToFront();
            u.Show();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
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

