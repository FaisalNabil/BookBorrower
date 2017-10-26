namespace BookBorrower.view
{
    partial class BorrowList
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
            this.borrowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowReturn = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.borrowId,
            this.bookTitle,
            this.borrowerName,
            this.borrowDate,
            this.borrowReturn});
            this.dataGridViewAllBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAllBooks.Name = "dataGridViewAllBooks";
            this.dataGridViewAllBooks.Size = new System.Drawing.Size(721, 419);
            this.dataGridViewAllBooks.TabIndex = 2;
            this.dataGridViewAllBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllBooks_CellContentClick);
            // 
            // borrowId
            // 
            this.borrowId.DataPropertyName = "BorrowId";
            this.borrowId.HeaderText = "Borrow Id";
            this.borrowId.Name = "borrowId";
            this.borrowId.ReadOnly = true;
            // 
            // bookTitle
            // 
            this.bookTitle.DataPropertyName = "BookTitle";
            this.bookTitle.HeaderText = "Book Title";
            this.bookTitle.Name = "bookTitle";
            // 
            // borrowerName
            // 
            this.borrowerName.DataPropertyName = "BorrowerName";
            this.borrowerName.HeaderText = "Borrower Name";
            this.borrowerName.Name = "borrowerName";
            // 
            // borrowDate
            // 
            this.borrowDate.DataPropertyName = "BorrowDate";
            this.borrowDate.HeaderText = "Date of Borrow";
            this.borrowDate.Name = "borrowDate";
            // 
            // borrowReturn
            // 
            this.borrowReturn.HeaderText = "Mark Returned";
            this.borrowReturn.Name = "borrowReturn";
            // 
            // BorrowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(745, 443);
            this.Controls.Add(this.dataGridViewAllBooks);
            this.MaximizeBox = false;
            this.Name = "BorrowList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Borrow List";
            this.Load += new System.EventHandler(this.BorrowList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDate;
        private System.Windows.Forms.DataGridViewButtonColumn borrowReturn;
    }
}