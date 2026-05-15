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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userBRbDashpan));
            dtaGrdVBR = new DataGridView();
            cmbCtgryBR = new ComboBox();
            label1 = new Label();
            panel4 = new Panel();
            txtSearchBR = new TextBox();
            btnSearchBR = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtaGrdVBR).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtaGrdVBR
            // 
            dtaGrdVBR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtaGrdVBR.BackgroundColor = Color.Snow;
            dtaGrdVBR.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.HotPink;
            dataGridViewCellStyle3.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtaGrdVBR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtaGrdVBR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.HotPink;
            dataGridViewCellStyle4.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = Color.Snow;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtaGrdVBR.DefaultCellStyle = dataGridViewCellStyle4;
            dtaGrdVBR.GridColor = Color.FromArgb(251, 174, 210);
            dtaGrdVBR.Location = new Point(12, 246);
            dtaGrdVBR.Name = "dtaGrdVBR";
            dtaGrdVBR.RowHeadersWidth = 51;
            dtaGrdVBR.Size = new Size(876, 434);
            dtaGrdVBR.TabIndex = 23;
            // 
            // cmbCtgryBR
            // 
            cmbCtgryBR.BackColor = Color.Snow;
            cmbCtgryBR.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCtgryBR.ForeColor = Color.HotPink;
            cmbCtgryBR.FormattingEnabled = true;
            cmbCtgryBR.Location = new Point(373, 142);
            cmbCtgryBR.Name = "cmbCtgryBR";
            cmbCtgryBR.Size = new Size(161, 25);
            cmbCtgryBR.TabIndex = 27;
            cmbCtgryBR.SelectedIndexChanged += cmbCtgryBR_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(247, 81, 117);
            label1.Location = new Point(280, 142);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 26;
            label1.Text = "Category";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtSearchBR);
            panel4.ForeColor = Color.FromArgb(57, 88, 134);
            panel4.Location = new Point(373, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 32);
            panel4.TabIndex = 25;
            // 
            // txtSearchBR
            // 
            txtSearchBR.BackColor = Color.Snow;
            txtSearchBR.BorderStyle = BorderStyle.None;
            txtSearchBR.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBR.ForeColor = Color.FromArgb(228, 0, 124);
            txtSearchBR.Location = new Point(12, 8);
            txtSearchBR.Name = "txtSearchBR";
            txtSearchBR.Size = new Size(221, 16);
            txtSearchBR.TabIndex = 3;
            // 
            // btnSearchBR
            // 
            btnSearchBR.BackColor = Color.FromArgb(247, 81, 117);
            btnSearchBR.FlatStyle = FlatStyle.Flat;
            btnSearchBR.ForeColor = Color.Snow;
            btnSearchBR.Image = (Image)resources.GetObject("btnSearchBR.Image");
            btnSearchBR.Location = new Point(628, 89);
            btnSearchBR.Name = "btnSearchBR";
            btnSearchBR.Size = new Size(46, 32);
            btnSearchBR.TabIndex = 24;
            btnSearchBR.UseVisualStyleBackColor = false;
            btnSearchBR.Click += btnSearchBR_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(247, 81, 117);
            label3.Location = new Point(280, 96);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 24;
            label3.Text = "Search:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(394, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 28;
            label2.Text = "Book List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(6, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 477);
            panel1.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(247, 81, 117);
            label6.Location = new Point(396, 9);
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
            ClientSize = new Size(900, 692);
            Controls.Add(btnSearchBR);
            Controls.Add(label6);
            Controls.Add(cmbCtgryBR);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(dtaGrdVBR);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userBRbDashpan";
            Text = "userBRbDashpan";
            Load += userBRbDashpan_Load;
            ((System.ComponentModel.ISupportInitialize)dtaGrdVBR).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label6;
    }
}