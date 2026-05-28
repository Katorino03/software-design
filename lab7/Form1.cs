using lab5;
using Microsoft.EntityFrameworkCore;
using System.Web;
using static lab5.Form1;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Set the number of records per page
        private const int pageSize = 10;
        private int currentPage = 1;

        // Asynchronous method to fetch a specific page of books
        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                // Skip records and take the next pageSize records for the current page
                var books = await context.Books
                                         .Include(b => b.Author)
                                         .OrderBy(b => b.BookID)
                                         .Skip((pageNumber - 1) * pageSize)
                                         .Take(pageSize)
                                         .Select(b => $"{b.Title} by {b.Author.Name}")
                                         .ToListAsync();
                return books;
            }
        }

        // Button click event to load the next page of books
        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        // Button click event to load the previous page of books
        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }
            else
            {
                MessageBox.Show("You are already on the first page.");
            }
        }

        // Asynchronous method to save a new book and author with error handling
        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    // Save changes asynchronously
                    await context.SaveChangesAsync();

                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Button click event to trigger saving with error handling
        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookWithHandlingAsync(bookTitle, authorName);
        }

        // Asynchronous methodto to export book data to a text file
        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage); // Get the current page of books
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book); // Write each book to the file asynchronously
                }

            }
        }

        // Button click event to export books asynchronously
        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully!");
            }
        }

        // Asynchronous method to search books by title with error handling
        public async Task SearchBooksWithHandlingAsync(string searchTitle)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var searchResults = await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(searchTitle))
                        .Select(b => $"{b.Title} by {b.Author.Name}")
                        .ToListAsync();

                    listBoxBooks.DataSource = searchResults;

                    if (searchResults.Count == 0)
                    {
                        MessageBox.Show("No books found matching that title.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search: {ex.Message}");
            }
        }

        // Button click event to trigger the search
        private async void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearchTitle.Text;

            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                await SearchBooksWithHandlingAsync(searchTitle);
            }
            else
            {
                MessageBox.Show("Please enter a title to search for.");
            }
        }

        // Asynchronous method to import books from a text file
        public async Task ImportBooksAsync(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                using (var context = new BookstoreContext())
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        string[] parts = line.Split(new[] { " by " }, StringSplitOptions.None);

                        if (parts.Length == 2)
                        {
                            string bookTitle = parts[0].Trim();
                            string authorName = parts[1].Trim();

                            var author = new Author { Name = authorName };
                            var book = new Book { Title = bookTitle, Author = author };

                            context.Authors.Add(author);
                            context.Books.Add(book);
                        }
                    }

                    await context.SaveChangesAsync();
                    MessageBox.Show("Books imported successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during import: {ex.Message}");
            }
        }

        // Button click event to trigger the import
        private async void btnImportBooks_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Select Book List to Import"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                await ImportBooksAsync(filePath);

                currentPage = 1;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}