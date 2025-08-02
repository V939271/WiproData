using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Borrower
    {
        public string Name { get; }
        public string CardNumber { get; }
        private readonly List<Book> _borrowed = new List<Book>();

        public IReadOnlyCollection<Book> BorrowedBooks => _borrowed.AsReadOnly();

        public Borrower(string name, string cardNumber)
        {
            Name = name;
            CardNumber = cardNumber;
        }

        public void BorrowBook(Book book)
        {
            if (book.IsBorrowed)
                throw new InvalidOperationException("Book already borrowed.");
            book.Borrow();
            _borrowed.Add(book);
        }

        public void ReturnBook(Book book)
        {
            if (!_borrowed.Remove(book))
                throw new InvalidOperationException("Book not in borrower's list.");
            book.Return();
        }
    }
}

