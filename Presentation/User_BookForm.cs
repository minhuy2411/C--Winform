using AutoMapper;
using Business.DTO;
using Business.Entities;
using Business.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Repositories;

namespace e_Journal
{
    public partial class User_BookForm : Form
    {
        private BookService bookService = new BookService();
        private BookRepository bookRepository = new BookRepository();
        private BindingSource _bookSource;
        public User_BookForm()
        {
            InitializeComponent();
            loadBook(null);
        }

        private void loadBook(List<Book> books)
        {
            _bookSource = new BindingSource();
            if (books != null)
            {
                dgvBook.DataSource = null;
                return;
            }

            books = books == null ? bookService.GetAllActiveBooks() : books;
            var config = new MapperConfiguration(cfg =>
            {
                BookConfig.createMap(cfg);
            });

            var mapperBookCon = config.CreateMapper();

            var bookDto = books.Select(
                book => mapperBookCon
                .Map<Book, BookDTO>(book)
                );

            _bookSource.DataSource = bookDto;

            txtBookID.DataBindings.Clear();
            txtBookName.DataBindings.Clear();
            txtAuthor.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            dtpReleaseDate.DataBindings.Clear();

            txtBookID.DataBindings.Add("Text", _bookSource, "BookID");
            txtBookName.DataBindings.Add("Text", _bookSource, "BookName");
            txtAuthor.DataBindings.Add("Text", _bookSource, "Author");
            txtDescription.DataBindings.Add("Text", _bookSource, "BookDescription");
            dtpReleaseDate.DataBindings.Add("Value", _bookSource, "ReleaseDate");

            dgvBook.DataSource = null;
            dgvBook.DataSource = _bookSource;

        }

        private void dateRelease_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // var book = bookService.SearchBooks(txtBookName.Text);
            // if (book == null)
            //{
            //    MessageBox.Show("No book found !!");
            //    loadBook(new List<Book>());
            //     return;
            //  }
            //  loadBook(book);
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = bookService.SearchBooksUser(txtSearch.Text.Trim());
            dgvBook.DataSource = null;
            dgvBook.DataSource = result;
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
