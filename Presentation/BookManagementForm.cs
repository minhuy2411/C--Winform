using AutoMapper.Execution;
using Business.Entities;
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
using System.Xml.Linq;

namespace e_Journal
{
    public partial class BookManagementForm : Form
    {
        private BookService bookService = new BookService();
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;

        }

        private void BookManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                txtBookID.Text = selectedBook.BookId.ToString();
                txtBookName.Text = selectedBook.BookName;
                txtDescription.Text = selectedBook.BookDescription;
                dtpReleaseDate.Value = selectedBook.ReleaseDate;
                txtAuthor.Text = selectedBook.Author;
                isActive.Checked = (bool)selectedBook.IsActived;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = bookService.SearchBooks(txtSearch.Text.Trim());

            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int id = int.Parse(txtBookID.Text);
                if (string.IsNullOrWhiteSpace(txtBookID.Text) || !int.TryParse(txtBookID.Text, out id))
                {
                    MessageBox.Show("The Book ID is invalid. Please select a row in the grid to edit or input a number!!!",
                        "Invalid Book ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    bookService.DeleteABook(id);
                    var result = bookService.GetAllBookID();
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = result;
                    MessageBox.Show("Delete Successfully", "Deleted", MessageBoxButtons.OK);
                }
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookForm bookForm = new AddBookForm();
            bookForm.ShowDialog();
            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }


        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var book = GetBookObject();
            try
            {
                if (book != null && txtBookName != null)
                {
                    bookService.UpdateABook(book);
                    var result = bookService.GetAllBookID();
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = result;
                    MessageBox.Show("Update Successfull!");
                }
            }
            catch (Exception)
            {

                throw new Exception("Update book fail. Duplicated book!");
            }

        }
        private Book GetBookObject()
        {
            Book book = null;
            try
            {
                if (!txtBookName.Text.Equals("") || !txtAuthor.Text.Equals(""))
                {
                    book = new Book
                    {
                        BookId = int.Parse(txtBookID.Text),
                        Author = txtAuthor.Text,
                        BookName = txtBookName.Text,
                        BookDescription = txtDescription.Text,
                        ReleaseDate = dtpReleaseDate.Value,
                        IsActived = isActive.Checked
                    };
                }
                else throw new Exception("Book Name and Author can not be null!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Book");
            }
            return book;
        }


        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginfm = new LoginForm();
            loginfm.ShowDialog();
        }
    }
}
