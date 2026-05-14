namespace librarymanagement.views
{
    partial class userTRDashpan
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
            dtaGrdVwTrnsc = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtaGrdVwTrnsc).BeginInit();
            SuspendLayout();
            // 
            // dtaGrdVwTrnsc
            // 
            dtaGrdVwTrnsc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtaGrdVwTrnsc.BackgroundColor = Color.Snow;
            dtaGrdVwTrnsc.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.HotPink;
            dataGridViewCellStyle3.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtaGrdVwTrnsc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtaGrdVwTrnsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.HotPink;
            dataGridViewCellStyle4.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtaGrdVwTrnsc.DefaultCellStyle = dataGridViewCellStyle4;
            dtaGrdVwTrnsc.GridColor = Color.FromArgb(251, 174, 210);
            dtaGrdVwTrnsc.Location = new Point(16, 79);
            dtaGrdVwTrnsc.Name = "dtaGrdVwTrnsc";
            dtaGrdVwTrnsc.RowHeadersWidth = 51;
            dtaGrdVwTrnsc.Size = new Size(869, 590);
            dtaGrdVwTrnsc.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightPink;
            panel2.Location = new Point(6, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 617);
            panel2.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 81, 117);
            label1.Location = new Point(386, 25);
            label1.Name = "label1";
            label1.Size = new Size(139, 19);
            label1.TabIndex = 0;
            label1.Text = "My Transactions";
            // 
            // userTRDashpan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(900, 692);
            Controls.Add(label1);
            Controls.Add(dtaGrdVwTrnsc);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "userTRDashpan";
            Text = "userTRDashpan";
            Load += userTRDashpan_Load;
            ((System.ComponentModel.ISupportInitialize)dtaGrdVwTrnsc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtaGrdVwTrnsc;
        private Panel panel2;
        private Label label1;
    }
}