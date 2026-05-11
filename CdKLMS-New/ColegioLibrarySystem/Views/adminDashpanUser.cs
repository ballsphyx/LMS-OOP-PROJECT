using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;

namespace librarymanagement.views
{
    public partial class adminDashpanUser : Form
    {
        private readonly UserManagement _userManagement;
        private readonly TransactionManagement _transactionManagement;
        private int _selectedUserId = -1;
        public adminDashpanUser(UserManagement um, TransactionManagement tm)
        {
            InitializeComponent();
            _userManagement = um;
            _transactionManagement = tm;
        }

        private void adminDashpanUser_Load(object sender, EventArgs e)
        {
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
            cmbRole.DataSource = Enum.GetValues(typeof(RoleEnum));
            LoadUsers();
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
            string name = txtNameAD.Text.Trim();
            string user = txtUsrnmAD.Text.Trim();
            string pass = txtPassAD.Text.Trim();
            var selectedRole = (RoleEnum)cmbRole.SelectedItem;
            var year = cmbYear.Text;
            var dept = cmbDept.Text;
            var course = cmbCourse.Text;

            string[] reqfields = { name, user, pass };
            foreach (var fields in reqfields)
            {
                if (String.IsNullOrEmpty(fields))
                {
                    MessageBox.Show("Please fill in all required fields");
                    ClearFields();
                    return;
                }
            }
            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Name must not contain any digits");
                ClearFields();
                return;
            }
            try
            {
                if (selectedRole == RoleEnum.Admin)
                {
                    _userManagement.RegisterAdmin(user, pass, name);
                }
                else if (selectedRole == RoleEnum.Instructor)
                {
                    _userManagement.RegisterInstructor(user, pass, name, dept);
                }
                else if (selectedRole == RoleEnum.Student)
                {
                    _userManagement.RegisterStudent(user, pass, name, course, year);
                }
                MessageBox.Show("User Added");
                LoadUsers();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Service Layer Error: " + ex.Message, "ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void LoadUsers()
        {
            try
            {
                List<User> users = _userManagement.GetAllUsers();
                dgvUsrAD.DataSource = users;
                dgvUsrAD.Columns["password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to show users " + ex.Message);
            }
        }

        private void dgvUsrAD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsrAD.SelectedRows.Count == 0) return;

            User selected = (User)dgvUsrAD.SelectedRows[0].DataBoundItem;
            _selectedUserId = selected.UserId;

            // fill basic fields
            txtNameAD.Text = selected.FullName;
            txtUsrnmAD.Text = selected.Username;
            txtPassAD.Text = selected.Password;
            cmbRole.SelectedItem = selected.Role.RoleName; // set role dropdown

            // show/hide role-specific fields and fill them
            if (selected.Role.RoleName == RoleEnum.Student)
            {
                grpStudentInfo.Visible = true;
                grpInstructorInfo.Visible = false;

                // get student details
                Student student = _userManagement.GetStudentByUserId(selected.UserId);
                if (student != null)
                {
                    cmbCourse.SelectedItem = student.Program;
                    cmbYear.SelectedItem = student.YearLevel; // match your combobox items
                }
            }
            else if (selected.Role.RoleName == RoleEnum.Instructor)
            {
                grpStudentInfo.Visible = false;
                grpInstructorInfo.Visible = true;

                // get instructor details
                Instructor instructor = _userManagement.GetInstructorByUserId(selected.UserId);
                if (instructor != null)
                {
                    cmbDept.SelectedItem = instructor.Department;
                }
            }
            else
            {
                grpStudentInfo.Visible = false;
                grpInstructorInfo.Visible = false;
            }
        }

        private void btnClearAD_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
