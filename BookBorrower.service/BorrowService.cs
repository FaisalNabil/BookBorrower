using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrower.entity;
using BookBorrower.data;

namespace BookBorrower.service
{
    public class BorrowService : IBorrowService
    {
        private static BorrowDataAccess borrowDataAccess = null;

        public BorrowService()
        {
            if (BorrowService.borrowDataAccess == null)
            {
                BorrowService.borrowDataAccess = new BorrowDataAccess();
            }
        }

        public int Add(Borrow borrow)
        {
            return BorrowService.borrowDataAccess.Add(borrow);
        }

        public int Edit(Borrow borrow)
        {
            return BorrowService.borrowDataAccess.Edit(borrow);
        }

        public List<Borrow> GetAll()
        {
            return BorrowService.borrowDataAccess.GetAll();
        }

        public List<Borrow> GetAllByBookId(int bookId)
        {
            return BorrowService.borrowDataAccess.GetAllByBookId(bookId); 
        }

        public Borrow GetByBookId(int bookId)
        {
            return BorrowService.borrowDataAccess.GetByBookId(bookId);
        }

        public Borrow GetById(int borrowId)
        {
            return BorrowService.borrowDataAccess.GetById(borrowId);
        }

        public int Remove(int borrowId)
        {
            return BorrowService.borrowDataAccess.Remove(borrowId);
        }
    }
}
