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
    public partial class AllTypes : Form
    {
        ITypesService typeService = new TypesService();

        public AllTypes()
        {
            InitializeComponent();
        }

        #region Methods

        private void loadData()
        {
            dataGridViewAllBooks.AutoGenerateColumns = false;
            dataGridViewAllBooks.DataSource = typeService.GetAll();
        }

        private void editOrDelete(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewAllBooks.Columns[e.ColumnIndex].Name == "bookEdit")
                {
                    int rowindex = dataGridViewAllBooks.CurrentCell.RowIndex;

                    Types types = new Types();
                    types.TypeId = Convert.ToInt32(dataGridViewAllBooks.Rows[rowindex].Cells["typeId"].Value);
                    types.BookType = dataGridViewAllBooks.Rows[rowindex].Cells["bookType"].Value.ToString();

                    if (typeService.Edit(types) == 1)
                    {
                        MessageBox.Show("Successfully Update Type Name");
                    }
                    else
                    {
                        MessageBox.Show("Could Not Update Type Name");
                    }
                }
                if (dataGridViewAllBooks.Columns[e.ColumnIndex].Name == "bookDelete")
                {
                    int rowindex = dataGridViewAllBooks.CurrentCell.RowIndex;

                    int typeId = Convert.ToInt32(dataGridViewAllBooks.Rows[rowindex].Cells["typeId"].Value);

                    if (typeService.Remove(typeId) == 1)
                    {
                        MessageBox.Show("Successfully Removed Type Name");
                        this.loadData();
                    }
                    else
                    {
                        MessageBox.Show("Could Not Removed Type Name");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!!");
            }
        }

        #endregion

        #region Events

        private void AllTypes_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void dataGridViewAllBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Change information", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.editOrDelete(e);
            };
        }
        #endregion


    }
}
