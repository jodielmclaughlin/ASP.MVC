using System.Text.Json;

namespace ASP.MVC.Models
{
    public class BooksModel
    {
        public List<Book> FetchBooks()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Books.json");
            var json = File.ReadAllText(filePath);
            var books = JsonSerializer.Deserialize<List<Book>>(json);
            return books;

        }
        public Book FetchBookByID(int id)
        {
            var books = FetchBooks();

            return books.FirstOrDefault(r => r.Id == id);

        }

        public Book AddBook(Book book)
        {
            var books = FetchBooks();
            book.Id = books.Count == 0 ? 1 : books.Max(a => a.Id) + 1;
            books.Add(book);

            var newJson = JsonSerializer.Serialize(book);
            File.WriteAllText(".\\Resources\\Books.json", newJson);
            return book;
        }

    }
}
