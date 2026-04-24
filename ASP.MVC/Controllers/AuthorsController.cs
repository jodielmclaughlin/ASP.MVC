using ASP.MVC.Services;
using Microsoft.AspNetCore.Mvc;
namespace ASP.MVC.Controllers
{
    [ApiController]
    [Route("[controller]")] //"/Authors"
    public class AuthorsController : ControllerBase
    {
        private readonly AuthorService _authorService;
        public AuthorsController(AuthorService authorService)
        {
            _authorService = authorService;
        }
        [HttpGet]
        public IActionResult FetchAuthors()
        {
            var authors = _authorService.GetAllAuthors();

            return Ok(authors);
        }
    }
}
