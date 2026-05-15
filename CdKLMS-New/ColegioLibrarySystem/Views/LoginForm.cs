using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using librarymanagement.views;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Drawing2D;
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
        private void PillButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();

            int radius = btn.Height;

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 90, 180);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 180);
            path.CloseFigure();

            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.Cursor = Cursors.Hand;
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
            User current = _userManagement.GetUserByCredentials(textBox1.Text, textBox2.Text);
            if (current == null)
            {
                MessageBox.Show("User not found");
                textBox1.Clear();
                textBox2.Clear();
                return;
            }
            Session.Login(current);
            if (current.Role.RoleName == RoleEnum.Admin)
            {
                AdminDashboard ad = new AdminDashboard(_bookManagement, _userManagement, _transactionManagement);
                ad.Show();
                this.Hide();
            }
            else
            {
                //MessageBox.Show("IsInstructor: " + Session.IsInstructor.ToString() + "\nIsStudent: " + Session.IsStudent.ToString());
                UserDashboard userD = new UserDashboard(_bookManagement, _userManagement, _transactionManagement);
                userD.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RoundFormCorners(50);

            PillButton(button1);
            PillButton(button2);

        }
    }
}


