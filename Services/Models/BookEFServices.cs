using System;
using System.Collections.Generic;
using System.Data.Entity;
using Data;
using Data.Entities;
using Services.Interfaces;

namespace Services.Models
{
    class BookEFServices : IBooksModel
    {
        BooksContext bc = new BooksContext();

        public IEnumerable<Book> GetAllBooks()
        {
            return bc.Books;
        }

        public Book GetBookById(int id)
        {
            return bc.Books.Find(id);
        }

        public void Create(Book book)
        {
            bc.Books.Add(book);
            bc.SaveChanges();
            BooksUpdated(this, EventArgs.Empty);
        }

        public void Update(Book book)
        {
            bc.Entry(book).State = EntityState.Modified;
            bc.SaveChanges();
            BooksUpdated(this, EventArgs.Empty);
        }

        public void Delete(int id)
        {
            var book = bc.Books.Find(id);
            if (book != null)
            {
                bc.Books.Remove(book);
            }
            bc.SaveChanges();
            BooksUpdated(this, EventArgs.Empty);
        }

        public event EventHandler BooksUpdated = delegate { };
    }
}
