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
    public partial class BookDetails : Form
    {
        IBookService bookService = new BookService();
        IBorrowService borrowService = new BorrowService();
        ITypesService typesService = new TypesService();

        int bookId;
        public BookDetails()
        {
            InitializeComponent();
        }

        public BookDetails(int bookId)
        {
            this.bookId = bookId;
            InitializeComponent();
        }

        #region Method

        private void loadBookData()
        {
            Book book = bookService.GetById(this.bookId);
            labelBookTitle.Text = book.BookName;
            labelBookAuthor.Text = book.BookAuthor;
            labelBookType.Text = typesService.GetById(book.TypeId).BookType;
        }

        private void loadHistoryData()
        {
            List<Borrow> borrowList = borrowService.GetAllByBookId(this.bookId);
            dataGridViewAllBorrowOfBook.AutoGenerateColumns = false;
            dataGridViewAllBorrowOfBook.DataSource = borrowList;
        }

        #endregion

        #region Events

        private void BookDetails_Load(object sender, EventArgs e)
        {
            this.loadBookData();
            this.loadHistoryData();
        }

        #endregion

    }
}
