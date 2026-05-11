namespace librarymanagement.views
{
    public partial class userBRbDashpan : Form
    {
        public userBRbDashpan()
        {
            InitializeComponent();

            cmbCtgryBR.Items.AddRange(new string[]
            {
                "Select Category","Romance","Fiction","Non-Fiction","Science","History","Biography","Fantasy","Mystery","Horror","Self-Help","Philosophy","Religion","Technology"

            });

            cmbCtgryBR.SelectedIndex = 0;
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
