using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        private readonly List<Book> _books = new List<Book>();
        private readonly List<Borrower> _borrowers = new List<Borrower>();

        public IReadOnlyCollection<Book> Books => _books.AsReadOnly();
        public IReadOnlyCollection<Borrower> Borrowers => _borrowers.AsReadOnly();

        public void AddBook(Book book) => _books.Add(book);

        public void RegisterBorrower(Borrower borrower) => _borrowers.Add(borrower);

        public void BorrowBook(string isbn, string cardNumber)
        {
            var book = _books.FirstOrDefault(b => b.Isbn == isbn)
                           ?? throw new ArgumentException("Book not found", nameof(isbn));
            var borrower = _borrowers.FirstOrDefault(b => b.CardNumber == cardNumber)
                           ?? throw new ArgumentException("Borrower not found", nameof(cardNumber));

            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string cardNumber)
        {
            var borrower = _borrowers.FirstOrDefault(b => b.CardNumber == cardNumber)
                           ?? throw new ArgumentException("Borrower not found", nameof(cardNumber));
            var book = borrower.BorrowedBooks
                        .FirstOrDefault(b => b.Isbn == isbn)
                        ?? throw new ArgumentException("This borrower did not borrow that book", nameof(isbn));

            borrower.ReturnBook(book);
        }
    }
}
