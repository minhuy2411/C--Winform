using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using DataAccess.Repositories;

namespace DataAccess
{
    public class BookService
    {
        private BookRepository repo = new BookRepository();

        public List<Book> GetAllBookID()
        {
            return repo.GetAll();
        }

        public List<Book> SearchBooks(string keyword)
        {
            return repo.GetAll().Where(b => b.BookName.ToLower().Contains(keyword.ToLower()) ||
                                             b.Author.ToLower().Contains(keyword.ToLower())).ToList();
        }
        public List<Book> SearchBooksUser(string keyword)
        {
            return repo.GetAll().Where(b => b.BookName.ToLower().Contains(keyword.ToLower()) &&
                                             b.IsActived == true).ToList();
        }
        public List<Book> GetAllActiveBooks()
        {
            return repo.GetAll().Where(b => b.IsActived == true ).ToList();
        }
        
        public void DeleteABook(int id)
        {
            repo.Delete(id);
        }

        public Book? GetABook(int id)
        {
            return repo.Get(id);
        }

        public void Create(Book book)
        {
            
            repo.Create(book);

        }

        public void UpdateABook(Book book)
        {
            repo.Update(book);
        }
    }
}
