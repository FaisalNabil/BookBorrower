using System;
using System.Collections.Generic;
using BookBorrower.entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrower.service
{
    public interface IBorrowService
    {
        int Add(Borrow borrow);
        int Remove(int borrowId);
        int Edit(Borrow borrow);
        List<Borrow> GetAll();
        Borrow GetById(int borrowId);
        Borrow GetByBookId(int bookId);
        List<Borrow> GetAllByBookId(int bookId);
    }
}
