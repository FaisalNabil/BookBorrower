using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrower.entity
{
    public class Book
    {
        int bookId, typeId;
        string bookName, bookAuthor, entryDate, status;

        public string BookAuthor
        {
            get
            {
                return bookAuthor;
            }

            set
            {
                bookAuthor = value;
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

        public string BookName
        {
            get
            {
                return bookName;
            }

            set
            {
                bookName = value;
            }
        }

        public string EntryDate
        {
            get
            {
                return entryDate;
            }

            set
            {
                entryDate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int TypeId
        {
            get
            {
                return typeId;
            }

            set
            {
                typeId = value;
            }
        }
    }
}
