using System;
using System.Collections.Generic;
using System.IO;
using Data;
using Services.Interfaces;

namespace Services.Models
{
    public class BookServices : IBooksModel
    {
        private readonly List<Book> _books;

        public BookServices()
        {
            try
            {
                _books = Serializer.Load();
            }
            catch (FileNotFoundException)
            {
                _books = new List<Book>();
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.Find(b => b.Id == id);
        }

        public void Create(Book item)
        {
            _books.Add(item);
            Serializer.Save(_books);
            BooksUpdated(this, EventArgs.Empty);
        }

        public void Update(Book item)
        {
            var book = _books.Find(b => b.Id == item.Id);
            item.Id = book.Id;
            _books.Remove(book);
            _books.Add(item);
            Serializer.Save(_books);
            BooksUpdated(this, EventArgs.Empty);
        }

        public void Delete(int id)
        {
            _books.Remove(_books.Find(b => b.Id == id));
            Serializer.Save(_books);
            BooksUpdated(this, EventArgs.Empty);
        }

        public event EventHandler BooksUpdated = delegate { };
    }
}
