using System;
using System.Collections.Generic;
using BookBorrower.entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookBorrower.data
{
    public class BookDataAccess
    {
        public int Add(Book book)
        {
            string query = string.Format("INSERT INTO Books(BookName, BookAuthor, TypeId, EntryDate, Status) VALUES('{0}', '{1}', {2}, '{3}', '{4}')", book.BookName, book.BookAuthor, book.TypeId, book.EntryDate, book.Status);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int bookId)
        {
            string query = string.Format("DELETE FROM Books WHERE BookId={0}", bookId);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Book book)
        {
            string query = string.Format("UPDATE Books SET BookName='{0}', BookAuthor='{1}', TypeId={2}, EntryDate='{3}', Status='{4}' WHERE BookId={5}", book.BookName, book.BookAuthor, book.TypeId, book.EntryDate, book.Status, book.BookId);
            return DataAccess.ExecuteQuery(query);
        }

        public List<Book> GetAll()
        {
            string query = "SELECT BookId, BookName, BookAuthor, TypeId, EntryDate, Status FROM Books";
            SqlDataReader reader = DataAccess.GetData(query);

            Book book = null;
            List<Book> bookList = new List<Book>();
            while (reader.Read())
            {
                book = new Book();
                book.BookId = Convert.ToInt32(reader["BookId"].ToString());
                book.BookName = reader["BookName"].ToString();
                book.BookAuthor = reader["BookAuthor"].ToString();
                book.TypeId = Convert.ToInt32(reader["TypeId"].ToString());
                book.EntryDate = reader["EntryDate"].ToString();
                book.Status = reader["Status"].ToString();

                bookList.Add(book);
            }
            return bookList;
        }

        public List<Book> GetByStatus(string status)
        {
            string query = string.Format("SELECT BookId, BookName, BookAuthor, TypeId, EntryDate, Status FROM Books WHERE Status='{0}'",status);
            SqlDataReader reader = DataAccess.GetData(query);

            Book book = null;
            List<Book> bookList = new List<Book>();
            while (reader.Read())
            {
                book = new Book();
                book.BookId = Convert.ToInt32(reader["BookId"].ToString());
                book.BookName = reader["BookName"].ToString();
                book.BookAuthor = reader["BookAuthor"].ToString();
                book.TypeId = Convert.ToInt32(reader["TypeId"].ToString());
                book.EntryDate = reader["EntryDate"].ToString();
                book.Status = reader["Status"].ToString();

                bookList.Add(book);
            }
            return bookList;
        }

        public Book GetById(int bookId)
        {
            string query = string.Format("SELECT BookId, BookName, BookAuthor, TypeId, EntryDate, Status FROM Books WHERE BookId={0}", bookId);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Book book = null;
            if (reader.HasRows)
            {
                book = new Book();
                book.BookId = Convert.ToInt32(reader["BookId"].ToString());
                book.BookName = reader["BookName"].ToString();
                book.BookAuthor = reader["BookAuthor"].ToString();
                book.TypeId = Convert.ToInt32(reader["TypeId"].ToString());
                book.EntryDate = reader["EntryDate"].ToString();
                book.Status = reader["Status"].ToString();
            }
            return book;
        }

        public Book GetByName(string bookName)
        {
            string query = string.Format("SELECT BookId, BookName, BookAuthor, TypeId, EntryDate, Status FROM Books WHERE BookName='{0}'", bookName);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Book book = null;
            if (reader.HasRows)
            {
                book = new Book();
                book.BookId = Convert.ToInt32(reader["BookId"].ToString());
                book.BookName = reader["BookName"].ToString();
                book.BookAuthor = reader["BookAuthor"].ToString();
                book.TypeId = Convert.ToInt32(reader["TypeId"].ToString());
                book.EntryDate = reader["EntryDate"].ToString();
                book.Status = reader["Status"].ToString();
            }
            return book;
        }
    }
}
