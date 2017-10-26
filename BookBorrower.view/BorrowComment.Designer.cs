namespace BookBorrower.view
{
    partial class BorrowComment
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
            this.textBoxBorrowComment = new System.Windows.Forms.TextBox();
            this.buttonBorrowCommentOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comment";
            // 
            // textBoxBorrowComment
            // 
            this.textBoxBorrowComment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorrowComment.Location = new System.Drawing.Point(16, 47);
            this.textBoxBorrowComment.Multiline = true;
            this.textBoxBorrowComment.Name = "textBoxBorrowComment";
            this.textBoxBorrowComment.Size = new System.Drawing.Size(256, 139);
            this.textBoxBorrowComment.TabIndex = 5;
            // 
            // buttonBorrowCommentOk
            // 
            this.buttonBorrowCommentOk.BackColor = System.Drawing.Color.MintCream;
            this.buttonBorrowCommentOk.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrowCommentOk.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBorrowCommentOk.Location = new System.Drawing.Point(161, 192);
            this.buttonBorrowCommentOk.Name = "buttonBorrowCommentOk";
            this.buttonBorrowCommentOk.Size = new System.Drawing.Size(111, 43);
            this.buttonBorrowCommentOk.TabIndex = 10;
            this.buttonBorrowCommentOk.Text = "OK";
            this.buttonBorrowCommentOk.UseVisualStyleBackColor = false;
            this.buttonBorrowCommentOk.Click += new System.EventHandler(this.buttonBorrowCommentOk_Click);
            // 
            // BorrowComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.Controls.Add(this.buttonBorrowCommentOk);
            this.Controls.Add(this.textBoxBorrowComment);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BorrowComment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBorrowComment;
        private System.Windows.Forms.Button buttonBorrowCommentOk;
    }
}