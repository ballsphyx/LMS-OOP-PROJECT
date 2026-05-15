namespace librarymanagement.views
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            panel3 = new Panel();
            pnlContent = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnlogout = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            btnUser = new Button();
            btnBooks = new Button();
            contentpnl = new Panel();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(247, 81, 117);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnBooks);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 739);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 81, 117);
            panel3.Controls.Add(pnlContent);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 197);
            panel3.TabIndex = 2;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.BackgroundImageLayout = ImageLayout.None;
            pnlContent.Location = new Point(230, 47);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(771, 603);
            pnlContent.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(72, 147);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 3;
            label1.Text = "Admin ✿";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.Location = new Point(3, 675);
            btnlogout.Name = "btnlogout";
            btnlogout.RightToLeft = RightToLeft.No;
            btnlogout.Size = new Size(218, 59);
            btnlogout.TabIndex = 8;
            btnlogout.Text = "Logout";
            btnlogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Snow;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(3, 203);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 15, 0);
            btnDashboard.RightToLeft = RightToLeft.Yes;
            btnDashboard.Size = new Size(218, 59);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(34, 326);
            label2.Name = "label2";
            label2.Size = new Size(153, 16);
            label2.TabIndex = 5;
            label2.Text = "──── ⋆Manage ⋆ ──── ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // btnUser
            // 
            btnUser.BackgroundImageLayout = ImageLayout.None;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.Snow;
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.Location = new Point(0, 446);
            btnUser.Name = "btnUser";
            btnUser.RightToLeft = RightToLeft.Yes;
            btnUser.Size = new Size(221, 59);
            btnUser.TabIndex = 3;
            btnUser.Text = "User";
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackgroundImageLayout = ImageLayout.None;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.Snow;
            btnBooks.Image = (Image)resources.GetObject("btnBooks.Image");
            btnBooks.Location = new Point(0, 381);
            btnBooks.Name = "btnBooks";
            btnBooks.RightToLeft = RightToLeft.Yes;
            btnBooks.Size = new Size(221, 59);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "Books";
            btnBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // contentpnl
            // 
            contentpnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentpnl.BackColor = Color.Snow;
            contentpnl.Location = new Point(224, 33);
            contentpnl.Name = "contentpnl";
            contentpnl.Size = new Size(925, 704);
            contentpnl.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1032, -6);
            button1.Name = "button1";
            button1.Size = new Size(52, 39);
            button1.TabIndex = 16;
            button1.Text = "_";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1089, -5);
            button2.Name = "button2";
            button2.Size = new Size(52, 38);
            button2.TabIndex = 15;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(237, 8);
            label3.Name = "label3";
            label3.Size = new Size(217, 18);
            label3.TabIndex = 5;
            label3.Text = "Library Management System";
            label3.Click += label3_Click_1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 81, 117);
            ClientSize = new Size(1154, 739);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(contentpnl);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnUser;
        private Label label2;
        private Panel pnlContent;
        private Panel contentpnl;
        private Button btnBooks;
        private Button btnlogout;
        private Button btnDashboard;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}