namespace librarymanagement.views
{
    public partial class adminDashpanBooks : Form
    {
        public adminDashpanBooks()
        {
            InitializeComponent();

            cmbCategory.Items.AddRange(new string[] 
            {
                "Select Category","Romance","Fiction","Non-Fiction","Science","History","Biography","Fantasy","Mystery","Horror","Self-Help","Philosophy","Religion","Technology"

            });

            cmbCategory.SelectedIndex = 0;

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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
