namespace BookBorrower.view
{
    partial class HomeControl
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
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            this.buttonAllBooks = new System.Windows.Forms.Button();
            this.buttonBorrowList = new System.Windows.Forms.Button();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonAllTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddBook.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAddBook.Location = new System.Drawing.Point(12, 12);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(267, 54);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.Text = "Add New Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBorrowBook.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrowBook.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBorrowBook.Location = new System.Drawing.Point(12, 72);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(267, 57);
            this.buttonBorrowBook.TabIndex = 1;
            this.buttonBorrowBook.Text = "Lend";
            this.buttonBorrowBook.UseVisualStyleBackColor = false;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // buttonAllBooks
            // 
            this.buttonAllBooks.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAllBooks.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllBooks.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAllBooks.Location = new System.Drawing.Point(12, 135);
            this.buttonAllBooks.Name = "buttonAllBooks";
            this.buttonAllBooks.Size = new System.Drawing.Size(129, 58);
            this.buttonAllBooks.TabIndex = 2;
            this.buttonAllBooks.Text = "All Books";
            this.buttonAllBooks.UseVisualStyleBackColor = false;
            this.buttonAllBooks.Click += new System.EventHandler(this.buttonAllBooks_Click);
            // 
            // buttonBorrowList
            // 
            this.buttonBorrowList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBorrowList.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrowList.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBorrowList.Location = new System.Drawing.Point(150, 135);
            this.buttonBorrowList.Name = "buttonBorrowList";
            this.buttonBorrowList.Size = new System.Drawing.Size(129, 58);
            this.buttonBorrowList.TabIndex = 3;
            this.buttonBorrowList.Text = "Lent List";
            this.buttonBorrowList.UseVisualStyleBackColor = false;
            this.buttonBorrowList.Click += new System.EventHandler(this.buttonBorrowList_Click);
            // 
            // buttonAddType
            // 
            this.buttonAddType.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAddType.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAddType.Location = new System.Drawing.Point(12, 259);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(129, 54);
            this.buttonAddType.TabIndex = 5;
            this.buttonAddType.Text = "Add Types";
            this.buttonAddType.UseVisualStyleBackColor = false;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonHistory.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonHistory.Location = new System.Drawing.Point(12, 199);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(267, 54);
            this.buttonHistory.TabIndex = 4;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonAllTypes
            // 
            this.buttonAllTypes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAllTypes.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTypes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAllTypes.Location = new System.Drawing.Point(150, 259);
            this.buttonAllTypes.Name = "buttonAllTypes";
            this.buttonAllTypes.Size = new System.Drawing.Size(129, 54);
            this.buttonAllTypes.TabIndex = 6;
            this.buttonAllTypes.Text = "All Types";
            this.buttonAllTypes.UseVisualStyleBackColor = false;
            this.buttonAllTypes.Click += new System.EventHandler(this.buttonAllTypes_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(291, 325);
            this.Controls.Add(this.buttonAllTypes);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonBorrowList);
            this.Controls.Add(this.buttonAllBooks);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.buttonAddBook);
            this.MaximizeBox = false;
            this.Name = "HomeControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controls Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonBorrowBook;
        private System.Windows.Forms.Button buttonAllBooks;
        private System.Windows.Forms.Button buttonBorrowList;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonAllTypes;
    }
}