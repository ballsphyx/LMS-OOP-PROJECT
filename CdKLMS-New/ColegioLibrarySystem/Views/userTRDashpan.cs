using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;

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

        private void userTRDashpan_Load(object sender, EventArgs e)
        {
            LoadUserTransactions();
            dtaGrdVwTrnsc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
