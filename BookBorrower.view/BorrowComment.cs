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
    public partial class BorrowComment : Form
    {
        IBorrowService borrowService = new BorrowService();
        IBookService bookService = new BookService();
        private readonly BorrowList borrowList;
        int borrowId = 0;

        public BorrowComment(BorrowList borrowListfromBorrowList, int borrowIdfromBorrowList)
        {
            InitializeComponent();
            borrowList = borrowListfromBorrowList;
            borrowId = borrowIdfromBorrowList;
        }

        #region Methods

        private void comment()
        {
            Borrow borrow = borrowService.GetById(borrowId);
            borrow.Comment = textBoxBorrowComment.Text;

            DateTime thisDay = DateTime.Today;
            string returnYear = thisDay.Year.ToString();
            string returnMonth = thisDay.Month.ToString();
            string returnDay = thisDay.Day.ToString();

            borrow.ReturnDate = returnDay + "-" + returnMonth + "-" + returnYear;

            if(borrowService.Edit(borrow) == 1)
            {
                Book book = bookService.GetById(borrow.BookId);
                book.Status = "Stock";
                if (bookService.Edit(book) == 1)
                {
                    MessageBox.Show("Book Return Successfull!");
                    this.borrowList.LoadAllData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An Error Occured!");
                }
            }
        }

        #endregion

        #region Events
        private void buttonBorrowCommentOk_Click(object sender, EventArgs e)
        {
            this.comment();
        }
        #endregion
    }
}
