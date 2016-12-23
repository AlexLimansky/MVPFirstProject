using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Services;
using Services.Interfaces;

namespace MVPtest
{
    class ConsoleView : IBooksView
    {
        public int SelectedBookId { get; set; }
        public Book CurrentBook { get; set; }
        public IEnumerable<Book> BooksList { get; set; }
        public void ShowAllBooks()
        {
            var s = new StringBuilder();
            foreach (var book in BooksList)
            {
                s.AppendFormat("ID: {0}, Author: {1}, Title: {2}, Publish Year: {3}, Amount: {4}.", book.Id, book.Author, book.Title, book.Year, book.Amount);
                s.Append(Environment.NewLine);
            }
            Console.WriteLine(s.Length == 0 ? "No books saved" : s.ToString());
        }

        public void ShowOneBook()
        {           
            Console.WriteLine("ID: {0}, Author: {1}, Title: {2}, Publish Year: {3}, Amount: {4}.", CurrentBook.Id, CurrentBook.Author, CurrentBook.Title, CurrentBook.Year, CurrentBook.Amount);
        }

        public void Start()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1.Get all books");            
            Console.WriteLine("2.Create a new book");
            Console.WriteLine("3.Find book by ID");
            Console.WriteLine("4.Edit book by ID");
            Console.WriteLine("5.Delete book by ID");
            Console.WriteLine("0.Close the application");
            MainMenuSelector(Console.ReadLine());
        }

        public void MainMenuSelector(string selection)
        {
            if (selection == "1")
            {
                ShowAllBooks();
            }
            if (selection == "2")
            {
                CreateABook();
            }
            if (selection == "3")
            {
                Console.WriteLine("Enter Id:");
                SelectedBookId = Convert.ToInt32(Console.ReadLine());
                SelectedIdChanged(this, EventArgs.Empty);
                ShowOneBook();
            }
            if (selection == "4")
            {
                Console.WriteLine("Enter Id:");
                SelectedBookId = Convert.ToInt32(Console.ReadLine());
                EditABook();
            }
            if (selection == "5")
            {
                Console.WriteLine("Enter Id:");
                SelectedBookId = Convert.ToInt32(Console.ReadLine());
                BookDeleted(this, SelectedBookId);
            }
            if (selection != "0") MainMenu();
            { }
        }

        private void EditABook()
        {
            Console.WriteLine("Input book author:");
            var author = Console.ReadLine();
            Console.WriteLine("Input book title:");
            var title = Console.ReadLine();
            Console.WriteLine("Input book publish year:");
            var year = Console.ReadLine();
            Console.WriteLine("Input book number of sheets:");
            var amount = Console.ReadLine();
            var isValid = Validator.Check(title, author, year, amount);
            if (isValid != "") Console.WriteLine(isValid);
            {
                var b = new Book
                {
                    Id = SelectedBookId,
                    Amount = Convert.ToInt32(amount),
                    Author = author,
                    Title = title,
                    Year = Convert.ToInt32(year)
                };
                BookUpdated(this, new BookEventArgs(b));
            }
            MainMenu();
        }

        public void CreateABook()
        {
            Console.WriteLine("Input book author:");
            var author = Console.ReadLine();
            Console.WriteLine("Input book title:");
            var title = Console.ReadLine();
            Console.WriteLine("Input book publish year:");
            var year = Console.ReadLine();
            Console.WriteLine("Input book number of sheets:");
            var amount = Console.ReadLine();
            var isValid = Validator.Check(title, author, year, amount);
            if (isValid != "") Console.WriteLine(isValid);
            {
                var b = new Book
                {
                    Amount = Convert.ToInt32(amount),
                    Author = author,
                    Title = title,
                    Year = Convert.ToInt32(year)
                };
                BookCreated(this, new BookEventArgs(b));
            }
            MainMenu();
        }

        public event EventHandler SelectedIdChanged = delegate { };
        public event EventHandler<BookEventArgs> BookCreated = delegate { };
        public event EventHandler<BookEventArgs> BookUpdated = delegate { };
        public event EventHandler<int> BookDeleted = delegate { };
    }
}
