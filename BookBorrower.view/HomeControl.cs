using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBorrower.view
{
    public partial class HomeControl : Form
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        #region Events
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.Show();
        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {
            AddBorrow addBorrow = new AddBorrow();
            addBorrow.Show();
        }

        private void buttonAllBooks_Click(object sender, EventArgs e)
        {
            AllBooks allBooks = new AllBooks();
            allBooks.Show();
        }

        private void buttonBorrowList_Click(object sender, EventArgs e)
        {
            BorrowList borrowList = new BorrowList();
            borrowList.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            BorrowHistory borrowHistory = new BorrowHistory();
            borrowHistory.Show();
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            AddTypes addTypes = new AddTypes();
            addTypes.Show();
        }

        private void buttonAllTypes_Click(object sender, EventArgs e)
        {
            AllTypes allTypes = new AllTypes();
            allTypes.Show();
        }
        #endregion
    }
}
