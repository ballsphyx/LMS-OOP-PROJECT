using librarymanagement.views;

namespace librarymanagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
        {            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminDashboard ad = new AdminDashboard();
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


