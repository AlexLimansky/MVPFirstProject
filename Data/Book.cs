using System;

namespace Data
{
    [Serializable]
    public class Book
    {
        private static int _counter;
        public Book()
        {
            Id = _counter++;
        }
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set;}
        public int Amount { get; set; }
    }
}
