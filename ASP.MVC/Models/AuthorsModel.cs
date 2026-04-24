using System.Text.Json;

namespace ASP.MVC.Models
{
    public class AuthorsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        public List<AuthorsModel> FetchAuthors()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Authors.json");
            var json = File.ReadAllText(filePath);
            var authors = JsonSerializer.Deserialize<List<AuthorsModel>>(json);
            return authors;

        }
    }

}

