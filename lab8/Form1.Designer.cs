using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace lab8
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
            txtISBN = new TextBox();
            label1 = new Label();
            btnFetchBook = new Button();
            txtBookDetails = new TextBox();
            btnSearchAuthor = new Button();
            txtAuthorSearch = new TextBox();
            listBoxBooks = new ListBox();
            btnPrevApiPage = new Button();
            btnNextApiPage = new Button();
            lblPageNumber = new Label();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.Anchor = AnchorStyles.None;
            txtISBN.Location = new Point(49, 41);
            txtISBN.Margin = new Padding(3, 4, 3, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(181, 27);
            txtISBN.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 17);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "ISBN:";
            label1.Click += label1_Click;
            // 
            // btnFetchBook
            // 
            btnFetchBook.Anchor = AnchorStyles.None;
            btnFetchBook.BackColor = Color.RosyBrown;
            btnFetchBook.Location = new Point(237, 41);
            btnFetchBook.Margin = new Padding(3, 4, 3, 4);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(109, 31);
            btnFetchBook.TabIndex = 2;
            btnFetchBook.Text = "Fetch Book";
            btnFetchBook.UseVisualStyleBackColor = false;
            btnFetchBook.Click += btnFetchBook_Click;
            // 
            // txtBookDetails
            // 
            txtBookDetails.Anchor = AnchorStyles.None;
            txtBookDetails.Location = new Point(49, 80);
            txtBookDetails.Margin = new Padding(3, 4, 3, 4);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.Size = new Size(297, 265);
            txtBookDetails.TabIndex = 3;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Anchor = AnchorStyles.None;
            btnSearchAuthor.BackColor = Color.RosyBrown;
            btnSearchAuthor.Location = new Point(238, 357);
            btnSearchAuthor.Margin = new Padding(3, 4, 3, 4);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(109, 31);
            btnSearchAuthor.TabIndex = 5;
            btnSearchAuthor.Text = "Search Author";
            btnSearchAuthor.UseVisualStyleBackColor = false;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // txtAuthorSearch
            // 
            txtAuthorSearch.Anchor = AnchorStyles.None;
            txtAuthorSearch.Location = new Point(49, 357);
            txtAuthorSearch.Margin = new Padding(3, 4, 3, 4);
            txtAuthorSearch.Name = "txtAuthorSearch";
            txtAuthorSearch.Size = new Size(181, 27);
            txtAuthorSearch.TabIndex = 4;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Anchor = AnchorStyles.None;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(49, 402);
            listBoxBooks.Margin = new Padding(3, 4, 3, 4);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(297, 264);
            listBoxBooks.TabIndex = 6;
            // 
            // btnPrevApiPage
            // 
            btnPrevApiPage.Anchor = AnchorStyles.None;
            btnPrevApiPage.BackColor = Color.RosyBrown;
            btnPrevApiPage.Location = new Point(49, 676);
            btnPrevApiPage.Margin = new Padding(3, 4, 3, 4);
            btnPrevApiPage.Name = "btnPrevApiPage";
            btnPrevApiPage.Size = new Size(109, 31);
            btnPrevApiPage.TabIndex = 7;
            btnPrevApiPage.Text = "Previous Page";
            btnPrevApiPage.UseVisualStyleBackColor = false;
            btnPrevApiPage.Click += btnPrevApiPage_Click;
            // 
            // btnNextApiPage
            // 
            btnNextApiPage.Anchor = AnchorStyles.None;
            btnNextApiPage.BackColor = Color.RosyBrown;
            btnNextApiPage.Location = new Point(238, 676);
            btnNextApiPage.Margin = new Padding(3, 4, 3, 4);
            btnNextApiPage.Name = "btnNextApiPage";
            btnNextApiPage.Size = new Size(109, 31);
            btnNextApiPage.TabIndex = 8;
            btnNextApiPage.Text = "Next Page";
            btnNextApiPage.UseVisualStyleBackColor = false;
            btnNextApiPage.Click += btnNextApiPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.Anchor = AnchorStyles.None;
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber.Location = new Point(171, 681);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(53, 20);
            lblPageNumber.TabIndex = 9;
            lblPageNumber.Text = "Page 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(409, 726);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNextApiPage);
            Controls.Add(btnPrevApiPage);
            Controls.Add(listBoxBooks);
            Controls.Add(btnSearchAuthor);
            Controls.Add(txtAuthorSearch);
            Controls.Add(txtBookDetails);
            Controls.Add(btnFetchBook);
            Controls.Add(label1);
            Controls.Add(txtISBN);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtISBN;
        private Label label1;
        private Button btnFetchBook;
        private TextBox txtBookDetails;
        private Button btnSearchAuthor;
        private TextBox txtAuthorSearch;
        private ListBox listBoxBooks;
        private Button btnPrevApiPage;
        private Button btnNextApiPage;
        private Label lblPageNumber;
    }
}