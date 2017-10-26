namespace BookBorrower.view
{
    partial class AllBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAllBooks = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllBooks
            // 
            this.dataGridViewAllBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookName,
            this.bookAuthor,
            this.entryDate,
            this.bookType,
            this.status,
            this.bookEdit,
            this.bookDelete,
            this.bookDetails});
            this.dataGridViewAllBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAllBooks.Name = "dataGridViewAllBooks";
            this.dataGridViewAllBooks.Size = new System.Drawing.Size(860, 328);
            this.dataGridViewAllBooks.TabIndex = 0;
            this.dataGridViewAllBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllBooks_CellContentClick);
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "BookId";
            this.bookId.HeaderText = "Book Id";
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            this.bookId.Visible = false;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "BookName";
            this.bookName.HeaderText = "Name";
            this.bookName.Name = "bookName";
            // 
            // bookAuthor
            // 
            this.bookAuthor.DataPropertyName = "BookAuthor";
            this.bookAuthor.HeaderText = "Author";
            this.bookAuthor.Name = "bookAuthor";
            // 
            // entryDate
            // 
            this.entryDate.DataPropertyName = "EntryDate";
            this.entryDate.HeaderText = "Entry Date";
            this.entryDate.Name = "entryDate";
            this.entryDate.ReadOnly = true;
            // 
            // bookType
            // 
            this.bookType.HeaderText = "Type";
            this.bookType.Name = "bookType";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // bookEdit
            // 
            this.bookEdit.HeaderText = "Edit";
            this.bookEdit.Name = "bookEdit";
            // 
            // bookDelete
            // 
            this.bookDelete.HeaderText = "Delete";
            this.bookDelete.Name = "bookDelete";
            // 
            // bookDetails
            // 
            this.bookDetails.HeaderText = "Details";
            this.bookDetails.Name = "bookDetails";
            this.bookDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(884, 352);
            this.Controls.Add(this.dataGridViewAllBooks);
            this.MaximizeBox = false;
            this.Name = "AllBooks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book List";
            this.Load += new System.EventHandler(this.AllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn bookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn bookEdit;
        private System.Windows.Forms.DataGridViewButtonColumn bookDelete;
        private System.Windows.Forms.DataGridViewButtonColumn bookDetails;
    }
}