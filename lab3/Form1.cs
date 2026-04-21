namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            private string _title;

            public string Title
            {
                get { return _title; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Title cannot be empty.");
                    }
                    _title = value;
                }
            }

            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            private int _issueNumber;

            public int IssueNumber
            {
                get { return _issueNumber; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Issue number cannot be negative.");
                    }
                    _issueNumber = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public double FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (Ebook, {FileSizeMB}MB)";
            }

        }

        public class Textbook : Book
        {
            private string _subject;

            public string Subject
            {
                get { return _subject; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Subject cannot be empty.");
                    }
                    _subject = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} by {Author} [Subject: {Subject}]";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Narrated by {Narrator}, {Duration} hrs)";
            }
        }

        private void ProcessBooks(Book[] bookstoreInventory)
        {
            lstBookTypes.Items.Clear();

            foreach (Book item in bookstoreInventory)
            {
                lstBookTypes.Items.Add(item.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };

            MessageBox.Show(myBook.GetInfo());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Book[] myInventory = new Book[]
            {
                new Book
                {
                    Title = "The Art of Laziness",
                    Author = "Kyrie Petrakis"
                },

                new Magazine
                {
                    Title = "Tech Weekly",
                    Author = "John Doe",
                    IssueNumber = 45
                },

                new Ebook
                {
                    Title = "Don't Wait Until It's Too Late",
                    Author = "Destiny Harris",
                    FileSizeMB = 5.2
                },

                new Textbook
                {
                    Title = "Discrete Mathematics",
                    Author = "Kenneth Rosen",
                    Subject = "Mathematics"
                },

                new AudioBook
                {
                    Title = "The Martian",
                    Author = "Andy Weir",
                    Narrator = "R.C. Bray",
                    Duration = 10.5
                }
            };

            ProcessBooks(myInventory);
        }
    }
}