namespace librarymanagement
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(228, 0, 124);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.FromArgb(138, 174, 224);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.ForeColor = Color.FromArgb(228, 0, 124);
            textBox1.Name = "textBox1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(251, 174, 210);
            label2.Name = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.FromArgb(138, 174, 224);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.ForeColor = Color.FromArgb(228, 0, 124);
            textBox2.Name = "textBox2";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(251, 174, 210);
            label3.Name = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            resources.ApplyResources(button1, "button1");
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.FromArgb(240, 243, 250);
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LoginButton;
            // 
            // label4
            // 
            label4.AllowDrop = true;
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(228, 0, 124);
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(213, 222, 239);
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.DisabledLinkColor = Color.FromArgb(99, 142, 203);
            linkLabel1.LinkColor = Color.FromArgb(251, 174, 210);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.VisitedLinkColor = Color.FromArgb(177, 201, 239);
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(251, 174, 210);
            resources.ApplyResources(button2, "button2");
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.FromArgb(240, 243, 250);
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button button2;
    }
}
