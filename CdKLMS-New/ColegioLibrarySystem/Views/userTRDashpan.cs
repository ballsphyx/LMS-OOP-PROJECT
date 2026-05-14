using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using System.Drawing.Drawing2D;

namespace librarymanagement.views
{
    public partial class userTRDashpan : Form
    {
        private readonly TransactionManagement _transactionManagemetn;
        public userTRDashpan(TransactionManagement tm)
        {
            InitializeComponent();
            _transactionManagemetn = tm;
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

            RoundPanel(panel2, 40);
        }
        private void LoadUserTransactions()
        {
            try
            {
                dtaGrdVwTrnsc.DataSource = _transactionManagemetn.GetBorrowsByUser(Session.CurrentUser.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
