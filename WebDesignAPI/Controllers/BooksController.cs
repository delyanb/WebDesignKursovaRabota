using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebDesignAPI.Models;
using WebDesignAPI.Services;

namespace WebDesignAPI.Controllers
{
    [ApiController]
    [Route(template: "[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<GetAllBooksResponse> GetAllBooksAsync()
        {
            GetAllBooksResponse response = new();
            try
            {

                await Task.Delay(1500);
                var books = await Task.Run(()=>_bookService.GetAllBooks()?.ToList());
                if (books == null || books.Count == 0)
                {
                    response.ErrorMessage = "No books found.";
                    return response;
                }
                response.Books = books;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"An error occurred: {ex.Message}";
                return response;
            }

            return response;
        }

        [HttpGet("{id:int}")]
        public async Task<GetBookByIdResponse> GetBookByIdAsync(int id)
        {

            GetBookByIdResponse response = new();
            try
            {
                await Task.Delay(1500);
                var book = await Task.Run(() => _bookService.GetBookById(id));
                if (book == null)
                {
                    response.ErrorMessage = "Book not found.";
                    return response;
                }
                response.Book = book;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"An error occurred: {ex.Message}";
                return response;
            }
            return response;
        }
    }
}
