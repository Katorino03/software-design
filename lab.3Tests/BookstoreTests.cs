using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Policy;
using static lab3.Form1;

namespace lab._3Tests
{
    [TestClass]
    public sealed class BookstoreTests
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }

        [TestMethod]
        public void TestEbookCreation()
        {
            Ebook ebook = new Ebook { Title = "Digital Design", Author = "Alan Turing", FileSizeMB = 15.5 };
            Assert.AreEqual("Digital Design", ebook.Title);
            Assert.AreEqual(15.5, ebook.FileSizeMB);
        }

        [TestMethod]
        public void TestTextbookCreation()
        {
            Textbook textbook = new Textbook { Title = "Physics 101", Author = "Albert Einstein", Subject = "Physics" };
            Assert.AreEqual("Physics 101", textbook.Title);
            Assert.AreEqual("Physics", textbook.Subject);
        }

        [TestMethod]
        public void TestAudioBookCreation()
        {
            AudioBook audioBook = new AudioBook { Title = "Dune", Author = "Frank Herbert", Narrator = "Scott Brick", Duration = 21.5 };

            Assert.AreEqual("Dune", audioBook.Title);
            Assert.AreEqual("Scott Brick", audioBook.Narrator);
            Assert.AreEqual(21.5, audioBook.Duration);
        }
    }

    [TestClass]
    public sealed class PolymorphismTests
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            // Arrange: Create an array of Book objects that includes different derived types
            Book[] books = new Book[]
            {
                new Book { Title = "Generic Book", Author = "John Smith"},
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12},
                new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5}
            };

            // Act and Assert: Check the results of the GetInfo method for each type
            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidBookCreation_EmptyTitle()
        {
            Form1.Book book = new Form1.Book { Title = "", Author = "John Smith" };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidMagazineCreation_NegativeIssue()
        {
            Form1.Magazine magazine = new Form1.Magazine { Title = "Invalid", Author = "Jane Doe", IssueNumber = -1 };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTextbookCreation_EmptySubject()
        {
            Form1.Textbook textbook = new Form1.Textbook { Title = "Math 101", Author = "John Doe", Subject = "" };
        }
    }
}