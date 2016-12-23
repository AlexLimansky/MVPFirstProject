using System;
using System.Collections.Generic;
using Data;

namespace Services.Interfaces
{
    public interface IBooksModel
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void Create(Book book);
        void Update(Book book);
        void Delete(int id);
        event EventHandler BooksUpdated;
    }
}