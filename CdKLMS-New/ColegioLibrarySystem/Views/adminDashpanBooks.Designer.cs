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
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox3 = new TextBox();
            panel3 = new Panel();
            textBox4 = new TextBox();
            panel4 = new Panel();
            textBox5 = new TextBox();
            panel5 = new Panel();
            txtISBN = new TextBox();
            panel6 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(228, 0, 124);
            label4.Location = new Point(99, 189);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 4;
            label4.Text = "Copies:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(228, 0, 124);
            label5.Location = new Point(99, 226);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 4;
            label5.Text = "Available:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(138, 174, 224);
            dataGridView1.Location = new Point(4, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(938, 364);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(240, 243, 250);
            button1.Location = new Point(728, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 11;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddBook;
            // 
            // button2
            // 
            button2.BackColor = Color.HotPink;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 9F);
            button2.ForeColor = Color.FromArgb(240, 243, 250);
            button2.Location = new Point(728, 214);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 12;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DeleteBook;
            // 
            // button3
            // 
            button3.BackColor = Color.HotPink;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 9F);
            button3.ForeColor = Color.FromArgb(240, 243, 250);
            button3.Location = new Point(728, 105);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 13;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += UpdateBook;
            // 
            // button4
            // 
            button4.BackColor = Color.HotPink;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 9F);
            button4.ForeColor = Color.FromArgb(240, 243, 250);
            button4.Location = new Point(728, 157);
            button4.Name = "button4";
            button4.Size = new Size(75, 32);
            button4.TabIndex = 14;
            button4.Text = "CLEAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += ClearField;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(228, 0, 124);
            label1.Location = new Point(99, 70);
            label1.Name = "label1";
            label1.Size = new Size(37, 16);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = Color.FromArgb(228, 0, 124);
            panel2.Location = new Point(190, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 2);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Snow;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(228, 0, 124);
            textBox2.Location = new Point(199, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 19);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(228, 0, 124);
            label2.Location = new Point(99, 105);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 4;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(228, 0, 124);
            label3.Location = new Point(99, 142);
            label3.Name = "label3";
            label3.Size = new Size(72, 16);
            label3.TabIndex = 4;
            label3.Text = "Category:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Snow;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(228, 0, 124);
            textBox1.Location = new Point(199, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 19);
            textBox1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = Color.FromArgb(212, 155, 255);
            panel1.Location = new Point(190, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 2);
            panel1.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Snow;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(228, 0, 124);
            textBox3.Location = new Point(199, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(370, 19);
            textBox3.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.ForeColor = Color.FromArgb(212, 155, 255);
            panel3.Location = new Point(190, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 2);
            panel3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Snow;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Century Gothic", 9.75F);
            textBox4.ForeColor = Color.FromArgb(228, 0, 124);
            textBox4.Location = new Point(199, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 16);
            textBox4.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.ForeColor = Color.FromArgb(212, 155, 255);
            panel4.Location = new Point(190, 203);
            panel4.Name = "panel4";
            panel4.Size = new Size(123, 2);
            panel4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Snow;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Century Gothic", 9.75F);
            textBox5.ForeColor = Color.FromArgb(228, 0, 124);
            textBox5.Location = new Point(199, 222);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(107, 16);
            textBox5.TabIndex = 19;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.ForeColor = Color.FromArgb(212, 155, 255);
            panel5.Location = new Point(190, 240);
            panel5.Name = "panel5";
            panel5.Size = new Size(123, 2);
            panel5.TabIndex = 20;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.Snow;
            txtISBN.BorderStyle = BorderStyle.None;
            txtISBN.Font = new Font("Century Gothic", 9.75F);
            txtISBN.ForeColor = Color.FromArgb(228, 0, 124);
            txtISBN.Location = new Point(462, 222);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(107, 16);
            txtISBN.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.ForeColor = Color.FromArgb(212, 155, 255);
            panel6.Location = new Point(453, 240);
            panel6.Name = "panel6";
            panel6.Size = new Size(123, 2);
            panel6.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(228, 0, 124);
            label6.Location = new Point(407, 226);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 21;
            label6.Text = "ISBN:";
            // 
            // adminDashpanBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(945, 648);
            Controls.Add(txtISBN);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(panel5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDashpanBooks";
            Text = "adminDashpan";
            Load += adminDashpan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox3;
        private Panel panel3;
        private TextBox textBox4;
        private Panel panel4;
        private TextBox textBox5;
        private Panel panel5;
        private TextBox txtISBN;
        private Panel panel6;
        private Label label6;
    }
}