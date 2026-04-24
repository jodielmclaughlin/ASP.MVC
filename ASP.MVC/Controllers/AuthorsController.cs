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


    }
}
