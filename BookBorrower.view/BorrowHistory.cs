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

namespace BookBorrower.view
{
    public partial class BorrowHistory : Form
    {
        IBorrowService borrowService = new BorrowService();
        IBookService bookService = new BookService();
        public BorrowHistory()
        {
            InitializeComponent();
        }

        #region Methods

        private void loadData()
        {
            dataGridViewAllBooks.AutoGenerateColumns = false;
            List<Borrow> borrowList = borrowService.GetAll();
            foreach (Borrow borrow in borrowList)
            {
                Book book = bookService.GetById(borrow.BookId);
                dataGridViewAllBooks.Rows.Add(borrow.BorrowId, book.BookName, borrow.BorrowerName, borrow.BorrowDate, borrow.ReturnDate, borrow.Comment);
            }
        }

        #endregion

        #region Events

        private void BorrowHistory_Load(object sender, EventArgs e)
        {
            this.loadData();
        }
        #endregion

    }
}
