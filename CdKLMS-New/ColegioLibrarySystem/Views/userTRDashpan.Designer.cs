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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userTRDashpan));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label1 = new Label();
            btnRtrn = new Button();
            dtaGrdVwTrnsc = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtaGrdVwTrnsc).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightPink;
            panel2.Controls.Add(dtaGrdVwTrnsc);
            panel2.Location = new Point(24, 123);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 776);
            panel2.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(247, 81, 117);
            label1.Location = new Point(437, 55);
            label1.Name = "label1";
            label1.Size = new Size(183, 26);
            label1.TabIndex = 0;
            label1.Text = "My Transactions";
            // 
            // btnRtrn
            // 
            btnRtrn.BackColor = Color.FromArgb(247, 81, 117);
            btnRtrn.BackgroundImageLayout = ImageLayout.Center;
            btnRtrn.FlatStyle = FlatStyle.Flat;
            btnRtrn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRtrn.ForeColor = Color.Snow;
            btnRtrn.Image = (Image)resources.GetObject("btnRtrn.Image");
            btnRtrn.ImageAlign = ContentAlignment.MiddleRight;
            btnRtrn.Location = new Point(72, 70);
            btnRtrn.Margin = new Padding(3, 4, 3, 4);
            btnRtrn.Name = "btnRtrn";
            btnRtrn.Size = new Size(130, 45);
            btnRtrn.TabIndex = 58;
            btnRtrn.Text = "Return";
            btnRtrn.TextAlign = ContentAlignment.MiddleLeft;
            btnRtrn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRtrn.UseVisualStyleBackColor = false;
            btnRtrn.Click += btnReturn_Click;
            // 
            // dtaGrdVwTrnsc
            // 
            dtaGrdVwTrnsc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtaGrdVwTrnsc.BackgroundColor = Color.Snow;
            dtaGrdVwTrnsc.BorderStyle = BorderStyle.None;
            dtaGrdVwTrnsc.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtaGrdVwTrnsc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 81, 117);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtaGrdVwTrnsc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtaGrdVwTrnsc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(247, 81, 117);
            dataGridViewCellStyle2.SelectionBackColor = Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtaGrdVwTrnsc.DefaultCellStyle = dataGridViewCellStyle2;
            dtaGrdVwTrnsc.EnableHeadersVisualStyles = false;
            dtaGrdVwTrnsc.GridColor = Color.FromArgb(251, 174, 210);
            dtaGrdVwTrnsc.Location = new Point(3, 3);
            dtaGrdVwTrnsc.Name = "dtaGrdVwTrnsc";
            dtaGrdVwTrnsc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtaGrdVwTrnsc.RowHeadersWidth = 51;
            dtaGrdVwTrnsc.Size = new Size(977, 771);
            dtaGrdVwTrnsc.TabIndex = 56;
            dtaGrdVwTrnsc.SelectionChanged += dtaGrdVwTrnsc_SelectionChanged;
            // 
            // userTRDashpan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1029, 923);
            Controls.Add(btnRtrn);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "userTRDashpan";
            Text = "userTRDashpan";
            Load += userTRDashpan_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtaGrdVwTrnsc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Button btnRtrn;
        private DataGridView dtaGrdVwTrnsc;
    }
}