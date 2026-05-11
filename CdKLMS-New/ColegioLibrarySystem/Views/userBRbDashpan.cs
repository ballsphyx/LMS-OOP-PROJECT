namespace librarymanagement.views
{
    public partial class userBRbDashpan : Form
    {
        public userBRbDashpan()
        {
            InitializeComponent();

            cmbCtgryBR.Items.Add("Romance");
            cmbCtgryBR.Items.Add("Fiction");
            cmbCtgryBR.Items.Add("Non-Fiction");
            cmbCtgryBR.Items.Add("Science");
            cmbCtgryBR.Items.Add("History");
            cmbCtgryBR.Items.Add("Biography");
            cmbCtgryBR.Items.Add("Fantasy");
            cmbCtgryBR.Items.Add("Mystery");
            cmbCtgryBR.Items.Add("Horror");
            cmbCtgryBR.Items.Add("Self-Help");
            cmbCtgryBR.Items.Add("Philosophy");
            cmbCtgryBR.Items.Add("Religion");
            cmbCtgryBR.Items.Add("Technology");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBR_Click(object sender, EventArgs e)
        {
            //backend search logic here
        }

        private void cmbCtgryBR_SelectedIndexChanged(object sender, EventArgs e)
        {
            //backend category filter logic here
        }
    }
}
