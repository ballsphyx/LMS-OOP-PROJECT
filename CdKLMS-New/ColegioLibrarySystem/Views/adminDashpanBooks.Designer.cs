namespace librarymanagement.views
{
    partial class adminDashpanBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashpanBooks));
            dgvBooksAD = new DataGridView();
            btnAddAD = new Button();
            btnDltAD = new Button();
            btnUpdtAD = new Button();
            btnClearAD = new Button();
            txtCopies = new TextBox();
            label7 = new Label();
            cmbCategory = new ComboBox();
            txtISBN = new TextBox();
            panel6 = new Panel();
            label6 = new Label();
            txtAvail = new TextBox();
            panel5 = new Panel();
            panel4 = new Panel();
            txtAuthAD = new TextBox();
            panel1 = new Panel();
            txtTitleAD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            dateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBooksAD).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvBooksAD
            // 
            dgvBooksAD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooksAD.BackgroundColor = Color.Snow;
            dgvBooksAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooksAD.GridColor = Color.FromArgb(138, 174, 224);
            dgvBooksAD.Location = new Point(4, 279);
            dgvBooksAD.Name = "dgvBooksAD";
            dgvBooksAD.Size = new Size(914, 364);
            dgvBooksAD.TabIndex = 10;
            dgvBooksAD.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddAD
            // 
            btnAddAD.BackColor = Color.HotPink;
            btnAddAD.Cursor = Cursors.Hand;
            btnAddAD.FlatAppearance.BorderSize = 0;
            btnAddAD.FlatStyle = FlatStyle.Flat;
            btnAddAD.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnAddAD.Location = new Point(728, 63);
            btnAddAD.Name = "btnAddAD";
            btnAddAD.Size = new Size(75, 32);
            btnAddAD.TabIndex = 11;
            btnAddAD.Text = "ADD";
            btnAddAD.UseVisualStyleBackColor = false;
            btnAddAD.Click += button1_Click;
            // 
            // btnDltAD
            // 
            btnDltAD.BackColor = Color.FromArgb(251, 174, 210);
            btnDltAD.Cursor = Cursors.Hand;
            btnDltAD.FlatAppearance.BorderSize = 0;
            btnDltAD.FlatStyle = FlatStyle.Flat;
            btnDltAD.Font = new Font("Impact", 9F);
            btnDltAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnDltAD.Location = new Point(728, 214);
            btnDltAD.Name = "btnDltAD";
            btnDltAD.Size = new Size(75, 32);
            btnDltAD.TabIndex = 12;
            btnDltAD.Text = "DELETE";
            btnDltAD.UseVisualStyleBackColor = false;
            btnDltAD.Click += button2_Click;
            // 
            // btnUpdtAD
            // 
            btnUpdtAD.BackColor = Color.HotPink;
            btnUpdtAD.Cursor = Cursors.Hand;
            btnUpdtAD.FlatAppearance.BorderSize = 0;
            btnUpdtAD.FlatStyle = FlatStyle.Flat;
            btnUpdtAD.Font = new Font("Impact", 9F);
            btnUpdtAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnUpdtAD.Location = new Point(728, 105);
            btnUpdtAD.Name = "btnUpdtAD";
            btnUpdtAD.Size = new Size(75, 32);
            btnUpdtAD.TabIndex = 13;
            btnUpdtAD.Text = "UPDATE";
            btnUpdtAD.UseVisualStyleBackColor = false;
            btnUpdtAD.Click += button3_Click;
            // 
            // btnClearAD
            // 
            btnClearAD.BackColor = Color.HotPink;
            btnClearAD.Cursor = Cursors.Hand;
            btnClearAD.FlatAppearance.BorderSize = 0;
            btnClearAD.FlatStyle = FlatStyle.Flat;
            btnClearAD.Font = new Font("Impact", 9F);
            btnClearAD.ForeColor = Color.FromArgb(240, 243, 250);
            btnClearAD.Location = new Point(728, 148);
            btnClearAD.Name = "btnClearAD";
            btnClearAD.Size = new Size(75, 32);
            btnClearAD.TabIndex = 14;
            btnClearAD.Text = "CLEAR";
            btnClearAD.UseVisualStyleBackColor = false;
            btnClearAD.Click += button4_Click;
            // 
            // txtCopies
            // 
            txtCopies.BackColor = Color.Snow;
            txtCopies.BorderStyle = BorderStyle.None;
            txtCopies.Font = new Font("Century Gothic", 9.75F);
            txtCopies.ForeColor = Color.FromArgb(228, 0, 124);
            txtCopies.Location = new Point(564, 224);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(107, 16);
            txtCopies.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(228, 0, 124);
            label7.Location = new Point(110, 209);
            label7.Name = "label7";
            label7.Size = new Size(118, 16);
            label7.TabIndex = 55;
            label7.Text = "Publication Date:";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(255, 206, 233);
            cmbCategory.Font = new Font("Century Gothic", 9.75F);
            cmbCategory.ForeColor = Color.FromArgb(228, 0, 124);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(201, 159);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(197, 25);
            cmbCategory.TabIndex = 54;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.Snow;
            txtISBN.BorderStyle = BorderStyle.None;
            txtISBN.Font = new Font("Century Gothic", 9.75F);
            txtISBN.ForeColor = Color.FromArgb(228, 0, 124);
            txtISBN.Location = new Point(521, 158);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(107, 16);
            txtISBN.TabIndex = 52;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.ForeColor = Color.FromArgb(212, 155, 255);
            panel6.Location = new Point(512, 176);
            panel6.Name = "panel6";
            panel6.Size = new Size(123, 2);
            panel6.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(228, 0, 124);
            label6.Location = new Point(466, 162);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 51;
            label6.Text = "ISBN:";
            // 
            // txtAvail
            // 
            txtAvail.BackColor = Color.Snow;
            txtAvail.BorderStyle = BorderStyle.None;
            txtAvail.Font = new Font("Century Gothic", 9.75F);
            txtAvail.ForeColor = Color.FromArgb(228, 0, 124);
            txtAvail.Location = new Point(564, 191);
            txtAvail.Name = "txtAvail";
            txtAvail.Size = new Size(107, 16);
            txtAvail.TabIndex = 49;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.ForeColor = Color.FromArgb(212, 155, 255);
            panel5.Location = new Point(555, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(123, 2);
            panel5.TabIndex = 50;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.ForeColor = Color.FromArgb(212, 155, 255);
            panel4.Location = new Point(555, 242);
            panel4.Name = "panel4";
            panel4.Size = new Size(123, 2);
            panel4.TabIndex = 48;
            // 
            // txtAuthAD
            // 
            txtAuthAD.BackColor = Color.Snow;
            txtAuthAD.BorderStyle = BorderStyle.None;
            txtAuthAD.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthAD.ForeColor = Color.FromArgb(228, 0, 124);
            txtAuthAD.Location = new Point(210, 107);
            txtAuthAD.Name = "txtAuthAD";
            txtAuthAD.Size = new Size(370, 19);
            txtAuthAD.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = Color.FromArgb(212, 155, 255);
            panel1.Location = new Point(201, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 2);
            panel1.TabIndex = 47;
            // 
            // txtTitleAD
            // 
            txtTitleAD.BackColor = Color.Snow;
            txtTitleAD.BorderStyle = BorderStyle.None;
            txtTitleAD.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitleAD.ForeColor = Color.FromArgb(228, 0, 124);
            txtTitleAD.Location = new Point(210, 72);
            txtTitleAD.Name = "txtTitleAD";
            txtTitleAD.Size = new Size(370, 19);
            txtTitleAD.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(228, 0, 124);
            label5.Location = new Point(464, 195);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 44;
            label5.Text = "Available:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(228, 0, 124);
            label4.Location = new Point(464, 228);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 43;
            label4.Text = "Copies:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(228, 0, 124);
            label3.Location = new Point(110, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 16);
            label3.TabIndex = 42;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(228, 0, 124);
            label2.Location = new Point(110, 114);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 45;
            label2.Text = "Author:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = Color.FromArgb(228, 0, 124);
            panel2.Location = new Point(201, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 2);
            panel2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(228, 0, 124);
            label1.Location = new Point(110, 79);
            label1.Name = "label1";
            label1.Size = new Size(37, 16);
            label1.TabIndex = 39;
            label1.Text = "Title:";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(dateTimePicker);
            panel3.Location = new Point(190, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 30);
            panel3.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(164, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.CalendarForeColor = Color.HotPink;
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(255, 206, 233);
            dateTimePicker.CalendarTitleBackColor = Color.HotPink;
            dateTimePicker.CalendarTitleForeColor = Color.HotPink;
            dateTimePicker.CalendarTrailingForeColor = Color.HotPink;
            dateTimePicker.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(11, 5);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(146, 22);
            dateTimePicker.TabIndex = 36;
            // 
            // adminDashpanBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(921, 648);
            Controls.Add(txtCopies);
            Controls.Add(label7);
            Controls.Add(cmbCategory);
            Controls.Add(txtISBN);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(txtAvail);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(txtAuthAD);
            Controls.Add(panel1);
            Controls.Add(txtTitleAD);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(btnClearAD);
            Controls.Add(btnUpdtAD);
            Controls.Add(btnDltAD);
            Controls.Add(btnAddAD);
            Controls.Add(dgvBooksAD);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDashpanBooks";
            Text = "adminDashpan";
            Load += adminDashpan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooksAD).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void adminDashpan_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        #endregion
        private DataGridView dgvBooksAD;
        private Button btnAddAD;
        private Button btnDltAD;
        private Button btnUpdtAD;
        private Button btnClearAD;
        private TextBox txtCopies;
        private Label label7;
        private ComboBox cmbCategory;
        private TextBox txtISBN;
        private Panel panel6;
        private Label label6;
        private TextBox txtAvail;
        private Panel panel5;
        private Panel panel4;
        private TextBox txtAuthAD;
        private Panel panel1;
        private TextBox txtTitleAD;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker;
    }
}