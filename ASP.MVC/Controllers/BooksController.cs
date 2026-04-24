using ASP.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.MVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BooksService _booksService;
        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public IActionResult GrabBooks()
        {
            var books = _booksService.GetAllBooks();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GrabBooksByID(int id)
        {
            var books = _booksService.GetBook(id);
            return Ok(books);
        }

        [HttpPost] 
        public IActionResult AddNewBook(Book book)
        {
            var newBook = _booksService.AddNewBook(book);
            return Ok(newBook);
        }

    }
}
