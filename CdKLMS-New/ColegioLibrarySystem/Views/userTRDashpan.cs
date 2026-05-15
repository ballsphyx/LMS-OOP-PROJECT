using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using System.Data;
using System.Drawing.Drawing2D;

namespace librarymanagement.views
{
    public partial class userTRDashpan : Form
    {
        private readonly TransactionManagement _transactionManagement;
        public userTRDashpan(TransactionManagement tm)
        {
            InitializeComponent();
            _transactionManagement = tm;
        }
        private void RoundPanel(Panel pnl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(pnl.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(pnl.Width - radius, pnl.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, pnl.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();

            pnl.Region = new Region(path);
        }

        private void userTRDashpan_Load(object sender, EventArgs e)
        {
            LoadUserTransactions();
            dtaGrdVwTrnsc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RoundPanel(panel2, 20);
            PillButton(btnRtrn);
        }
        private void LoadUserTransactions()
        {
            try
            {
                dtaGrdVwTrnsc.DataSource = _transactionManagement.GetBorrowsByUser(Session.CurrentUser.UserId);

                // hide transaction_id column from user
                if (dtaGrdVwTrnsc.Columns["transaction_id"] != null)
                    dtaGrdVwTrnsc.Columns["transaction_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtaGrdVwTrnsc_SelectionChanged(object sender, EventArgs e)
        {
            if (dtaGrdVwTrnsc.SelectedRows.Count == 0)
            {
                btnRtrn.Visible = false;
                return;
            }

            DataRowView row = (DataRowView)dtaGrdVwTrnsc.SelectedRows[0].DataBoundItem;
            bool isActive = row["date_returned"] == DBNull.Value ||
                            string.IsNullOrEmpty(row["date_returned"].ToString());

            btnRtrn.Visible = isActive;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dtaGrdVwTrnsc.SelectedRows.Count == 0) return;

            var result = MessageBox.Show(
                "Are you sure you want to return this book?",
                "Return Book",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataRowView row = (DataRowView)dtaGrdVwTrnsc.SelectedRows[0].DataBoundItem;
                int transactionId = Convert.ToInt32(row["transaction_id"]);

                try
                {
                    bool success = _transactionManagement.ReturnBook(transactionId);
                    if (success)
                    {
                        MessageBox.Show("Book returned successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserTransactions();
                        btnRtrn.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to return book.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void PillButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();

            int radius = btn.Height;

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 90, 180);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 180);
            path.CloseFigure();

            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.Cursor = Cursors.Hand;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
