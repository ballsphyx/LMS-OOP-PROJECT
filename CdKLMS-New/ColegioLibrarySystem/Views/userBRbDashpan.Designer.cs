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
            cmbCtgryBR = new ComboBox();
            label1 = new Label();
            panel4 = new Panel();
            txtSearchBR = new TextBox();
            label3 = new Label();
            dtaGrdVBR = new DataGridView();
            btnSearchBR = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtaGrdVBR).BeginInit();
            SuspendLayout();
            // 
            // cmbCtgryBR
            // 
            cmbCtgryBR.BackColor = Color.FromArgb(251, 174, 210);
            cmbCtgryBR.ForeColor = Color.FromArgb(57, 88, 134);
            cmbCtgryBR.FormattingEnabled = true;
            cmbCtgryBR.Location = new Point(366, 88);
            cmbCtgryBR.Name = "cmbCtgryBR";
            cmbCtgryBR.Size = new Size(121, 23);
            cmbCtgryBR.TabIndex = 22;
            cmbCtgryBR.SelectedIndexChanged += cmbCtgryBR_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(228, 0, 124);
            label1.Location = new Point(273, 88);
            label1.Name = "label1";
            label1.Size = new Size(65, 18);
            label1.TabIndex = 21;
            label1.Text = "Category";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtSearchBR);
            panel4.ForeColor = Color.FromArgb(57, 88, 134);
            panel4.Location = new Point(366, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 32);
            panel4.TabIndex = 20;
            // 
            // txtSearchBR
            // 
            txtSearchBR.BackColor = Color.Snow;
            txtSearchBR.BorderStyle = BorderStyle.None;
            txtSearchBR.ForeColor = Color.FromArgb(57, 88, 134);
            txtSearchBR.Location = new Point(16, 8);
            txtSearchBR.Name = "txtSearchBR";
            txtSearchBR.Size = new Size(209, 16);
            txtSearchBR.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(228, 0, 124);
            label3.Location = new Point(273, 55);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 19;
            label3.Text = "Search:";
            label3.Click += label3_Click;
            // 
            // dtaGrdVBR
            // 
            dtaGrdVBR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtaGrdVBR.BackgroundColor = Color.Snow;
            dtaGrdVBR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtaGrdVBR.GridColor = Color.FromArgb(57, 88, 134);
            dtaGrdVBR.Location = new Point(12, 154);
            dtaGrdVBR.Name = "dtaGrdVBR";
            dtaGrdVBR.Size = new Size(883, 472);
            dtaGrdVBR.TabIndex = 23;
            // 
            // btnSearchBR
            // 
            btnSearchBR.BackColor = Color.FromArgb(251, 174, 210);
            btnSearchBR.FlatStyle = FlatStyle.Flat;
            btnSearchBR.ForeColor = Color.Snow;
            btnSearchBR.Location = new Point(641, 48);
            btnSearchBR.Name = "btnSearchBR";
            btnSearchBR.Size = new Size(72, 32);
            btnSearchBR.TabIndex = 24;
            btnSearchBR.Text = "Search";
            btnSearchBR.UseVisualStyleBackColor = false;
            btnSearchBR.Click += btnSearchBR_Click;
            // 
            // userBRbDashpan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(907, 638);
            Controls.Add(btnSearchBR);
            Controls.Add(dtaGrdVBR);
            Controls.Add(cmbCtgryBR);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userBRbDashpan";
            Text = "userBRbDashpan";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtaGrdVBR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCtgryBR;
        private Label label1;
        private Panel panel4;
        private TextBox txtSearchBR;
        private Label label3;
        private DataGridView dtaGrdVBR;
        private Button btnSearchBR;
    }
}