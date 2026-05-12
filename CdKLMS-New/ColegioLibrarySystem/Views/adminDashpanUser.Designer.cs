namespace librarymanagement.views
{
    partial class adminDashpanUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUsrAD = new DataGridView();
            btnDlteUsrAD = new Button();
            btnUpdtUsrAD = new Button();
            btnAddUsrAD = new Button();
            grpInstructorInfo = new Panel();
            cmbDept = new ComboBox();
            label7 = new Label();
            grpStudentInfo = new Panel();
            cmbYear = new ComboBox();
            cmbCourse = new ComboBox();
            label5 = new Label();
            cmbRole = new ComboBox();
            txtPassAD = new TextBox();
            panel3 = new Panel();
            txtUsrnmAD = new TextBox();
            panel1 = new Panel();
            txtNameAD = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnClearAD = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsrAD).BeginInit();
            grpInstructorInfo.SuspendLayout();
            grpStudentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsrAD
            // 
            dgvUsrAD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsrAD.BackgroundColor = Color.Snow;
            dgvUsrAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsrAD.GridColor = Color.FromArgb(251, 174, 210);
            dgvUsrAD.Location = new Point(12, 388);
            dgvUsrAD.Name = "dgvUsrAD";
            dgvUsrAD.RowHeadersWidth = 51;
            dgvUsrAD.Size = new Size(1029, 453);
            dgvUsrAD.TabIndex = 19;
            dgvUsrAD.SelectionChanged += dgvUsrAD_SelectionChanged;
            // 
            // btnDlteUsrAD
            // 
            btnDlteUsrAD.BackColor = Color.FromArgb(251, 174, 210);
            btnDlteUsrAD.Cursor = Cursors.Hand;
            btnDlteUsrAD.FlatAppearance.BorderSize = 0;
            btnDlteUsrAD.FlatStyle = FlatStyle.Flat;
            btnDlteUsrAD.Font = new Font("Impact", 9F);
            btnDlteUsrAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnDlteUsrAD.Location = new Point(832, 271);
            btnDlteUsrAD.Margin = new Padding(3, 4, 3, 4);
            btnDlteUsrAD.Name = "btnDlteUsrAD";
            btnDlteUsrAD.Size = new Size(86, 43);
            btnDlteUsrAD.TabIndex = 31;
            btnDlteUsrAD.Text = "DELETE";
            btnDlteUsrAD.UseVisualStyleBackColor = false;
            btnDlteUsrAD.Click += button4_Click;
            // 
            // btnUpdtUsrAD
            // 
            btnUpdtUsrAD.BackColor = Color.HotPink;
            btnUpdtUsrAD.Cursor = Cursors.Hand;
            btnUpdtUsrAD.FlatAppearance.BorderSize = 0;
            btnUpdtUsrAD.FlatStyle = FlatStyle.Flat;
            btnUpdtUsrAD.Font = new Font("Impact", 9F);
            btnUpdtUsrAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnUpdtUsrAD.Location = new Point(832, 143);
            btnUpdtUsrAD.Margin = new Padding(3, 4, 3, 4);
            btnUpdtUsrAD.Name = "btnUpdtUsrAD";
            btnUpdtUsrAD.Size = new Size(86, 43);
            btnUpdtUsrAD.TabIndex = 30;
            btnUpdtUsrAD.Text = "UPDATE";
            btnUpdtUsrAD.UseVisualStyleBackColor = false;
            btnUpdtUsrAD.Click += button3_Click;
            // 
            // btnAddUsrAD
            // 
            btnAddUsrAD.BackColor = Color.HotPink;
            btnAddUsrAD.Cursor = Cursors.Hand;
            btnAddUsrAD.FlatAppearance.BorderSize = 0;
            btnAddUsrAD.FlatStyle = FlatStyle.Flat;
            btnAddUsrAD.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUsrAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnAddUsrAD.Location = new Point(832, 84);
            btnAddUsrAD.Margin = new Padding(3, 4, 3, 4);
            btnAddUsrAD.Name = "btnAddUsrAD";
            btnAddUsrAD.Size = new Size(86, 43);
            btnAddUsrAD.TabIndex = 29;
            btnAddUsrAD.Text = "ADD";
            btnAddUsrAD.UseVisualStyleBackColor = false;
            btnAddUsrAD.Click += button1_Click;
            // 
            // grpInstructorInfo
            // 
            grpInstructorInfo.BackgroundImageLayout = ImageLayout.Center;
            grpInstructorInfo.Controls.Add(cmbDept);
            grpInstructorInfo.Controls.Add(label7);
            grpInstructorInfo.ForeColor = Color.Snow;
            grpInstructorInfo.Location = new Point(166, 287);
            grpInstructorInfo.Margin = new Padding(3, 4, 3, 4);
            grpInstructorInfo.Name = "grpInstructorInfo";
            grpInstructorInfo.Size = new Size(441, 83);
            grpInstructorInfo.TabIndex = 49;
            // 
            // cmbDept
            // 
            cmbDept.BackColor = Color.Snow;
            cmbDept.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDept.ForeColor = Color.FromArgb(228, 0, 124);
            cmbDept.FormattingEnabled = true;
            cmbDept.Location = new Point(91, 35);
            cmbDept.Margin = new Padding(3, 4, 3, 4);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(197, 29);
            cmbDept.TabIndex = 37;
            cmbDept.SelectedIndexChanged += cmbDept_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(228, 0, 124);
            label7.Location = new Point(3, 8);
            label7.Name = "label7";
            label7.Size = new Size(109, 19);
            label7.TabIndex = 34;
            label7.Text = "Department:";
            // 
            // grpStudentInfo
            // 
            grpStudentInfo.BackgroundImageLayout = ImageLayout.Center;
            grpStudentInfo.Controls.Add(cmbYear);
            grpStudentInfo.Controls.Add(cmbCourse);
            grpStudentInfo.Controls.Add(label5);
            grpStudentInfo.ForeColor = Color.Snow;
            grpStudentInfo.Location = new Point(166, 287);
            grpStudentInfo.Margin = new Padding(3, 4, 3, 4);
            grpStudentInfo.Name = "grpStudentInfo";
            grpStudentInfo.Size = new Size(359, 83);
            grpStudentInfo.TabIndex = 48;
            // 
            // cmbYear
            // 
            cmbYear.BackColor = Color.Snow;
            cmbYear.ForeColor = Color.FromArgb(228, 0, 124);
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(249, 33);
            cmbYear.Margin = new Padding(3, 4, 3, 4);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(89, 28);
            cmbYear.TabIndex = 39;
            // 
            // cmbCourse
            // 
            cmbCourse.BackColor = Color.Snow;
            cmbCourse.ForeColor = Color.FromArgb(228, 0, 124);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(91, 33);
            cmbCourse.Margin = new Padding(3, 4, 3, 4);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(123, 28);
            cmbCourse.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(228, 0, 124);
            label5.Location = new Point(3, 8);
            label5.Name = "label5";
            label5.Size = new Size(120, 19);
            label5.TabIndex = 34;
            label5.Text = "Course & Year:";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.Snow;
            cmbRole.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.ForeColor = Color.FromArgb(228, 0, 124);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(274, 248);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(197, 29);
            cmbRole.TabIndex = 47;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // txtPassAD
            // 
            txtPassAD.BackColor = Color.Snow;
            txtPassAD.BorderStyle = BorderStyle.None;
            txtPassAD.Font = new Font("Century Gothic", 9.75F);
            txtPassAD.ForeColor = Color.FromArgb(228, 0, 124);
            txtPassAD.Location = new Point(283, 196);
            txtPassAD.Margin = new Padding(3, 4, 3, 4);
            txtPassAD.Name = "txtPassAD";
            txtPassAD.Size = new Size(277, 20);
            txtPassAD.TabIndex = 45;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.ForeColor = Color.FromArgb(212, 155, 255);
            panel3.Location = new Point(274, 220);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 1);
            panel3.TabIndex = 46;
            // 
            // txtUsrnmAD
            // 
            txtUsrnmAD.BackColor = Color.Snow;
            txtUsrnmAD.BorderStyle = BorderStyle.None;
            txtUsrnmAD.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsrnmAD.ForeColor = Color.FromArgb(228, 0, 124);
            txtUsrnmAD.Location = new Point(283, 143);
            txtUsrnmAD.Margin = new Padding(3, 4, 3, 4);
            txtUsrnmAD.Name = "txtUsrnmAD";
            txtUsrnmAD.Size = new Size(413, 23);
            txtUsrnmAD.TabIndex = 43;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = Color.FromArgb(212, 155, 255);
            panel1.Location = new Point(274, 171);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1);
            panel1.TabIndex = 44;
            // 
            // txtNameAD
            // 
            txtNameAD.BackColor = Color.Snow;
            txtNameAD.BorderStyle = BorderStyle.None;
            txtNameAD.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameAD.ForeColor = Color.FromArgb(228, 0, 124);
            txtNameAD.Location = new Point(283, 96);
            txtNameAD.Margin = new Padding(3, 4, 3, 4);
            txtNameAD.Name = "txtNameAD";
            txtNameAD.Size = new Size(413, 23);
            txtNameAD.TabIndex = 41;
            txtNameAD.DoubleClick += Enter;
            txtNameAD.Enter += txtNameAD_Enter;
            txtNameAD.Leave += txtNameAD_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = Color.FromArgb(212, 155, 255);
            panel2.Location = new Point(274, 124);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 1);
            panel2.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(228, 0, 124);
            label1.Location = new Point(166, 243);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 40;
            label1.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(228, 0, 124);
            label3.Location = new Point(166, 199);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 38;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(228, 0, 124);
            label2.Location = new Point(166, 148);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 39;
            label2.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(228, 0, 124);
            label4.Location = new Point(166, 100);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 37;
            label4.Text = "Name:";
            // 
            // btnClearAD
            // 
            btnClearAD.BackColor = Color.HotPink;
            btnClearAD.Cursor = Cursors.Hand;
            btnClearAD.FlatAppearance.BorderSize = 0;
            btnClearAD.FlatStyle = FlatStyle.Flat;
            btnClearAD.Font = new Font("Impact", 9F);
            btnClearAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnClearAD.Location = new Point(832, 202);
            btnClearAD.Margin = new Padding(3, 4, 3, 4);
            btnClearAD.Name = "btnClearAD";
            btnClearAD.Size = new Size(86, 43);
            btnClearAD.TabIndex = 50;
            btnClearAD.Text = "CLEAR";
            btnClearAD.UseVisualStyleBackColor = false;
            btnClearAD.Click += btnClearAD_Click;
            // 
            // adminDashpanUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1053, 864);
            Controls.Add(btnClearAD);
            Controls.Add(grpInstructorInfo);
            Controls.Add(grpStudentInfo);
            Controls.Add(cmbRole);
            Controls.Add(txtPassAD);
            Controls.Add(panel3);
            Controls.Add(txtUsrnmAD);
            Controls.Add(panel1);
            Controls.Add(txtNameAD);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnDlteUsrAD);
            Controls.Add(btnUpdtUsrAD);
            Controls.Add(btnAddUsrAD);
            Controls.Add(dgvUsrAD);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "adminDashpanUser";
            Text = "adminDashpanUser";
            Load += adminDashpanUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsrAD).EndInit();
            grpInstructorInfo.ResumeLayout(false);
            grpInstructorInfo.PerformLayout();
            grpStudentInfo.ResumeLayout(false);
            grpStudentInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvUsrAD;
        private Button btnDlteUsrAD;
        private Button btnUpdtUsrAD;
        private Button btnAddUsrAD;
        private Panel grpInstructorInfo;
        private ComboBox cmbDept;
        private Label label7;
        private Panel grpStudentInfo;
        private ComboBox cmbYear;
        private ComboBox cmbCourse;
        private Label label5;
        private ComboBox cmbRole;
        private TextBox txtPassAD;
        private Panel panel3;
        private TextBox txtUsrnmAD;
        private Panel panel1;
        private TextBox txtNameAD;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnClearAD;
    }
}