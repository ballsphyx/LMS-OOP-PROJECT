using ColegioLibrarySystem.Service;

namespace librarymanagement.views
{
    public partial class adminDashpanUser : Form
    {
        private readonly UserManagement _userManagement;
        private readonly TransactionManagement _transactionManagement;
        public adminDashpanUser(UserManagement um, TransactionManagement tm)
        {
            InitializeComponent();
            _userManagement = um;
            _transactionManagement = tm;
        }

        private void adminDashpanUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Instructor");

            cmbCourse.Items.Add("BSIT");
            cmbCourse.Items.Add("BSED");
            cmbCourse.Items.Add("BSCRIM");
            cmbCourse.Items.Add("BSN");
            cmbCourse.Items.Add("BSHM");

            cmbYear.Items.Add("1st Year");
            cmbYear.Items.Add("2nd Year");
            cmbYear.Items.Add("3rd Year");
            cmbYear.Items.Add("4th Year");


            cmbDept.Items.Add("Information Technology");
            cmbDept.Items.Add("Education");
            cmbDept.Items.Add("Nursing");
            cmbDept.Items.Add("Criminology");
            cmbDept.Items.Add("Hospital Management");

            grpStudentInfo.Visible = false;
            grpInstructorInfo.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Added");
            ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Updated");
            ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Deleted");
            ClearFields();
        }
        private void ClearFields()
        {
            txtUsrnmAD.Clear();
            txtPassAD.Clear();
            txtNameAD.Clear();
            cmbYear.SelectedIndex = -1;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Student")
            {
                grpStudentInfo.Visible = true;
                grpInstructorInfo.Visible = false;
            }
            else if (cmbRole.Text == "Instructor")
            {
                grpStudentInfo.Visible = false;
                grpInstructorInfo.Visible = true;
            }
            else
            {
                grpStudentInfo.Visible = false;
                grpInstructorInfo.Visible = false;
            }
        }
    }
}
