using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using System.Text.RegularExpressions;

namespace librarymanagement.views
{
    public partial class adminDashpanBooks : Form
    {
        private readonly BookManagement _bookManagement;
        private readonly TransactionManagement _transactionManagement;
        private int _selectedBookId = -1;
        public adminDashpanBooks(BookManagement bookManagement, TransactionManagement transactionManagement)
        {
            InitializeComponent();

            _transactionManagement = transactionManagement;
            _bookManagement = bookManagement;
        }
        private void adminDashpan_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(CategoryEnum));
            LoadBooks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == -1)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }
            string title = txtTitleAD.Text.Trim();
            string author = txtAuthAD.Text.Trim();
            string copies = txtCopies.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            int date = dateTimePicker.Value.Year;
            var selectedCat = (CategoryEnum)cmbCategory.SelectedItem;

            string[] reqfields = { title, author, copies, isbn };
            foreach (var fields in reqfields)
            {
                if (String.IsNullOrEmpty(fields))
                {
                    MessageBox.Show("Please fill in all required fields");
                    ClearFields();
                    return;
                }
            }

            if (!Regex.IsMatch(isbn, @"^\d{10}$|^\d{13}$"))
            {
                MessageBox.Show("ISBN must be exactly 10 or 13 digits.");
                return;
            }
            if (date > DateTime.Now.Year)
            {
                MessageBox.Show("Publication date cannot be in the future.");
                return;
            }
            if (!int.TryParse(copies, out int numCopies))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            if (numCopies <= 0)
            {
                MessageBox.Show("Copies must be more than 0");
                return;
            }
            try
            {
                _bookManagement.UpdateBook(title, isbn, author, selectedCat, date, numCopies);
                MessageBox.Show("Updated Book");
                LoadBooks();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Service Layer Error: " + ex.Message);
            }
            ClearFields();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTitleAD.Text.Trim();
            string author = txtAuthAD.Text.Trim();
            string copies = txtCopies.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            int date = dateTimePicker.Value.Year;
            var selectedCat = (CategoryEnum)cmbCategory.SelectedItem;

            string[] reqfields = { title, author, copies, isbn };
            foreach (var fields in reqfields)
            {
                if (String.IsNullOrEmpty(fields))
                {
                    MessageBox.Show("Please fill in all required fields");
                    ClearFields();
                    return;
                }
            }

            if (!Regex.IsMatch(isbn, @"^\d{10}$|^\d{13}$"))
            {
                MessageBox.Show("ISBN must be exactly 10 or 13 digits.");
                return;
            }
            if (date > DateTime.Now.Year)
            {
                MessageBox.Show("Publication date cannot be in the future.");
                return;
            }
            if (!int.TryParse(copies, out int numCopies))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            if (numCopies <= 0)
            {
                MessageBox.Show("Copies must be more than 0");
                return;
            }
            try
            {
                _bookManagement.AddBook(title, author, selectedCat, date, numCopies, isbn);
                MessageBox.Show("Book Added");
                LoadBooks();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Service layer error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == -1)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this book?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                 );
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _bookManagement.DeleteBook(_selectedBookId);
                    MessageBox.Show("Deleted Book");
                    LoadBooks();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Service layer error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtAuthAD.Clear();
            txtTitleAD.Clear();
            txtAvail.Clear();
            txtCopies.Clear();
            txtISBN.Clear();
            cmbCategory.SelectedIndex = -1;
            _selectedBookId = -1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadBooks()
        {
            try
            {
                List<Book> books = _bookManagement.GetAllBooks();
                dgvBooksAD.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load books: " + ex.Message);
            }
        }

        private void dgvBooksAD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooksAD.SelectedRows.Count == 0) return;

            Book selected = (Book)dgvBooksAD.SelectedRows[0].DataBoundItem;
            _selectedBookId = selected.BookID;

            txtTitleAD.Text = selected.Title;
            txtAuthAD.Text = selected.Author;
            txtISBN.Text = selected.ISBN;
            cmbCategory.SelectedItem = selected.Category.CatName;
            dateTimePicker.Value = new DateTime(selected.PublicationYear, 1, 1);
            txtCopies.Text = selected.TotalCopies.ToString();
        }
    }
}
