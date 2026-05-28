using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Asynchronous method to fetch book details from Google Books API
        public async Task<string> GetBookInfoFromAPIAsync(string isbn)
        {
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}&key=AIzaSyCbLIUZCGEHOlCrJo8WHzm5hAdnFryMwZM";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(apiUrl); // Fetch the API response
                    var jsonResponse = JObject.Parse(response);     // Parse the response as JSON

                    // Extract the book title and authors from the API response
                    var title = jsonResponse["items"][0]["volumeInfo"]["title"].ToString();
                    var authors = string.Join(", ", jsonResponse["items"][0]["volumeInfo"]["authors"].Select(a => a.ToString()));

                    return $"Title: {title} \n Authors: {authors}";
                }
            }
            catch (HttpRequestException)
            {
                return "Error: Unable to fetch data from the API. Please check your connection or try again later.";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        // Button click event to fetch book details from the API
        private async void btnFetchBook_Click(object sender, EventArgs e)
        {
            var isbn = txtISBN.Text;
            var bookInfo = await GetBookInfoFromAPIAsync(isbn);

            txtBookDetails.Text = bookInfo;
        }

        // Variables specifically for API pagination
        private int apiStartIndex = 0;
        private const int apiMaxResults = 10;
        private string currentApiAuthor = "";
        private string apiKey = "AIzaSyCbLIUZCGEHOlCrJo8WHzm5hAdnFryMwZM";

        // Asynchronous method to search books by author using Google Books API with Pagination
        public async Task<List<string>> SearchBooksByAuthorAsync(string author, int startIndex)
        {
            var bookList = new List<string>();

            // Construct the URL using 'inauthor:', startIndex, maxResults, and your API Key
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=inauthor:{author}&startIndex={startIndex}&maxResults={apiMaxResults}&key={apiKey}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "Lab8BookstoreApp/1.0");
                    var response = await client.GetStringAsync(apiUrl);
                    var jsonResponse = JObject.Parse(response);

                    // Google returns an "items" array. We must check if it exists in case the search is empty.
                    if (jsonResponse["items"] != null)
                    {
                        foreach (var item in jsonResponse["items"])
                        {
                            var volumeInfo = item["volumeInfo"];

                            // Safely extract the title
                            string title = volumeInfo["title"]?.ToString() ?? "Unknown Title";

                            // Safely extract authors (some books might not list an author)
                            string authors = "Unknown Author";
                            if (volumeInfo["authors"] != null)
                            {
                                authors = string.Join(", ", volumeInfo["authors"].Select(a => a.ToString()));
                            }

                            bookList.Add($"{title} by {authors}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"API Error: {ex.Message}");
            }

            return bookList;
        }

        // Helper method to handle updating the UI for the API
        private async Task LoadApiBooksAsync()
        {
            var books = await SearchBooksByAuthorAsync(currentApiAuthor, apiStartIndex);
            listBoxBooks.DataSource = books;

            if (books.Count == 0 && apiStartIndex > 0)
            {
                MessageBox.Show("No more books found for this author.");
            }

            // Calculate the current page number using math and update the label
            int currentPage = (apiStartIndex / apiMaxResults) + 1;
            lblPageNumber.Text = $"Page {currentPage}";
        }

        // Button click event to start the initial search
        private async void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            currentApiAuthor = txtAuthorSearch.Text;

            if (!string.IsNullOrWhiteSpace(currentApiAuthor))
            {
                apiStartIndex = 0;
                await LoadApiBooksAsync();
            }
            else
            {
                MessageBox.Show("Please enter an author name.");
            }
        }

        // Button click event to load the Next Page of API results
        private async void btnNextApiPage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(currentApiAuthor))
            {
                apiStartIndex += apiMaxResults;
                await LoadApiBooksAsync();
            }
        }

        // Button click event to load the Previous Page of API results
        private async void btnPrevApiPage_Click(object sender, EventArgs e)
        {
            if (apiStartIndex >= apiMaxResults)
            {
                apiStartIndex -= apiMaxResults;
                await LoadApiBooksAsync();
            }
            else
            {
                MessageBox.Show("You are already on the first page of the API results.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}