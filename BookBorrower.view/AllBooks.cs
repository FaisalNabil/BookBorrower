using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookBorrower.entity;
using BookBorrower.service;

namespace BookBorrower.view
{
    public partial class AllBooks : Form
    {
        IBookService bookService = new BookService();
        ITypesService typesService = new TypesService();
        public AllBooks()
        {
            InitializeComponent();
        }

        #region Methods

        private void loadAllBooks()
        {
            dataGridViewAllBooks.AutoGenerateColumns = false;
            dataGridViewAllBooks.DataSource = bookService.GetAll();

            ComboBox tempCombobox = new ComboBox();
            List<Types> typesList = typesService.GetAll();
            foreach (Types types in typesList)
            {
                tempCombobox.Items.Add(types.BookType);
            }
            ((DataGridViewComboBoxColumn)dataGridViewAllBooks.Columns["bookType"]).DataSource = tempCombobox.Items;

            for (int i = 0; i < dataGridViewAllBooks.Rows.Count; i++)
            {
                int typeId = bookService.GetById(Convert.ToInt32(dataGridViewAllBooks.Rows[i].Cells["bookId"].Value)).TypeId;
                
                dataGridViewAllBooks.Rows[i].Cells["bookType"].Value = typesService.GetById(typeId).BookType;
            }
        }

        private int bookTypeId(int rowindex)
        {
            int type = typesService.GetByName(dataGridViewAllBooks.Rows[rowindex].Cells["bookType"].Value.ToString()).TypeId;
            return type;
        }

        private void bookEditDelete(DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dataGridViewAllBooks.Columns[e.ColumnIndex].Name == "bookEdit")
                {
                    DialogResult dialogResultEdit = MessageBox.Show("Are you Sure?", "Change information", MessageBoxButtons.YesNo);
                    if (dialogResultEdit == DialogResult.Yes)
                    {
                        int rowindex = dataGridViewAllBooks.CurrentCell.RowIndex;

                        Book book = new Book();
                        book.BookId = Convert.ToInt32(dataGridViewAllBooks.Rows[rowindex].Cells["bookId"].Value);
                        book.BookName = dataGridViewAllBooks.Rows[rowindex].Cells["bookName"].Value.ToString();
                        book.BookAuthor = dataGridViewAllBooks.Rows[rowindex].Cells["bookAuthor"].Value.ToString();
                        book.EntryDate = dataGridViewAllBooks.Rows[rowindex].Cells["entryDate"].Value.ToString();
                        book.TypeId = bookTypeId(rowindex);
                        book.Status = dataGridViewAllBooks.Rows[rowindex].Cells["status"].Value.ToString();

                        if (bookService.Edit(book) == 1)
                        {
                            MessageBox.Show("Successfully Updated book");
                        }
                        else
                        {
                            MessageBox.Show("Could Not Update book");
                        }
                    };
                }

                
                if (dataGridViewAllBooks.Columns[e.ColumnIndex].Name == "bookDelete")
                {
                    DialogResult dialogResultDelete = MessageBox.Show("Are you Sure?", "Delete information", MessageBoxButtons.YesNo);
                    if (dialogResultDelete == DialogResult.Yes)
                    {
                        int rowindex = dataGridViewAllBooks.CurrentCell.RowIndex;

                        int bookId = Convert.ToInt32(dataGridViewAllBooks.Rows[rowindex].Cells["bookId"].Value);

                        if (bookService.Remove(bookId) == 1)
                        {
                            MessageBox.Show("Successfully Removed book");
                            this.loadAllBooks();
                        }
                        else
                        {
                            MessageBox.Show("Could Not Removed book");
                        }
                    };
                }

                if (dataGridViewAllBooks.Columns[e.ColumnIndex].Name == "bookDetails") 
                {
                    int rowindex = dataGridViewAllBooks.CurrentCell.RowIndex;

                    int bookId = Convert.ToInt32(dataGridViewAllBooks.Rows[rowindex].Cells["bookId"].Value);
                    BookDetails bookDetails = new BookDetails(bookId);
                    bookDetails.Show();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Select TYPE and STATUS");
            }
        }

        #endregion

        #region Events

        private void AllBooks_Load(object sender, EventArgs e)
        {
            this.loadAllBooks();
        }

        private void dataGridViewAllBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bookEditDelete(e);
        }
        #endregion

    }
}
