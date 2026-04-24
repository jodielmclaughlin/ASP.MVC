using ASP.MVC.Models;
using System.Text.Json;
namespace ASP.MVC.Services
{
    //public interface IAuthorService
    //{
    //    List<AuthorsModel> FetchAuthors();

    //}
    public class AuthorService //: IAuthorService
    {
        //creating an instance of models 
        private readonly AuthorsModel _authors; //IAuthorsRepository _repository


        public AuthorService(AuthorsModel authors)
        {
            _authors = authors;
        }

        public List<AuthorsModel> GetAllAuthors()
        {
           return _authors.FetchAuthors();
        }
    }
}
