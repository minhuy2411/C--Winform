using Business.Entities;
using DataAccess.Repositories;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Journal
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBookName.Text) ||
                String.IsNullOrEmpty(txtDescription.Text) ||
                String.IsNullOrEmpty(txtAuthor.Text) ||
                String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Required all fields!");
                return;
            }
            var book = new Book();
            book.BookName = txtBookName.Text;
            book.BookDescription = txtDescription.Text;
            book.Author = txtAuthor.Text;
            book.ReleaseDate = dateTimePicker1.Value;
            book.IsActived = false;
            BookRepository bookRepository = new BookRepository();
            bookRepository.Create(book);
            MessageBox.Show("Add successfully!!");
            this.Hide();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtAuthor.Text = String.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                errorProviderDate.SetError(dateTimePicker1, "Choose a time sooner than the current time.");
            }
            else
            {
                errorProviderDate.SetError(dateTimePicker1, "");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
