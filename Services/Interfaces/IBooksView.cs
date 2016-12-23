using System;
using System.Collections.Generic;
using Data;

namespace Services.Interfaces
{
    public interface IBooksView
    {
        int SelectedBookId { get; set; }
        Book CurrentBook { get; set; }
        IEnumerable<Book> BooksList { get; set; }
        void ShowAllBooks();
        void ShowOneBook();
        event EventHandler SelectedIdChanged;
        event EventHandler<BookEventArgs> BookCreated;
        event EventHandler<BookEventArgs> BookUpdated;
        event EventHandler<int> BookDeleted;
    }
}