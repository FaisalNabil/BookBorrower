namespace BookBorrower.view
{
    partial class AddBorrow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBorrowerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBorrow = new System.Windows.Forms.DateTimePicker();
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Title";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookTitle.Location = new System.Drawing.Point(116, 6);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(406, 29);
            this.textBoxBookTitle.TabIndex = 4;
            this.textBoxBookTitle.TextChanged += new System.EventHandler(this.textBoxBookTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Borrower Name";
            // 
            // textBoxBorrowerName
            // 
            this.textBoxBorrowerName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorrowerName.Location = new System.Drawing.Point(148, 51);
            this.textBoxBorrowerName.Name = "textBoxBorrowerName";
            this.textBoxBorrowerName.Size = new System.Drawing.Size(374, 29);
            this.textBoxBorrowerName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date";
            // 
            // dateTimePickerBorrow
            // 
            this.dateTimePickerBorrow.CalendarFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBorrow.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBorrow.Location = new System.Drawing.Point(116, 106);
            this.dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            this.dateTimePickerBorrow.Size = new System.Drawing.Size(235, 25);
            this.dateTimePickerBorrow.TabIndex = 8;
            // 
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.BackColor = System.Drawing.Color.MintCream;
            this.buttonBorrowBook.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrowBook.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBorrowBook.Location = new System.Drawing.Point(408, 149);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(111, 43);
            this.buttonBorrowBook.TabIndex = 9;
            this.buttonBorrowBook.Text = "Lend";
            this.buttonBorrowBook.UseVisualStyleBackColor = false;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // AddBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(531, 204);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.dateTimePickerBorrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBorrowerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddBorrow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBorrowerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrow;
        private System.Windows.Forms.Button buttonBorrowBook;
    }
}