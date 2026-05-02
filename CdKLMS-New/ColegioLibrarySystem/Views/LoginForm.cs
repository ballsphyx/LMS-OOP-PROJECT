using ColegioLibrarySystem.Service;
using librarymanagement.views;
using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;

namespace librarymanagement
{
    public partial class LoginForm : Form
    {

        private readonly AppServices _services;
        public LoginForm(AppServices services)
        {
            InitializeComponent();
            this._services = services;
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
            var user = _services.UserManagement.GetUserByCredentials(textBox1.Text, textBox2.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            Session.Login(user);
            if (user.Role == Roles.Admin)
            {
                AdminDashboard ad = new AdminDashboard(_services);
                ad.Show();
                this.Hide();
            }
            else
            {
                UserDashboard userD = new UserDashboard(_services);
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


