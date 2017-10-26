using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBorrower.entity;
using BookBorrower.service;
using System.Collections;

namespace BookBorrower.view
{
    public partial class BorrowList : Form
    {
        IBorrowService borrowService = new BorrowService();
        IBookService bookService = new BookService();
        public BorrowList()
        {
            InitializeComponent();
        }

        #region Methods

        public void LoadAllData()
        {
            dataGridViewAllBooks.AutoGenerateColumns = false;
            List<Book> bookList = bookService.GetByStatus("Borrowed");
            foreach (Book book in bookList)
            {
                Borrow borrow = borrowService.GetByBookId(book.BookId);

                dataGridViewAllBooks.Rows.Add(borrow.BorrowId, bookService.GetById(book.BookId).BookName, borrow.BorrowerName, borrow.BorrowDate);
            }
        }

        private void LoadComment(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewAllBooks.Columns[e.ColumnIndex].Name == "borrowReturn")
                {
                    int rowindex = dataGridViewAllBooks.CurrentCell.RowIndex;
                    BorrowComment borrowComment = new BorrowComment(this, Convert.ToInt32(dataGridViewAllBooks.Rows[rowindex].Cells["borrowId"].Value));
                    borrowComment.Show();
                }
            }catch(Exception ex)
            {

            }
         }

        #endregion

        #region Events

        private void BorrowList_Load(object sender, EventArgs e)
        {
            this.LoadAllData();
        }
        #endregion

        private void dataGridViewAllBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LoadComment(e);
        }
    }
}
