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
            label3 = new Label();
            button4 = new Button();
            contentpnl = new Panel();
            panel1 = new Panel();
            button3 = new Button();
            btnUser = new Button();
            label2 = new Label();
            btnBooks = new Button();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnTrsnc = new Button();
            panel2 = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(20, 18, 51);
            label3.Location = new Point(358, 48);
            label3.Name = "label3";
            label3.Size = new Size(203, 23);
            label3.TabIndex = 8;
            label3.Text = "Library Management";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(244, 34);
            button4.Name = "button4";
            button4.Size = new Size(93, 56);
            button4.TabIndex = 11;
            button4.UseVisualStyleBackColor = true;
            // 
            // contentpnl
            // 
            contentpnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentpnl.Location = new Point(242, 96);
            contentpnl.Name = "contentpnl";
            contentpnl.Size = new Size(907, 638);
            contentpnl.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 18, 51);
            panel1.Controls.Add(button3);
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
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(251, 174, 210);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 680);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(235, 59);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnUser
            // 
            btnUser.BackgroundImageLayout = ImageLayout.None;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.FromArgb(251, 174, 210);
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.Location = new Point(3, 353);
            btnUser.Name = "btnUser";
            btnUser.RightToLeft = RightToLeft.Yes;
            btnUser.Size = new Size(230, 59);
            btnUser.TabIndex = 3;
            btnUser.Text = "Borrow Book";
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(251, 174, 210);
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
            btnBooks.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.FromArgb(251, 174, 210);
            btnBooks.Image = (Image)resources.GetObject("btnBooks.Image");
            btnBooks.Location = new Point(3, 288);
            btnBooks.Name = "btnBooks";
            btnBooks.RightToLeft = RightToLeft.Yes;
            btnBooks.Size = new Size(230, 59);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "Browse Books";
            btnBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 18, 51);
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
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(82, 152);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
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
            btnTrsnc.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrsnc.ForeColor = Color.FromArgb(251, 174, 210);
            btnTrsnc.Image = (Image)resources.GetObject("btnTrsnc.Image");
            btnTrsnc.Location = new Point(0, 418);
            btnTrsnc.Name = "btnTrsnc";
            btnTrsnc.RightToLeft = RightToLeft.Yes;
            btnTrsnc.Size = new Size(233, 59);
            btnTrsnc.TabIndex = 6;
            btnTrsnc.Text = "Transactions";
            btnTrsnc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrsnc.UseVisualStyleBackColor = true;
            btnTrsnc.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 18, 51);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(236, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 33);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1105, 34);
            button5.Name = "button5";
            button5.Size = new Size(49, 56);
            button5.TabIndex = 12;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1154, 739);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(contentpnl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            Text = "UserDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button4;
        private Panel contentpnl;
        private Panel panel1;
        private Label label2;
        private Button button3;
        private Button btnUser;
        private Button btnBooks;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnTrsnc;
        private Button button5;
    }
}