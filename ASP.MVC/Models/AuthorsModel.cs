namespace ASP.MVC.Models
{
    public class AuthorsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        public List<Authors> FetchAuthors()
        {

        }
        
    }
}
