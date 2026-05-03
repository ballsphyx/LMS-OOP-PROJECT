using ColegioLibrarySystem.Models;
using ColegioLibrarySystem.Service;
using ColegioLibrarySystem.GlobalEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace librarymanagement.views
{
    public partial class adminDashpanBooks : Form
    {
        private readonly BookManagement _bookManagement;
        public adminDashpanBooks(BookManagement bookManagement)
        {
            InitializeComponent();
            this._bookManagement = bookManagement;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateBook(object sender, EventArgs e)
        {
            MessageBox.Show("Updated Book");
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

        private void AddBook(object sender, EventArgs e)
        {
            var title = textAuthor.Text;
            var author = textTitle.Text;
            if (author.Any(char.IsDigit))
            {
                MessageBox.Show("Author name should not contain any numbers", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var numCopies = 0;
            if (!int.TryParse(textCopies.Text, out numCopies))
            {
                MessageBox.Show("Pls input a valid number", "Invalid Input", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }
            var isbn = txtISBN.Text;
            if (isbn.Any(char.IsDigit))
            {
                MessageBox.Show("ISBN should not contain any numbers", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Category cat = Category.Education; //replace later on
            DateTime date = DateTime.Now; //replace later on

            var success = _bookManagement.AddBook(title, author, cat, date, numCopies, isbn);
            if (success)
            {
                MessageBox.Show("Added Book");
                ClearFields();
            }
            else
            {
                MessageBox.Show("An error occured during operation", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBook(object sender, EventArgs e)
        {
            MessageBox.Show("Deleted Book");
        }

        private void ClearField(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            textAuthor.Clear();
            textTitle.Clear();
            textCat.Clear();
            textCopies.Clear();
            textBox5.Clear();
            txtISBN.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
