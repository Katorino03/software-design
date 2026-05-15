using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                // Create a new author
                var author = new Author { Name = authorName };
                // Create a new book and associate it with the author
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author); // Add the author to the context
                context.Books.Add(book);     // Add the book to the context
                context.SaveChanges();       // Save all changes to the database
            }
        }

        public List<string> GetBooksWIthAuthors()
        {
            using (var context = new BookstoreContext())
            {
                // Use Entity Framework's Include method to load authors with books
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return booksWithAuthors;
            }
        }

        // Button click event to display books and authors
        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWIthAuthors();
            listBoxBooks.DataSource = books; // Display the list of books in the ListBox
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            string bookTitle = txtBookTitle.Text;

            if (!string.IsNullOrWhiteSpace(authorName) && !string.IsNullOrWhiteSpace(bookTitle))
            {
                AddAuthorWithBook(authorName, bookTitle);

                MessageBox.Show("Book and Author saved to database!");

                txtAuthorName.Clear();
                txtBookTitle.Clear();
            }
            else
            {
                MessageBox.Show("Please enter both an author name and a book title.");
            }
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);

                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges(); 
                }
            }
        }

     
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully.");
        }

        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var bookToDelete = context.Books.FirstOrDefault(b => b.BookID == bookId);

                if (bookToDelete != null)
                {
                    context.Books.Remove(bookToDelete);
                    context.SaveChanges();
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!");

                btnShowBooks_Click(sender, e);

                txtBookID.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID to delete.");
            }
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var searchResults = context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.Title} by {b.Author.Name} (ID: {b.BookID})")
                    .ToList();

                return searchResults;
            }
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchAuthor.Text;

            if (!string.IsNullOrWhiteSpace(searchName))
            {
                var filteredBooks = SearchBooksByAuthor(searchName);

                listBoxBooks.DataSource = filteredBooks;

                if (filteredBooks.Count == 0)
                {
                    MessageBox.Show("No books found for that author.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an author name to search.");
            }
        }
    }
}