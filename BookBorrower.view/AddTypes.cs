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
    public partial class AddTypes : Form
    {
        ITypesService typeService = new TypesService();
        
        public AddTypes()
        {
            InitializeComponent();
        }

        #region Methods

        private void addTypes()
        {
            Types types = new Types();
            types.BookType = textBoxType.Text;

            typeService.Add(types);
        }

        #endregion

        #region Events
        private void buttonAddType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxType.Text))
            {
                this.addTypes();
                MessageBox.Show("Type Added");
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
