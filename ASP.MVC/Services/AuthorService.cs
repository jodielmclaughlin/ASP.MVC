using ASP.MVC.Models;
namespace ASP.MVC.Services
{
    //public interface IAuthorService
    //{
    //    List<AuthorsModel> FetchAuthors();

    //}
    public class AuthorService //: IAuthorService
    {
        private readonly AuthorsModel _authors; //IAuthorsRepository _repository

        public AuthorService(AuthorsModel authors)
        {
            _authors = authors;
        }

        public List<AuthorsModel> FetchAuthors()
        {

            return  _authors.GrabAuthors(); 
        }
    }
}
