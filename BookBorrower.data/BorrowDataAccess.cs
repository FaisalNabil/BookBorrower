using System;
using System.Collections.Generic;
using BookBorrower.entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookBorrower.data
{
    public class BorrowDataAccess
    {
        public int Add(Borrow borrow)
        {
            string query = string.Format("INSERT INTO Borrow(BookId, BorrowerName, BorrowDate, ReturnDate, Comment) VALUES({0}, '{1}', '{2}', '{3}', '{4}')", borrow.BookId, borrow.BorrowerName, borrow.BorrowDate, borrow.ReturnDate, borrow.Comment);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int borrowId)
        {
            string query = string.Format("DELETE FROM Borrow WHERE BorrowId={0}", borrowId);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Borrow borrow)
        {
            string query = string.Format("UPDATE Borrow SET BookId={0}, BorrowerName='{1}', BorrowDate='{2}', ReturnDate='{3}', Comment='{4}' WHERE BorrowId={5}", borrow.BookId, borrow.BorrowerName, borrow.BorrowDate, borrow.ReturnDate, borrow.Comment, borrow.BorrowId);
            return DataAccess.ExecuteQuery(query);
        }
        
        public List<Borrow> GetAll()
        {
            string query = "SELECT BorrowId, BookId, BorrowerName, BorrowDate, ReturnDate, Comment FROM Borrow";
            SqlDataReader reader = DataAccess.GetData(query);

            Borrow borrow = null;
            List<Borrow> borrowList = new List<Borrow>();
            while (reader.Read())
            {
                borrow = new Borrow();
                borrow.BorrowId = Convert.ToInt32(reader["BorrowId"].ToString());
                borrow.BookId = Convert.ToInt32(reader["BookId"].ToString());
                borrow.BorrowerName = reader["BorrowerName"].ToString();
                borrow.BorrowDate = reader["BorrowDate"].ToString();
                borrow.ReturnDate = reader["ReturnDate"].ToString();
                borrow.Comment = reader["Comment"].ToString();

                borrowList.Add(borrow);
            }
            return borrowList;
        }

        public Borrow GetById(int borrowId)
        {
            string query = string.Format("SELECT BorrowId, BookId, BorrowerName, BorrowDate, ReturnDate, Comment FROM Borrow WHERE BorrowId={0}", borrowId);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Borrow borrow = null;
            if (reader.HasRows)
            {
                borrow = new Borrow();
                borrow.BorrowId = Convert.ToInt32(reader["BorrowId"].ToString());
                borrow.BookId = Convert.ToInt32(reader["BookId"].ToString());
                borrow.BorrowerName = reader["BorrowerName"].ToString();
                borrow.BorrowDate = reader["BorrowDate"].ToString();
                borrow.ReturnDate = reader["ReturnDate"].ToString();
                borrow.Comment = reader["Comment"].ToString();
            }
            return borrow;
        }

        public Borrow GetByBookId(int bookId)
        {
            string query = string.Format("SELECT BorrowId, BookId, BorrowerName, BorrowDate, ReturnDate, Comment FROM Borrow WHERE BookId={0} AND ReturnDate='' ", bookId);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Borrow borrow = null;
            if (reader.HasRows)
            {
                borrow = new Borrow();
                borrow.BorrowId = Convert.ToInt32(reader["BorrowId"].ToString());
                borrow.BookId = Convert.ToInt32(reader["BookId"].ToString());
                borrow.BorrowerName = reader["BorrowerName"].ToString();
                borrow.BorrowDate = reader["BorrowDate"].ToString();
                borrow.ReturnDate = reader["ReturnDate"].ToString();
                borrow.Comment = reader["Comment"].ToString();
            }
            return borrow;
        }

        public List<Borrow> GetAllByBookId(int bookId)
        {
            string query = string.Format("SELECT BorrowId, BookId, BorrowerName, BorrowDate, ReturnDate, Comment FROM Borrow WHERE BookId={0}", bookId);
            SqlDataReader reader = DataAccess.GetData(query);

            Borrow borrow = null;
            List<Borrow> borrowList = new List<Borrow>();
            while (reader.Read())
            {
                borrow = new Borrow();
                borrow.BorrowId = Convert.ToInt32(reader["BorrowId"].ToString());
                borrow.BookId = Convert.ToInt32(reader["BookId"].ToString());
                borrow.BorrowerName = reader["BorrowerName"].ToString();
                borrow.BorrowDate = reader["BorrowDate"].ToString();
                borrow.ReturnDate = reader["ReturnDate"].ToString();
                borrow.Comment = reader["Comment"].ToString();

                borrowList.Add(borrow);
            }
            return borrowList;
        }
    }
}
