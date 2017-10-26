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
    public partial class AddBorrow : Form
    {
        IBookService bookService = new BookService();
        IBorrowService borrowService = new BorrowService();

        public AddBorrow()
        {
            InitializeComponent();
        }

        #region Methods

        private void textAutoComplete()
        {
            textBoxBookTitle.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxBookTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            List<Book> bookList = bookService.GetAll();

            foreach (Book book in bookList)
            {
                col.Add(book.BookName.ToString());
            }

            textBoxBookTitle.AutoCompleteCustomSource = col;
        }

        private int getBookId(string bookName)
        {
            Book book = bookService.GetByName(bookName);
            return book.BookId;
        }

        private void addBorrowData()
        {
            Borrow borrow = new Borrow();
            borrow.BookId = getBookId(textBoxBookTitle.Text);
            borrow.BorrowerName = textBoxBorrowerName.Text;
            borrow.BorrowDate = dateTimePickerBorrow.Value.ToString("dd-MM-yyyy");
            borrow.ReturnDate = "";
            borrow.Comment = "";

            if(borrowService.Add(borrow) == 1)
            {
                Book book = bookService.GetById(borrow.BookId);
                book.Status = "Borrowed";
                if(bookService.Edit(book) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Book borrow failed!!");
                }
            }else
            {
                MessageBox.Show("Book borrow failed!!");
            }
        }

        #endregion

        #region Events
        private void textBoxBookTitle_TextChanged(object sender, EventArgs e)
        {
            this.textAutoComplete();
        }
        
        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxBookTitle.Text) || !string.IsNullOrEmpty(textBoxBorrowerName.Text))
            {
                this.addBorrowData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill the informations properly", "Error!!");
            }
        }
        #endregion
        
    }
}
