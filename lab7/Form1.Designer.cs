namespace lab7
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
            listBoxBooks = new ListBox();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            lblPageNumber = new Label();
            label1 = new Label();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            lbl1 = new Label();
            btnAddBook = new Button();
            btnExportBooks = new Button();
            txtSearchTitle = new TextBox();
            btnSearchBooks = new Button();
            btnImportBooks = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(193, 148);
            listBoxBooks.Margin = new Padding(3, 4, 3, 4);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(521, 284);
            listBoxBooks.TabIndex = 0;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = Color.RosyBrown;
            btnPreviousPage.Location = new Point(250, 446);
            btnPreviousPage.Margin = new Padding(3, 4, 3, 4);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(115, 35);
            btnPreviousPage.TabIndex = 1;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.RosyBrown;
            btnNextPage.Location = new Point(550, 446);
            btnNextPage.Margin = new Padding(3, 4, 3, 4);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(115, 35);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.BackColor = Color.Transparent;
            lblPageNumber.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber.Location = new Point(430, 452);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(60, 23);
            lblPageNumber.TabIndex = 3;
            lblPageNumber.Text = "Page 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 80);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 4;
            label1.Text = "Author Name:";
            // 
            // txtAuthorName
            // 
            txtAuthorName.BackColor = Color.White;
            txtAuthorName.Location = new Point(69, 113);
            txtAuthorName.Margin = new Padding(3, 4, 3, 4);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(203, 27);
            txtAuthorName.TabIndex = 5;
            txtAuthorName.TextChanged += txtAuthorName_TextChanged;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BackColor = Color.White;
            txtBookTitle.Location = new Point(295, 113);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(215, 27);
            txtBookTitle.TabIndex = 7;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(269, 80);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(79, 20);
            lbl1.TabIndex = 6;
            lbl1.Text = "Book Title:";
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.RosyBrown;
            btnAddBook.Location = new Point(516, 105);
            btnAddBook.Margin = new Padding(3, 4, 3, 4);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(106, 35);
            btnAddBook.TabIndex = 8;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.BackColor = Color.RosyBrown;
            btnExportBooks.Location = new Point(628, 105);
            btnExportBooks.Margin = new Padding(3, 4, 3, 4);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(106, 35);
            btnExportBooks.TabIndex = 9;
            btnExportBooks.Text = "Export Books";
            btnExportBooks.UseVisualStyleBackColor = false;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(516, 56);
            txtSearchTitle.Margin = new Padding(3, 4, 3, 4);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(218, 27);
            txtSearchTitle.TabIndex = 10;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.BackColor = Color.RosyBrown;
            btnSearchBooks.Location = new Point(740, 52);
            btnSearchBooks.Margin = new Padding(3, 4, 3, 4);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(106, 35);
            btnSearchBooks.TabIndex = 11;
            btnSearchBooks.Text = "Search Books";
            btnSearchBooks.UseVisualStyleBackColor = false;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // btnImportBooks
            // 
            btnImportBooks.BackColor = Color.RosyBrown;
            btnImportBooks.Location = new Point(740, 105);
            btnImportBooks.Margin = new Padding(3, 4, 3, 4);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(106, 35);
            btnImportBooks.TabIndex = 12;
            btnImportBooks.Text = "Import Books";
            btnImportBooks.UseVisualStyleBackColor = false;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(934, 532);
            Controls.Add(btnImportBooks);
            Controls.Add(btnSearchBooks);
            Controls.Add(txtSearchTitle);
            Controls.Add(btnExportBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(lbl1);
            Controls.Add(txtAuthorName);
            Controls.Add(label1);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(listBoxBooks);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Label lblPageNumber;
        private Label label1;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Label lbl1;
        private Button btnAddBook;
        private Button btnExportBooks;
        private TextBox txtSearchTitle;
        private Button btnSearchBooks;
        private Button btnImportBooks;
    }
}