using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BookRepository
    {
        private BookScienceContext context;

        public Book? Get(int bookId)
        {
            context = new BookScienceContext();

            return context.Books.Find(bookId);
        }

        public List<Book> GetAll()
        {

            using (var context = new BookScienceContext())
            {
                return context.Books.ToList();
            }

        }

        public void Create(Book book)
        {
            context = new BookScienceContext();
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Update(Book book)
        {
            context = new BookScienceContext();
            try
            {
                var newB = Get(book.BookId);
                newB.BookName = book.BookName;
                newB.Author= book.Author;
                newB.BookDescription= book.BookDescription;
                newB.ReleaseDate= book.ReleaseDate;
                newB.IsActived= book.IsActived;
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            context = new BookScienceContext();
            var book = context.Books.FirstOrDefault(b => b.BookId == id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

    }
}
