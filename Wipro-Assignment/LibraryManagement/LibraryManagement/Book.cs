using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Isbn { get; }
        public bool IsBorrowed { get; private set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        public void Borrow() => IsBorrowed = true;
        public void Return() => IsBorrowed = false;
    }
}


