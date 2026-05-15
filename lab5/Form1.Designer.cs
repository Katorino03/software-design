namespace lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            btnShowBooks = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            txtSearchAuthor = new TextBox();
            btnSearchBooks = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtAuthorName.Location = new Point(170, 155);
            txtAuthorName.Margin = new Padding(3, 4, 3, 4);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(241, 34);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtBookTitle.Location = new Point(597, 158);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(241, 34);
            txtBookTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 158);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 2;
            label1.Text = "Author's Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(478, 164);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 3;
            label2.Text = "Book Title";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(65, 215);
            listBoxBooks.Margin = new Padding(3, 4, 3, 4);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(773, 284);
            listBoxBooks.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.RosyBrown;
            btnAddBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = SystemColors.ButtonHighlight;
            btnAddBook.Location = new Point(124, 30);
            btnAddBook.Margin = new Padding(3, 4, 3, 4);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(122, 45);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.BackColor = Color.RosyBrown;
            btnShowBooks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowBooks.ForeColor = SystemColors.ButtonHighlight;
            btnShowBooks.Location = new Point(279, 30);
            btnShowBooks.Margin = new Padding(3, 4, 3, 4);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(132, 45);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = false;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 103);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 8;
            label3.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.BackColor = SystemColors.Window;
            txtBookID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtBookID.Location = new Point(170, 97);
            txtBookID.Margin = new Padding(3, 4, 3, 4);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(241, 34);
            txtBookID.TabIndex = 7;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BackColor = Color.RosyBrown;
            btnUpdateBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBook.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateBook.Location = new Point(455, 30);
            btnUpdateBook.Margin = new Padding(3, 4, 3, 4);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(143, 45);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.RosyBrown;
            btnDeleteBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteBook.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteBook.Location = new Point(612, 30);
            btnDeleteBook.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(142, 45);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtSearchAuthor.Location = new Point(597, 97);
            txtSearchAuthor.Margin = new Padding(3, 4, 3, 4);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(241, 34);
            txtSearchAuthor.TabIndex = 11;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBooks.Location = new Point(455, 100);
            btnSearchBooks.Margin = new Padding(3, 4, 3, 4);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(127, 33);
            btnSearchBooks.TabIndex = 12;
            btnSearchBooks.Text = "Search by Author";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(906, 520);
            Controls.Add(btnSearchBooks);
            Controls.Add(txtSearchAuthor);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnShowBooks);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore System";
            Click += btnAddBook_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Label label1;
        private Label label2;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Button btnShowBooks;
        private Label label3;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private TextBox txtSearchAuthor;
        private Button btnSearchBooks;
    }
}