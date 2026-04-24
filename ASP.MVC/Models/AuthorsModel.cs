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
    }

}

