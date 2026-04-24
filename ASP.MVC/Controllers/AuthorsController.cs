using ASP.MVC.Services;
using Microsoft.AspNetCore.Mvc;
namespace ASP.MVC.Controllers
{
    [ApiController]
    [Route("[controller]")] //"/Authors"
    public class AuthorsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = AuthorService.FetchAuthors();

            return Ok(authors);
        }
    }
}
