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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userBRbDashpan));
            cmbCtgryBR = new ComboBox();
            label1 = new Label();
            panel4 = new Panel();
            txtSearchBR = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtaGrdVBR = new DataGridView();
            btnSearchBR = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtaGrdVBR).BeginInit();
            SuspendLayout();
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
            txtSearchBR.TextChanged += txtSearchBR_TextChanged;
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
            label2.ForeColor = Color.FromArgb(247, 81, 117);
            label2.Location = new Point(418, 219);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 28;
            label2.Text = "Book List";
            label2.Click += label2_Click;
            // 
            // dtaGrdVBR
            // 
            dtaGrdVBR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtaGrdVBR.BackgroundColor = Color.Snow;
            dtaGrdVBR.BorderStyle = BorderStyle.None;
            dtaGrdVBR.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtaGrdVBR.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 81, 117);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtaGrdVBR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtaGrdVBR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(247, 81, 117);
            dataGridViewCellStyle2.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtaGrdVBR.DefaultCellStyle = dataGridViewCellStyle2;
            dtaGrdVBR.EnableHeadersVisualStyles = false;
            dtaGrdVBR.GridColor = Color.FromArgb(251, 174, 210);
            dtaGrdVBR.Location = new Point(23, 278);
            dtaGrdVBR.Margin = new Padding(3, 2, 3, 2);
            dtaGrdVBR.Name = "dtaGrdVBR";
            dtaGrdVBR.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtaGrdVBR.RowHeadersWidth = 51;
            dtaGrdVBR.Size = new Size(861, 390);
            dtaGrdVBR.TabIndex = 54;
            // 
            // btnSearchBR
            // 
            btnSearchBR.BackColor = Color.FromArgb(247, 81, 117);
            btnSearchBR.BackgroundImageLayout = ImageLayout.Center;
            btnSearchBR.FlatStyle = FlatStyle.Flat;
            btnSearchBR.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBR.ForeColor = Color.Snow;
            btnSearchBR.Image = (Image)resources.GetObject("btnSearchBR.Image");
            btnSearchBR.Location = new Point(627, 89);
            btnSearchBR.Name = "btnSearchBR";
            btnSearchBR.Size = new Size(39, 33);
            btnSearchBR.TabIndex = 55;
            btnSearchBR.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchBR.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchBR.UseVisualStyleBackColor = false;
            btnSearchBR.Click += btnSearchBR_Click_1;
            // 
            // userBRbDashpan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(900, 692);
            Controls.Add(btnSearchBR);
            Controls.Add(dtaGrdVBR);
            Controls.Add(label2);
            Controls.Add(cmbCtgryBR);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userBRbDashpan";
            Text = "userBRbDashpan";
            Load += userBRbDashpan_Load;
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
        private Label label2;
        private DataGridView dtaGrdVBR;
        private Button btnSearchBR;
    }
}