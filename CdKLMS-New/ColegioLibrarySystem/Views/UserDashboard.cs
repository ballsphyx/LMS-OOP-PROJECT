using ColegioLibrarySystem.Service;
using System.Drawing.Drawing2D;

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
        private void RoundFormCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
        private void RoundPanel(Panel pnl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(pnl.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(pnl.Width - radius, pnl.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, pnl.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();

            pnl.Region = new Region(path);
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
            SelectButton(btnBooks);
        }

        private void BorrowBooks(object sender, EventArgs e)
        {
            userBKbDashpan b = new userBKbDashpan(_transactionManagement, _bookManagement);
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
            SelectButton(btnbrbook);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Transactions(object sender, EventArgs e)
        {
            userTRDashpan b = new userTRDashpan(_transactionManagement);
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
            SelectButton(btnTrsnc);
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

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            RoundFormCorners(30);
            RoundFormCorners(30);
            RoundPanel(contentpnl, 30);

            RoundButton(btnbrbook, 10);
            RoundButton(btnTrsnc, 10);
            RoundButton(btnBooks, 10);
            RoundButton(btnLogout, 10);
        }
        private Button selectedButton = null;

        private void SelectButton(Button btn)
        {
            // reset previous button
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(163, 54, 77);
            }

            // highlight current button
            selectedButton = btn;
            selectedButton.BackColor = Color.FromArgb(247, 81, 117);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
