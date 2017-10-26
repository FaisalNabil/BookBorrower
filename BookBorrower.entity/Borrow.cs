using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrower.entity
{
    public class Borrow
    {
        int borrowId, bookId;
        string borrowerName, borrowDate, returnDate, comment;

        public int BorrowId
        {
            get
            {
                return borrowId;
            }

            set
            {
                borrowId = value;
            }
        }

        public int BookId
        {
            get
            {
                return bookId;
            }

            set
            {
                bookId = value;
            }
        }

        public string BorrowerName
        {
            get
            {
                return borrowerName;
            }

            set
            {
                borrowerName = value;
            }
        }

        public string BorrowDate
        {
            get
            {
                return borrowDate;
            }

            set
            {
                borrowDate = value;
            }
        }

        public string ReturnDate
        {
            get
            {
                return returnDate;
            }

            set
            {
                returnDate = value;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }

            set
            {
                comment = value;
            }
        }
    }
}
