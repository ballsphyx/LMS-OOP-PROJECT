using ColegioLibrarySystem.GlobalEnums;
using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using System.Drawing.Drawing2D;

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
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.HotPink;
            btn.ForeColor = Color.White;

            // smoother edges
            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            };
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

            RoundButton(btnSearchBR, 15);

            RoundPanel(panel1,40);
        }
    }
}
