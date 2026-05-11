namespace librarymanagement.views
{
    public partial class adminDashpanBooks : Form
    {
        public adminDashpanBooks()
        {
            InitializeComponent();

            cmbCategory.Items.Add("Romance");
            cmbCategory.Items.Add("Fiction");
            cmbCategory.Items.Add("Non-Fiction");
            cmbCategory.Items.Add("Science");
            cmbCategory.Items.Add("History");
            cmbCategory.Items.Add("Biography");
            cmbCategory.Items.Add("Fantasy");
            cmbCategory.Items.Add("Mystery");
            cmbCategory.Items.Add("Horror");
            cmbCategory.Items.Add("Self-Help");
            cmbCategory.Items.Add("Philosophy");
            cmbCategory.Items.Add("Religion");
            cmbCategory.Items.Add("Technology");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Updated Book");
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
            MessageBox.Show("Added Book");
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deleted Book");
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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
