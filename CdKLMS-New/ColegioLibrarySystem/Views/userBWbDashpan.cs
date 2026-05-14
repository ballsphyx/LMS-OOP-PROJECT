using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;

namespace librarymanagement.views
{
    public partial class userBKbDashpan : Form
    {
        private readonly TransactionManagement _transactionManagement;
        private readonly BookManagement _bookManagement;
        private List<Book> _books = new();
        private int _selectedBookID = -1;
        public userBKbDashpan(TransactionManagement tm, BookManagement bm)
        {
            InitializeComponent();
            _transactionManagement = tm;
            _bookManagement = bm;
        }

        private void userBKbDashpan_Load(object sender, EventArgs e)
        {
            if (Session.IsStudent)
            {
                nbQntyBW.Text = "1";
                nbQntyBW.Enabled = false;
            }
            else
            {
                nbQntyBW.Enabled = true;
            }
            LoadBooks();
        }
        private void LoadBooks()
        {
            try
            {
                _books = _bookManagement.GetAllBooks();
                dtaGdVwBrw.DataSource = _books;
                dtaGdVwBrw.Columns["BookID"].Visible = false;
                dtaGdVwBrw.Columns["CatId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrw_Click(object sender, EventArgs e)
        {
            string title = txtTTBrw.Text.Trim();
            string bookID = txtBkIDBrw.Text.Trim();
            string available = txtAvblBrw.Text.Trim();
            int quantity = (int)nbQntyBW.Value;
            if (!int.TryParse(bookID, out int id))
            {
                MessageBox.Show("BookID must be a number");
                return;
            }
            string[] reqFields = { title, bookID, available };
            foreach (var fields in reqFields)
            {
                if (string.IsNullOrEmpty(fields))
                {
                    MessageBox.Show("Fields must not be empty");
                    return;
                }
            }
            try
            {
                _transactionManagement.BorrowBook(id, quantity);
                MessageBox.Show("Book borrowed");
                LoadBooks();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Failed to Borrow Book: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtaGdVwBrw_SelectionChanged(object sender, EventArgs e)
        {
            if (dtaGdVwBrw.SelectedRows.Count == 0) return;

            Book selected = (Book)dtaGdVwBrw.SelectedRows[0].DataBoundItem;
            _selectedBookID = selected.BookID;

            txtTTBrw.Text = selected.Title;
            txtBkIDBrw.Text = selected.BookID.ToString();
            txtAvblBrw.Text = selected.AvailableCopies.ToString();
        }
    }
}
