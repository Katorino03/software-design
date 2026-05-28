namespace lab6
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            btnSearchBooks = new Button();
            txtSearchTitle = new TextBox();
            progressBar = new ProgressBar();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Anchor = AnchorStyles.None;
            btnFetchBooks.BackColor = Color.RosyBrown;
            btnFetchBooks.ForeColor = SystemColors.ButtonHighlight;
            btnFetchBooks.Location = new Point(771, 255);
            btnFetchBooks.Margin = new Padding(3, 4, 3, 4);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(121, 44);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = false;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Anchor = AnchorStyles.None;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(399, 84);
            listBoxBooks.Margin = new Padding(3, 4, 3, 4);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(366, 164);
            listBoxBooks.TabIndex = 1;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Anchor = AnchorStyles.None;
            txtAuthorName.Location = new Point(91, 85);
            txtAuthorName.Margin = new Padding(3, 4, 3, 4);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(196, 27);
            txtAuthorName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(91, 61);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Author's Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(91, 116);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Book Title:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Anchor = AnchorStyles.None;
            txtBookTitle.Location = new Point(91, 140);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(196, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.None;
            btnAddBook.BackColor = Color.RosyBrown;
            btnAddBook.ForeColor = SystemColors.ButtonHighlight;
            btnAddBook.Location = new Point(293, 140);
            btnAddBook.Margin = new Padding(3, 4, 3, 4);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(96, 27);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(91, 188);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 8;
            label3.Text = "Book ID:";
            // 
            // txtBookID
            // 
            txtBookID.Anchor = AnchorStyles.None;
            txtBookID.Location = new Point(116, 212);
            txtBookID.Margin = new Padding(3, 4, 3, 4);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(196, 27);
            txtBookID.TabIndex = 7;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Anchor = AnchorStyles.None;
            btnSearchBooks.BackColor = Color.RosyBrown;
            btnSearchBooks.ForeColor = SystemColors.ButtonHighlight;
            btnSearchBooks.Location = new Point(771, 44);
            btnSearchBooks.Margin = new Padding(3, 4, 3, 4);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(121, 37);
            btnSearchBooks.TabIndex = 9;
            btnSearchBooks.Text = "Search";
            btnSearchBooks.UseVisualStyleBackColor = false;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Anchor = AnchorStyles.None;
            txtSearchTitle.Location = new Point(399, 49);
            txtSearchTitle.Margin = new Padding(3, 4, 3, 4);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(366, 27);
            txtSearchTitle.TabIndex = 10;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.None;
            progressBar.BackColor = Color.White;
            progressBar.Location = new Point(399, 264);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(366, 35);
            progressBar.TabIndex = 11;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Anchor = AnchorStyles.None;
            btnUpdateBook.BackColor = Color.RosyBrown;
            btnUpdateBook.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateBook.Location = new Point(80, 255);
            btnUpdateBook.Margin = new Padding(3, 4, 3, 4);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(121, 44);
            btnUpdateBook.TabIndex = 12;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.None;
            btnDeleteBook.BackColor = Color.RosyBrown;
            btnDeleteBook.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteBook.Location = new Point(233, 255);
            btnDeleteBook.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(121, 44);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(982, 381);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(progressBar);
            Controls.Add(txtSearchTitle);
            Controls.Add(btnSearchBooks);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtBookTitle);
            Controls.Add(label1);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Padding = new Padding(100, 80, 0, 10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private Label label1;
        private Label label2;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Label label3;
        private TextBox txtBookID;
        private Button btnSearchBooks;
        private TextBox txtSearchTitle;
        private ProgressBar progressBar;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
    }
}