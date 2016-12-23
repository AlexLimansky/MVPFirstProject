using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Data
{
    public class Serializer
    {
        private const string Filename = @"d:\docs\ses\s51\c#\mvptest\Data.json";

        public static List<Book> Load()
        {
            var js = new JavaScriptSerializer();
            var j = System.IO.File.ReadAllText(Filename);
            var books = js.Deserialize<List<Book>>(j);
            return books;
        }

        public static void Save(List<Book> books)
        {
            var js = new JavaScriptSerializer();
            var j = js.Serialize(books);
            System.IO.File.WriteAllText(Filename, j);
        }

    }
}
