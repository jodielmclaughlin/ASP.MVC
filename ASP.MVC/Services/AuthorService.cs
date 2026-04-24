using ASP.MVC.Models;
using System.Text.Json;
namespace ASP.MVC.Services
{
    //interface can be used here to create the instance in order to do mock testing
    public class AuthorService 
    {
        //creating an instance of models 
        private readonly AuthorsModel _authors; 

        public AuthorService(AuthorsModel authors)
        {
            _authors = authors;
        }

        public List<Author> GetAllAuthors()
        {
           return _authors.FetchAuthors();
        }

        public Author GetAuthor(int id)
        {

            return _authors.FetchAuthorByID(id);
        }

        public Author AddNewAuthor(Author author)
        {
            return _authors.AddAuthor(author);

        }
    }
}
