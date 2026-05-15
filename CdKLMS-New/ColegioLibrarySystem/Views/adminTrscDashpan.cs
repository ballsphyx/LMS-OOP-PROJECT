using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioLibrarySystem.Views
{
    public partial class adminTrscDashpan : Form
    {
        private List<Transaction> transactions = new();
        private readonly TransactionManagement _transactionManagement;
        public adminTrscDashpan(TransactionManagement transactionManagement)
        {
            InitializeComponent();
            _transactionManagement = transactionManagement;
        }

        private void adminTrscDashpan_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            dtaGrdVwTrnsc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtaGrdVwTrnsc.Columns["User"].Visible = false;
            dtaGrdVwTrnsc.Columns["BookCopy"].Visible = false;
        }
        private void LoadTransactions()
        {
            try
            {
                transactions = _transactionManagement.GetAllBorrows();
                dtaGrdVwTrnsc.DataSource = transactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transactions" + ex.Message);
            }
        }
    }
}
