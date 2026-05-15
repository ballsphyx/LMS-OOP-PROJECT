namespace librarymanagement.views
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            contentpnl = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            btnUser = new Button();
            label2 = new Label();
            btnBooks = new Button();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnTrsnc = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            contentpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contentpnl
            // 
            contentpnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentpnl.BackColor = Color.Snow;
            contentpnl.Controls.Add(pictureBox2);
            contentpnl.Controls.Add(pictureBox3);
            contentpnl.Controls.Add(label4);
            contentpnl.Location = new Point(242, 35);
            contentpnl.Name = "contentpnl";
            contentpnl.Size = new Size(900, 692);
            contentpnl.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(520, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 215);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(162, 231);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(228, 215);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(247, 81, 117);
            label4.Location = new Point(373, 153);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 15;
            label4.Text = "Welcome, User!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 81, 117);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBooks);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnTrsnc);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 739);
            panel1.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(3, 675);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(230, 59);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUser
            // 
            btnUser.BackgroundImageLayout = ImageLayout.None;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.White;
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.Location = new Point(3, 369);
            btnUser.Name = "btnUser";
            btnUser.RightToLeft = RightToLeft.Yes;
            btnUser.Size = new Size(230, 59);
            btnUser.TabIndex = 3;
            btnUser.Text = "Borrow Book";
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += BorrowBooks;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 233);
            label2.Name = "label2";
            label2.Size = new Size(187, 16);
            label2.TabIndex = 5;
            label2.Text = "──── ⋆Do something ⋆ ──── ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBooks
            // 
            btnBooks.BackgroundImageLayout = ImageLayout.None;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.White;
            btnBooks.Image = (Image)resources.GetObject("btnBooks.Image");
            btnBooks.Location = new Point(3, 304);
            btnBooks.Name = "btnBooks";
            btnBooks.RightToLeft = RightToLeft.Yes;
            btnBooks.Size = new Size(230, 59);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "Browse Books";
            btnBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += BrowseBooks;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 81, 117);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 210);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(90, 152);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 3;
            label1.Text = "User ✿";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnTrsnc
            // 
            btnTrsnc.BackgroundImageLayout = ImageLayout.None;
            btnTrsnc.FlatAppearance.BorderSize = 0;
            btnTrsnc.FlatStyle = FlatStyle.Flat;
            btnTrsnc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrsnc.ForeColor = Color.White;
            btnTrsnc.Image = (Image)resources.GetObject("btnTrsnc.Image");
            btnTrsnc.Location = new Point(3, 434);
            btnTrsnc.Name = "btnTrsnc";
            btnTrsnc.RightToLeft = RightToLeft.Yes;
            btnTrsnc.Size = new Size(230, 59);
            btnTrsnc.TabIndex = 6;
            btnTrsnc.Text = "Transactions";
            btnTrsnc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrsnc.UseVisualStyleBackColor = true;
            btnTrsnc.Click += Transactions;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1089, -3);
            button2.Name = "button2";
            button2.Size = new Size(52, 38);
            button2.TabIndex = 23;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1032, -4);
            button1.Name = "button1";
            button1.Size = new Size(52, 39);
            button1.TabIndex = 24;
            button1.Text = "_";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(249, 11);
            label3.Name = "label3";
            label3.Size = new Size(229, 19);
            label3.TabIndex = 22;
            label3.Text = "Library Management System";
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 81, 117);
            ClientSize = new Size(1154, 739);
            Controls.Add(button2);
            Controls.Add(contentpnl);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            contentpnl.ResumeLayout(false);
            contentpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel contentpnl;
        private Panel panel1;
        private Label label2;
        private Button btnUser;
        private Button btnBooks;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnTrsnc;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label3;
    }
}