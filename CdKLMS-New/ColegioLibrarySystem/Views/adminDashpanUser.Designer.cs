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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textPass = new TextBox();
            panel3 = new Panel();
            textUserName = new TextBox();
            panel1 = new Panel();
            textName = new TextBox();
            panel2 = new Panel();
            Delete = new Button();
            Update = new Button();
            Add = new Button();
            comboRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(228, 0, 124);
            label3.Location = new Point(111, 183);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(228, 0, 124);
            label2.Location = new Point(111, 132);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 9;
            label2.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(228, 0, 124);
            label4.Location = new Point(111, 84);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 6;
            label4.Text = "Name:";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(228, 0, 124);
            label1.Location = new Point(111, 227);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 11;
            label1.Text = "Role:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(138, 174, 224);
            dataGridView1.Location = new Point(14, 297);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 551);
            dataGridView1.TabIndex = 19;
            // 
            // textPass
            // 
            textPass.BackColor = Color.Snow;
            textPass.BorderStyle = BorderStyle.None;
            textPass.Font = new Font("Century Gothic", 9.75F);
            textPass.ForeColor = Color.FromArgb(228, 0, 124);
            textPass.Location = new Point(211, 180);
            textPass.Margin = new Padding(3, 4, 3, 4);
            textPass.Name = "textPass";
            textPass.Size = new Size(277, 20);
            textPass.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.ForeColor = Color.FromArgb(212, 155, 255);
            panel3.Location = new Point(202, 204);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 2);
            panel3.TabIndex = 26;
            // 
            // textUserName
            // 
            textUserName.BackColor = Color.Snow;
            textUserName.BorderStyle = BorderStyle.None;
            textUserName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUserName.ForeColor = Color.FromArgb(228, 0, 124);
            textUserName.Location = new Point(211, 127);
            textUserName.Margin = new Padding(3, 4, 3, 4);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(413, 23);
            textUserName.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = Color.FromArgb(212, 155, 255);
            panel1.Location = new Point(202, 155);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 2);
            panel1.TabIndex = 24;
            // 
            // textName
            // 
            textName.BackColor = Color.Snow;
            textName.BorderStyle = BorderStyle.None;
            textName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.ForeColor = Color.FromArgb(228, 0, 124);
            textName.Location = new Point(211, 80);
            textName.Margin = new Padding(3, 4, 3, 4);
            textName.Name = "textName";
            textName.Size = new Size(413, 23);
            textName.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = Color.FromArgb(212, 155, 255);
            panel2.Location = new Point(202, 108);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 2);
            panel2.TabIndex = 22;
            // 
            // Delete
            // 
            Delete.BackColor = Color.HotPink;
            Delete.Cursor = Cursors.Hand;
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Impact", 9F);
            Delete.ForeColor = Color.FromArgb(240, 243, 250);
            Delete.Location = new Point(832, 220);
            Delete.Margin = new Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new Size(86, 43);
            Delete.TabIndex = 31;
            Delete.Text = "DELETE";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += button4_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.HotPink;
            Update.Cursor = Cursors.Hand;
            Update.FlatAppearance.BorderSize = 0;
            Update.FlatStyle = FlatStyle.Flat;
            Update.Font = new Font("Impact", 9F);
            Update.ForeColor = Color.FromArgb(240, 243, 250);
            Update.Location = new Point(832, 151);
            Update.Margin = new Padding(3, 4, 3, 4);
            Update.Name = "Update";
            Update.Size = new Size(86, 43);
            Update.TabIndex = 30;
            Update.Text = "UPDATE";
            Update.UseVisualStyleBackColor = false;
            Update.Click += button3_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.HotPink;
            Add.Cursor = Cursors.Hand;
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.FromArgb(240, 243, 250);
            Add.Location = new Point(832, 84);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(86, 43);
            Add.TabIndex = 29;
            Add.Text = "ADD";
            Add.UseVisualStyleBackColor = false;
            Add.Click += AddUser;
            // 
            // comboRole
            // 
            comboRole.BackColor = Color.FromArgb(251, 174, 210);
            comboRole.ForeColor = Color.FromArgb(228, 0, 124);
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(202, 232);
            comboRole.Margin = new Padding(3, 4, 3, 4);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(225, 28);
            comboRole.TabIndex = 32;
            // 
            // adminDashpanUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1080, 864);
            Controls.Add(comboRole);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(textPass);
            Controls.Add(panel3);
            Controls.Add(textUserName);
            Controls.Add(panel1);
            Controls.Add(textName);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "adminDashpanUser";
            Text = "adminDashpanUser";
            Load += adminDashpanUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textPass;
        private Panel panel3;
        private TextBox textUserName;
        private Panel panel1;
        private TextBox textName;
        private Panel panel2;
        private Button Delete;
        private Button Update;
        private Button Add;
        private ComboBox comboRole;
    }
}