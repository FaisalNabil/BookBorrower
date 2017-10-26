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
    public partial class AddBooks : Form
    {
        IBookService bookService = new BookService();
        ITypesService typesService = new TypesService();

        public AddBooks()
        {
            InitializeComponent();
        }

        #region Methods
        private int bookTypeId()
        {
            int type = typesService.GetByName(comboBoxTypes.SelectedItem.ToString()).TypeId;
            return type;
        }

        private void addBookInformation()
        {
            Book book = new Book();
            book.BookName = textBoxBookTitle.Text;
            book.BookAuthor = textBoxBookAuthor.Text;
            book.TypeId = bookTypeId();
            book.Status = "Stock";

            DateTime thisDay = DateTime.Today;
            string entryYear = thisDay.Year.ToString();
            string entryMonth = thisDay.Month.ToString();
            string entryDay = thisDay.Day.ToString();

            book.EntryDate = entryDay + "-" + entryMonth + "-" + entryYear;

            if (bookService.Add(book) == 1)
            {
                MessageBox.Show("Book Successfully Added :)");
            }
            else
            {
                MessageBox.Show("Book Could not be Added !!");
            }
        }
        #endregion

        #region Events
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (textBoxBookTitle.Text != null || textBoxBookAuthor.Text != null)
            {
                try
                {
                    this.addBookInformation();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please select a type", "Error!!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the informations properly","Error!!");
            }
        }


        private void AddBooks_Load(object sender, EventArgs e)
        {
            comboBoxTypes.Items.Clear();
            List<Types> typesList = typesService.GetAll();
            foreach (Types types in typesList)
            {
                comboBoxTypes.Items.Add(types.BookType);
            }
        }
        #endregion

    }
}
