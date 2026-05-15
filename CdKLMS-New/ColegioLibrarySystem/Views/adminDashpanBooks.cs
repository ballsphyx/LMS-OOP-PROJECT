using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace librarymanagement.views
{
    public partial class adminDashpanBooks : Form
    {
        private readonly BookManagement _bookManagement;
        private int _selectedBookId = -1;
        public adminDashpanBooks(BookManagement bookManagement)
        {
            InitializeComponent();

            _bookManagement = bookManagement;
        }
        private void adminDashpan_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(CategoryEnum));
            dgvBooksAD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbCatFilter.Items.Add("All");
            foreach (CategoryEnum category in Enum.GetValues(typeof(CategoryEnum)))
            {
                cmbCatFilter.Items.Add(category);
            }
            cmbCatFilter.SelectedIndex = 0;
            cmbCatFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatFilter.SelectedIndexChanged += cmbCatFilter_SelectedIndexChanged;
            LoadBooks();

            PillButton(btnAddAD);
            PillButton(btnClearAD);
            PillButton(btnDltAD);
            PillButton(btnUpdtAD);

            //RoundPanel(panel5, 40);
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
            if (!ValidateISBN()) return;

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

            if (!ValidateISBN()) return;

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
            txtCopies.Clear();
            txtISBN.Clear();
            cmbCategory.SelectedIndex = -1;
            _selectedBookId = -1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private List<Book> _books = new();
        private void LoadBooks()
        {
            try
            {
                _books = _bookManagement.GetAllBooks();
                dgvBooksAD.DataSource = _books;
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

        private void cmbCatFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatFilter.SelectedItem == null)
                return;

            // Show all books
            if (cmbCatFilter.SelectedItem.ToString() == "All")
            {
                dgvBooksAD.DataSource = null;
                dgvBooksAD.DataSource = _books;
                return;
            }

            CategoryEnum selectedCategory = (CategoryEnum)cmbCatFilter.SelectedItem;

            List<Book> filteredBooks = _books
                .Where(b =>
                    b.Category.CatName == selectedCategory)
                .ToList();

            dgvBooksAD.DataSource = null;
            dgvBooksAD.DataSource = filteredBooks;
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }
        private bool ValidateISBN()
        {
            if (txtISBN.Text.Length != 13)
            {
                MessageBox.Show("ISBN must be exactly 13 digits.");
                return false;
            }

            return true;
        }
    }
}
