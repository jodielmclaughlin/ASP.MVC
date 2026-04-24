using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace ASP.MVC.Models
{
    public class AuthorsModel
    {
        
        public List<Author> FetchAuthors()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Authors.json");
            var json = File.ReadAllText(filePath);
            var authors = JsonSerializer.Deserialize<List<Author>>(json);
            return authors;

        }
        public Author FetchAuthorByID(int id)
        {
            var authors = FetchAuthors();

            return authors.FirstOrDefault(r => r.Id == id);

        }

        public Author AddAuthor(Author author)
        {
            var authors = FetchAuthors();
            author.Id = authors.Count == 0 ? 1 : authors.Max(a => a.Id) + 1;
            authors.Add(author);

            var newJson = JsonSerializer.Serialize(authors);
            File.WriteAllText(".\\Resources\\Authors.json", newJson);

            return author;
        }
    }

}

