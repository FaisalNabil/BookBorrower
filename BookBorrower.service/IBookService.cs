using System;
using System.Collections.Generic;
using BookBorrower.entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrower.service
{
    public interface IBookService
    {
        int Add(Book book);
        int Remove(int bookId);
        int Edit(Book book);
        List<Book> GetAll();
        List<Book> GetByStatus(string status);
        Book GetById(int bookId);
        Book GetByName(string bookName);
    }
}
