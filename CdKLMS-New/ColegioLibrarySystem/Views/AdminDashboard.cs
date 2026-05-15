using ColegioLibrarySystem.Service;
using ColegioLibrarySystem.Views;
using System.Drawing.Drawing2D;

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
            adminDashpanBooks b = new adminDashpanBooks(_bookManagement);
            b.TopLevel = false;
            contentpnl.Controls.Add(b);
            b.BringToFront();
            b.Show();
            SelectButton(btnBooks);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            adminDashpanUser u = new adminDashpanUser(_userManagement, _transactionManagement);
            u.TopLevel = false;
            contentpnl.Controls.Add(u);
            u.BringToFront();
            u.Show();
            SelectButton(btnUser);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            adminDashpan u = new adminDashpan();
            u.TopLevel = false;
            contentpnl.Controls.Add(u);
            u.BringToFront();
            u.Show();
            SelectButton(btnDashboard);
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            RoundFormCorners(30);
            RoundFormCorners(30);

            RoundButton(btnDashboard, 20);
            RoundButton(btnBooks, 20);
            RoundButton(btnUser, 20);
            RoundButton(btnlogout, 20);

            RoundPanel(contentpnl, 30);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrsncAD_Click(object sender, EventArgs e)
        {
            adminTrscDashpan u = new adminTrscDashpan(_transactionManagement);
            u.TopLevel = false;
            contentpnl.Controls.Add(u);
            u.BringToFront();
            u.Show();
            SelectButton(btnTrsncAD);
        }
    }
}

