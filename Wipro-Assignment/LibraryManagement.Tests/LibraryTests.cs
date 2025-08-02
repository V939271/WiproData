using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library = null!;
        private Book _book = null!;
        private Borrower _borrower = null!;

        [SetUp]
        public void SetUp()
        {
            _library = new Library();
            _book = new Book("Clean Code", "Robert C. Martin", "9780132350884");
            _borrower = new Borrower("Alice", "CARD-001");
        }

        [Test]
        public void AddBook_BookAppearsInBooksCollection()
        {
            _library.AddBook(_book);
            Assert.Contains(_book, _library.Books.ToList());
        }

        [Test]
        public void RegisterBorrower_BorrowerAppearsInBorrowersCollection()
        {
            _library.RegisterBorrower(_borrower);
            Assert.Contains(_borrower, _library.Borrowers.ToList());
        }

        [Test]
        public void BorrowBook_SetsIsBorrowedAndAddsToBorrower()
        {
            _library.AddBook(_book);
            _library.RegisterBorrower(_borrower);

            _library.BorrowBook(_book.Isbn, _borrower.CardNumber);

            Assert.IsTrue(_book.IsBorrowed);
            Assert.Contains(_book, _borrower.BorrowedBooks.ToList());
        }

        [Test]
        public void ReturnBook_ClearsIsBorrowedAndRemovesFromBorrower()
        {
            _library.AddBook(_book);
            _library.RegisterBorrower(_borrower);
            _library.BorrowBook(_book.Isbn, _borrower.CardNumber);

            _library.ReturnBook(_book.Isbn, _borrower.CardNumber);

            Assert.IsFalse(_book.IsBorrowed);
            Assert.IsFalse(_borrower.BorrowedBooks.Contains(_book));
        }

        [Test]
        public void Collections_HaveCorrectCountsAfterOperations()
        {
            _library.AddBook(_book);
            _library.RegisterBorrower(_borrower);

            Assert.AreEqual(1, _library.Books.Count);
            Assert.AreEqual(1, _library.Borrowers.Count);
        }
    }
}
