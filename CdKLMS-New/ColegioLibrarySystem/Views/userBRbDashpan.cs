using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;

namespace librarymanagement.views
{
    public partial class userBRbDashpan : Form
    {
        private List<Book> _books = new();
        private readonly BookManagement _bookManagement;
        public userBRbDashpan(BookManagement bookManagement)
        {
            InitializeComponent();
            _bookManagement = bookManagement;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBR_Click(object sender, EventArgs e)
        {
            List<Book> searchedBooks = new List<Book>();
            if (String.IsNullOrEmpty(txtSearchBR.Text))
            {
                MessageBox.Show("Search must not be blank");
                return;
            }
            try
            {
                searchedBooks = _bookManagement.GetBookByTitle(txtSearchBR.Text);
                dtaGrdVBR.DataSource = searchedBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex.Message);
            }
        }

        private void cmbCtgryBR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCtgryBR.SelectedItem == null)
                return;

            // Show all books
            if (cmbCtgryBR.SelectedItem.ToString() == "All")
            {
                dtaGrdVBR.DataSource = null;
                dtaGrdVBR.DataSource = _books;
                return;
            }

            CategoryEnum selectedCategory = (CategoryEnum)cmbCtgryBR.SelectedItem;

            List<Book> filteredBooks = _books
                .Where(b =>
                    b.Category.CatName == selectedCategory)
                .ToList();

            dtaGrdVBR.DataSource = null;
            dtaGrdVBR.DataSource = filteredBooks;
        }
        private void LoadBooks()
        {
            try
            {
                _books = _bookManagement.GetAllBooks();
                dtaGrdVBR.DataSource = _books;
                dtaGrdVBR.Columns["CatId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load books: " + ex.Message);
            }
        }

        private void userBRbDashpan_Load(object sender, EventArgs e)
        {
            cmbCtgryBR.Items.Add("All");
            foreach (CategoryEnum category in Enum.GetValues(typeof(CategoryEnum)))
            {
                cmbCtgryBR.Items.Add(category);
            }

            cmbCtgryBR.SelectedIndex = 0;
            cmbCtgryBR.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCtgryBR.SelectedIndexChanged += cmbCtgryBR_SelectedIndexChanged;
            dtaGrdVBR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadBooks();
        }
    }
}
