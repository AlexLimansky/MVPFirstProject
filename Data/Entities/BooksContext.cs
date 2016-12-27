using System.Data.Entity;

namespace Data.Entities
{
    public class BooksContext : DbContext
    {
        public BooksContext() : base("DefaultConnection")
        {}

        public DbSet<Book> Books { get; set; }
    }
}
