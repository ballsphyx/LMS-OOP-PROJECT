using ColegioLibrarySystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioLibrarySystem.Views
{
    public partial class adminDashpan : Form
    {
        private readonly TransactionManagement _transactionManagement;
        public adminDashpan(TransactionManagement tm)
        {
            InitializeComponent();
            _transactionManagement = tm;
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

        private void adminDashpan_Load(object sender, EventArgs e)
        {
            RoundPanel(panel1, 50);
            RoundPanel(panel2, 50);
            RoundPanel(panel3, 50);
            LoadRecentTransactions();
        }

        private void dgvRcntRtrnsAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadRecentTransactions()
        {
            try
            {
                dgvRcntRtrnsAD.DataSource = _transactionManagement.GetTodaysTransactions();
                dgvRcntRtrnsAD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvRcntRtrnsAD.Columns["transaction_id"] != null)
                    dgvRcntRtrnsAD.Columns["transaction_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
