namespace librarymanagement.views
{
    public partial class adminDashpanUser : Form
    {
        public adminDashpanUser()
        {
            InitializeComponent();
        }

        private void adminDashpanUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[]
            {
                "Student", "Instructor", "Admin"
            });

            cmbCourse.Items.AddRange(new string[]
            {
                "BSIT","BSED","BSCRIM","BSN","BSHM"
            });

            cmbYear.Items.AddRange(new string[]
            {
                "1st Year","2nd Year","3rd Year","4th Year"
            });

            cmbDept.Items.AddRange(new string[]
            {
                "Information Technology",
                "Education",
                "Nursing",
                "Criminology",
                "Hospitality Management"
            });
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
            cmbDept.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;
           
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

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enter(object sender, EventArgs e)
        {

        }

        private void txtNameAD_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtNameAD_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
