using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace librarymanagement.views
{
    public partial class adminDashpanUser : Form
    {
        private readonly UserManagement _userManagement;
        private readonly TransactionManagement _transactionManagement;
        private List<User> _allUsers;
        private List<Student> _allStudents;
        private List<Instructor> _allInstructors;
        private int _selectedUserId = -1;
        public adminDashpanUser(UserManagement um, TransactionManagement tm)
        {
            InitializeComponent();
            _userManagement = um;
            _transactionManagement = tm;
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

        private void adminDashpanUser_Load(object sender, EventArgs e)
        {
            PillButton(btnAddUsrAD);
            PillButton(btnClearAD);
            PillButton(btnDlteUsrAD);
            PillButton(btnUpdtUsrAD);

            RoundPanel(panel5, 40);


            cmbRole.Items.AddRange(new string[]
            {
                "Student", "Instructor", "Admin"
            });

            cmbCourse.DataSource = _userManagement.GetAllCourses();
            cmbCourse.DisplayMember = "ProgramName";
            cmbCourse.ValueMember = "ProgramId";

            cmbYear.Items.AddRange(new string[]
            {
                "1st Year","2nd Year","3rd Year","4th Year"
            });


            cmbDept.DataSource = _userManagement.GetDepartments();
            cmbDept.DisplayMember = "DepartmentName";
            cmbDept.ValueMember = "DepartmentId";

            cmbRole.DataSource = Enum.GetValues(typeof(RoleEnum));
            LoadUsers();
            dgvUsrAD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbFilter.Items.AddRange(new string[] { "All", "Admin", "Instructor", "Student" });
            cmbFilter.SelectedIndex = 0;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.SelectedIndexChanged += cmbRoleFilter_SelectedIndexChanged;
            grpStudentInfo.Visible = false;
            grpInstructorInfo.Visible = false;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddUser(object sender, EventArgs e)
        {
            string name = txtNameAD.Text.Trim();
            string user = txtUsrnmAD.Text.Trim();
            string pass = txtPassAD.Text.Trim();
            var selectedRole = (RoleEnum)cmbRole.SelectedItem;
            var year = cmbYear.Text;
            var dept = Convert.ToInt32(cmbDept.SelectedValue);
            var courseid = Convert.ToInt32(cmbCourse.SelectedValue);

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
                    _userManagement.RegisterStudent(user, pass, name, courseid, year);
                }
                MessageBox.Show("User Added");
                LoadUsers();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Failed to Register User: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            string name = txtNameAD.Text.Trim();
            string user = txtUsrnmAD.Text.Trim();
            string pass = txtPassAD.Text.Trim();
            var selectedRole = (RoleEnum)cmbRole.SelectedItem;
            var year = cmbYear.Text;
            var dept = Convert.ToInt32(cmbDept.SelectedValue);
            var courseId = Convert.ToInt32(cmbCourse.SelectedValue);
            var id = _selectedUserId;
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
                    _userManagement.UpdateAdmin(user, pass, name, id);
                }
                else if (selectedRole == RoleEnum.Instructor)
                {
                    _userManagement.UpdateInstructor(user, pass, name, dept, id);
                }
                else
                {
                    _userManagement.UpdateStudent(name, user, pass, year, id, courseId);
                }
                MessageBox.Show("User Updated");
                LoadUsers();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Failed to Update User: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            string name = txtNameAD.Text.Trim();
            string user = txtUsrnmAD.Text.Trim();
            string pass = txtPassAD.Text.Trim();
            var selectedRole = (RoleEnum)cmbRole.SelectedItem;
            var year = cmbYear.Text;
            var dept = Convert.ToInt32(cmbDept.SelectedValue);
            var courseId = Convert.ToInt32(cmbCourse.SelectedValue);
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
            if (_selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delet");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _userManagement.DeleteUser(user);
                    MessageBox.Show("Deleted User");
                    LoadUsers();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Failed to Delete User: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearFields();
        }
        private void ClearFields()
        {
            txtUsrnmAD.Clear();
            txtPassAD.Clear();
            txtNameAD.Clear();
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
        private void LoadUsers()
        {
            try
            {
                _allUsers = _userManagement.GetAllUsers(); // store the full list
                _allStudents = _userManagement.GetAllStudents();
                _allInstructors = _userManagement.GetAllInstructors();
                dgvUsrAD.DataSource = _allUsers;
                dgvUsrAD.Columns["password"].Visible = false;
                dgvUsrAD.Columns["RoleId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to show users " + ex.Message);
            }
        }
        private void cmbRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbFilter.SelectedItem.ToString();

            if (selected == "Student")
            {
                dgvUsrAD.DataSource = _allStudents.ToList();
                dgvUsrAD.Columns["Program"].Visible = true;
                dgvUsrAD.Columns["YearLevel"].Visible = true;
                if (dgvUsrAD.Columns["Department"] != null)
                    dgvUsrAD.Columns["Department"].Visible = false;
                dgvUsrAD.Columns["User"].Visible = false;
                if (dgvUsrAD.Columns["program"] != null)
                    dgvUsrAD.Columns["program"].Visible = false;
                if (dgvUsrAD.Columns["programID"] != null)
                    dgvUsrAD.Columns["programID"].Visible = false;

            }
            else if (selected == "Instructor")
            {
                dgvUsrAD.DataSource = _allInstructors.ToList();
                dgvUsrAD.Columns["DepartmentName"].Visible = true;
                if (dgvUsrAD.Columns["Program"] != null)
                    dgvUsrAD.Columns["Program"].Visible = false;
                if (dgvUsrAD.Columns["YearLevel"] != null)
                    dgvUsrAD.Columns["YearLevel"].Visible = false;
                if (dgvUsrAD.Columns["Department"] != null)
                    dgvUsrAD.Columns["Department"].Visible = false;
                dgvUsrAD.Columns["User"].Visible = false;
            }
            else if (selected == "Admin")
            {
                dgvUsrAD.DataSource = _allUsers
                                      .Where(u => u.Role.RoleName == RoleEnum.Admin)
                                      .ToList();
            }
            else
            {
                dgvUsrAD.DataSource = _allUsers.ToList();
            }
        }

        private void dgvUsrAD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsrAD.SelectedRows.Count == 0) return;

            var item = dgvUsrAD.SelectedRows[0].DataBoundItem;

            User selected = null;
            Student student = null;
            Instructor instructor = null;

            if (item is Student s)
            {
                student = s;
                selected = s.User;
            }
            else if (item is Instructor i)
            {
                instructor = i;
                selected = i.User;
            }
            else if (item is User u)
            {
                selected = u;
                // fetch role-specific details since item is just a User
                if (u.Role.RoleName == RoleEnum.Student)
                    student = _userManagement.GetStudentByUserId(u.UserId);
                else if (u.Role.RoleName == RoleEnum.Instructor)
                    instructor = _userManagement.GetInstructorByUserId(u.UserId);
            }

            if (selected == null) return;

            _selectedUserId = selected.UserId;
            txtNameAD.Text = selected.FullName;
            txtUsrnmAD.Text = selected.Username;
            txtPassAD.Text = selected.Password;
            cmbRole.SelectedItem = selected.Role.RoleName;

            if (student != null)
            {
                grpStudentInfo.Visible = true;
                grpInstructorInfo.Visible = false;
                cmbCourse.SelectedValue = student.ProgramID; 
                cmbYear.SelectedItem = student.YearLevel;
            }
            else if (instructor != null)
            {
                grpStudentInfo.Visible = false;
                grpInstructorInfo.Visible = true;
                cmbDept.SelectedValue = instructor.DepartmentId;
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

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
