using System;
using System.Text;
using Data;
using Services.Models;

namespace Services
{
    public class ConsoleServises
    {
        static BookServices _books = new BookServices();

        public static void MainMenu()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1.Get all books");
            Console.WriteLine("2.Find book by ID");
            Console.WriteLine("3.Search for book by author or title");
            Console.WriteLine("4.Create a new book");
            Console.WriteLine("0.Close the application");
            MainMenuSelector(Console.ReadLine());
        }

        public static void MainMenuSelector(string selection)
        {
            if (selection == "1")
            {
                AllBooks();               
            }
            if (selection == "2")
            {
                BookMenu();
            }
            if (selection == "3")
            {

            }
            if (selection == "4")
            {
                CreateABook();
            }
            if (selection != "0") MainMenu();
            {}
        }

        public static void BookMenuSelector(string selection, int id)
        {
            if (selection == "1")
            {
                EditABook(id);
            }
            if (selection == "2")
            {
                DeleteBook(id);
            }
            if (selection != "3") BookMenu();
            MainMenu();
        }

        public static void AllBooks()
        {
            var b = _books.GetAllBooks();
            var s = new StringBuilder();
            foreach (var book in b)
            {
                s.AppendFormat("ID: {0}, Author: {1}, Title: {2}, Publish Year: {3}, Amount: {4}.", book.Id, book.Author, book.Title, book.Year, book.Amount);
                s.Append(Environment.NewLine);
            }
            Console.WriteLine(s.Length == 0 ? "No books saved" : s.ToString());
            MainMenu();
        }

        public static void CreateABook()
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
            if (isValid != "") Console.WriteLine(isValid); MainMenu();
            {
                var b = new Book
                {
                    Amount = Convert.ToInt32(amount),
                    Author = author,
                    Title = title,
                    Year = Convert.ToInt32(year)
                };
                _books.Create(b);
                Console.WriteLine("Book successfully added");
            }
            MainMenu();
        }

        public static void EditABook(int id)
        {
            Console.WriteLine("Input book author:");
            var author = Console.ReadLine();
            Console.WriteLine("Input book title:");
            var title = Console.ReadLine();
            Console.WriteLine("Input book publish year:");
            var year = Console.ReadLine();
            Console.WriteLine("Input book number of sheets:");
            var amount = Console.ReadLine();
            if (Validator.Check(title, author, year, amount) != "") Console.WriteLine(Validator.Check(title, author, year, amount));
            {
                var b = new Book
                {
                    Id = id,
                    Amount = Convert.ToInt32(amount),
                    Author = author,
                    Title = title,
                    Year = Convert.ToInt32(year)
                };
                _books.Update(b);
                Console.WriteLine("Book successfully edited");
            }
            MainMenu();
        }

        public static void BookMenu()
        {
            Console.WriteLine("Input ID:");
            var b = _books.GetBookById(Convert.ToInt32(Console.ReadLine()));
            if (b == null)
            {
                Console.WriteLine("No book with this ID");
                MainMenu();
            }
            Console.WriteLine("ID: {0}, Author: {1}, Title: {2}, Publish Year: {3}, Amount: {4}.", b.Id, b.Author, b.Title, b.Year, b.Amount);
            Console.WriteLine("1.Edit this book");
            Console.WriteLine("2.Delete this book");
            Console.WriteLine("3.Back to main menu");
            BookMenuSelector(Console.ReadLine(), b.Id);
        }

        public static void DeleteBook(int id)
        {
            _books.Delete(id);
            MainMenu();
        }
    }
}
