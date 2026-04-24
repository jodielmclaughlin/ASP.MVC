using ASP.MVC.Models;

namespace ASP.MVC.Services
{
    public class BooksService
    {
        //creating an instance of models 
        private readonly BooksModel _books;

        public BooksService(BooksModel books)
        {
            _books = books;
        }

        public List<Book> GetAllBooks()
        {
            return _books.FetchBooks();
        }

        public Book GetBook(int id)
        {
            return _books.FetchBookByID(id);
        }

        public Book AddNewBook(Book book)
        {
            return _books.AddBook(book);
        }
    }
}
