using ASP.MVC.Services;
using Microsoft.AspNetCore.Mvc;
namespace ASP.MVC.Controllers
{
    [ApiController]
    [Route("[controller]")] //"/Authors"
    public class AuthorsController : ControllerBase
    {
        // creating an instance
        private readonly AuthorService _authorService;
        public AuthorsController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult GrabAuthors()
        {
            var authors = _authorService.GetAllAuthors();

            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GrabAuthorsByID(int id)
        {
            var authors = _authorService.GetAuthor(id);

            return Ok(authors);
        }

        [HttpPost]
        public IActionResult AddNewAuthor(Author author)
        {
            var newAuthor = _authorService.AddNewAuthor(author);

            return Ok(newAuthor);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var deleteAuthor = _authorService.DeleteAuthorByID(id);

            return Ok(deleteAuthor);
        }

    }
}
