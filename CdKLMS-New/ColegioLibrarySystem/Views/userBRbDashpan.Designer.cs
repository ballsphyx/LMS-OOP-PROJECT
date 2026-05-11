namespace librarymanagement.views
{
    partial class userBRbDashpan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userBRbDashpan));
            dtaGrdVBR = new DataGridView();
            cmbCtgryBR = new ComboBox();
            label1 = new Label();
            panel4 = new Panel();
            btnSearchBR = new Button();
            txtSearchBR = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtaGrdVBR).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dtaGrdVBR
            // 
            dtaGrdVBR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtaGrdVBR.BackgroundColor = Color.Snow;
            dtaGrdVBR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtaGrdVBR.GridColor = Color.FromArgb(251, 174, 210);
            dtaGrdVBR.Location = new Point(12, 217);
            dtaGrdVBR.Name = "dtaGrdVBR";
            dtaGrdVBR.Size = new Size(883, 409);
            dtaGrdVBR.TabIndex = 23;
            // 
            // cmbCtgryBR
            // 
            cmbCtgryBR.BackColor = Color.Snow;
            cmbCtgryBR.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCtgryBR.ForeColor = Color.HotPink;
            cmbCtgryBR.FormattingEnabled = true;
            cmbCtgryBR.Location = new Point(396, 116);
            cmbCtgryBR.Name = "cmbCtgryBR";
            cmbCtgryBR.Size = new Size(161, 25);
            cmbCtgryBR.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(228, 0, 124);
            label1.Location = new Point(303, 116);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 26;
            label1.Text = "Category";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnSearchBR);
            panel4.Controls.Add(txtSearchBR);
            panel4.ForeColor = Color.FromArgb(57, 88, 134);
            panel4.Location = new Point(396, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 32);
            panel4.TabIndex = 25;
            // 
            // btnSearchBR
            // 
            btnSearchBR.BackColor = Color.FromArgb(251, 174, 210);
            btnSearchBR.FlatStyle = FlatStyle.Flat;
            btnSearchBR.ForeColor = Color.Snow;
            btnSearchBR.Image = (Image)resources.GetObject("btnSearchBR.Image");
            btnSearchBR.Location = new Point(231, -1);
            btnSearchBR.Name = "btnSearchBR";
            btnSearchBR.Size = new Size(51, 32);
            btnSearchBR.TabIndex = 24;
            btnSearchBR.UseVisualStyleBackColor = false;
            // 
            // txtSearchBR
            // 
            txtSearchBR.BackColor = Color.Snow;
            txtSearchBR.BorderStyle = BorderStyle.None;
            txtSearchBR.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBR.ForeColor = Color.FromArgb(228, 0, 124);
            txtSearchBR.Location = new Point(12, 8);
            txtSearchBR.Name = "txtSearchBR";
            txtSearchBR.Size = new Size(209, 16);
            txtSearchBR.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(228, 0, 124);
            label3.Location = new Point(303, 70);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 24;
            label3.Text = "Search:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(228, 0, 124);
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 28;
            label2.Text = "Book List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(251, 174, 210);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(94, 16);
            label6.TabIndex = 52;
            label6.Text = "Browse Books";
            // 
            // userBRbDashpan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(907, 638);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(cmbCtgryBR);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(dtaGrdVBR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userBRbDashpan";
            Text = "userBRbDashpan";
            ((System.ComponentModel.ISupportInitialize)dtaGrdVBR).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtaGrdVBR;
        private ComboBox cmbCtgryBR;
        private Label label1;
        private Panel panel4;
        private Button btnSearchBR;
        private TextBox txtSearchBR;
        private Label label3;
        private Label label2;
        private Label label6;
    }
}