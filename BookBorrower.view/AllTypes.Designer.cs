namespace BookBorrower.view
{
    partial class AllTypes
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
            this.typeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bookDelete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.typeId,
            this.bookType,
            this.bookEdit,
            this.bookDelete});
            this.dataGridViewAllBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAllBooks.Name = "dataGridViewAllBooks";
            this.dataGridViewAllBooks.Size = new System.Drawing.Size(342, 237);
            this.dataGridViewAllBooks.TabIndex = 1;
            this.dataGridViewAllBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllBooks_CellContentClick);
            // 
            // typeId
            // 
            this.typeId.DataPropertyName = "TypeId";
            this.typeId.HeaderText = "Id";
            this.typeId.Name = "typeId";
            this.typeId.ReadOnly = true;
            this.typeId.Visible = false;
            // 
            // bookType
            // 
            this.bookType.DataPropertyName = "BookType";
            this.bookType.HeaderText = "Type";
            this.bookType.Name = "bookType";
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
            // AllTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.dataGridViewAllBooks);
            this.MaximizeBox = false;
            this.Name = "AllTypes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Types List";
            this.Load += new System.EventHandler(this.AllTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookType;
        private System.Windows.Forms.DataGridViewButtonColumn bookEdit;
        private System.Windows.Forms.DataGridViewButtonColumn bookDelete;
    }
}