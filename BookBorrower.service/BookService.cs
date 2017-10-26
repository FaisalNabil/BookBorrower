using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrower.entity;
using BookBorrower.data;

namespace BookBorrower.service
{
    public class BookService : IBookService
    {
        private static BookDataAccess bookDataAccess = null;

        public BookService()
        {
            if (BookService.bookDataAccess == null)
            {
                BookService.bookDataAccess = new BookDataAccess();
            }
        }

        public int Add(Book book)
        {
            return BookService.bookDataAccess.Add(book);
        }

        public int Edit(Book book)
        {
            return BookService.bookDataAccess.Edit(book);
        }

        public List<Book> GetAll()
        {
            return BookService.bookDataAccess.GetAll();
        }

        public List<Book> GetByStatus(string status)
        {
            return BookService.bookDataAccess.GetByStatus(status);
        }

        public Book GetById(int bookId)
        {
            return BookService.bookDataAccess.GetById(bookId);
        }

        public Book GetByName(string bookName)
        {
            return BookService.bookDataAccess.GetByName(bookName);
        }

        public int Remove(int bookId)
        {
            return BookService.bookDataAccess.Remove(bookId);
        }
    }
}
