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
            btnlogout = new Button();
            btnDashboard = new Button();
            label2 = new Label();
            btnUser = new Button();
            btnBooks = new Button();
            panel3 = new Panel();
            pnlContent = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            contentpnl = new Panel();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(20, 18, 51);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnBooks);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 739);
            panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.FromArgb(251, 174, 210);
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
            btnDashboard.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(251, 174, 210);
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
            label2.ForeColor = Color.FromArgb(251, 174, 210);
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
            btnUser.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.FromArgb(251, 174, 210);
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
            btnBooks.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.FromArgb(251, 174, 210);
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 18, 51);
            panel3.Controls.Add(pnlContent);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 197);
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
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(77, 147);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(20, 18, 51);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(202, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 33);
            panel2.TabIndex = 1;
            // 
            // contentpnl
            // 
            contentpnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentpnl.Location = new Point(230, 87);
            contentpnl.Name = "contentpnl";
            contentpnl.Size = new Size(921, 648);
            contentpnl.TabIndex = 2;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(227, 33);
            button4.Name = "button4";
            button4.Size = new Size(72, 56);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Snow;
            button5.Location = new Point(906, 1);
            button5.Name = "button5";
            button5.Size = new Size(42, 30);
            button5.TabIndex = 8;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(20, 18, 51);
            label3.Location = new Point(323, 52);
            label3.Name = "label3";
            label3.Size = new Size(172, 19);
            label3.TabIndex = 0;
            label3.Text = "Library Management";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1154, 739);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(contentpnl);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Panel contentpnl;
        private Button button4;
        private Button button5;
        private Label label3;
        private Button btnBooks;
        private Button btnlogout;
        private Button btnDashboard;
    }
}