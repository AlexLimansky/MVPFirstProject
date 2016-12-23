using System;
using Data;

namespace Services
{
    public class BookEventArgs : EventArgs
    {
        public Book Book;

        public BookEventArgs(Book book)
        {
            Book = book;
        }
    }
}
