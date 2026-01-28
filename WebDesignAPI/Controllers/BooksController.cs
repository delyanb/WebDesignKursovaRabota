using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Threading.Tasks;
using WebDesignAPI.Models;
using WebDesignAPI.Services;

namespace WebDesignAPI.Controllers
{
    [ApiController]
    [Route(template: "[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService, IMemoryCache cache)
        {
            _bookService = bookService;
            _cache = cache;
        }

        [HttpGet]
        public async Task<GetAllBooksResponse> GetAllBooksAsync()
        {
            GetAllBooksResponse response = new();
            const string cacheKey = "GET_ALL_BOOKS_RESPONSE";

            try
            {


                if (_cache.TryGetValue(cacheKey, out GetAllBooksResponse? cached))
                {
                    await Task.Delay(500);
                    return cached!;
                }

                await Task.Delay(1500);

                var books = await Task.Run(() => _bookService.GetAllBooks()?.ToList());
                if (books == null || books.Count == 0)
                {
                    response.ErrorMessage = "No books found.";
                    return response;
                }
                response.Books = books;
                response.Success = true;

                _cache.Set(
                  cacheKey,
                  response,
                  TimeSpan.FromMinutes(10)
                 );


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

        [HttpGet("best-sellers")]
        public async Task<GetTopBestSellersResponse> GetTopBestSellersAsync()
        {
            GetTopBestSellersResponse response = new();
            const string cacheKey = "BEST_SELLERS_THIS_WEEK";
            try
            {

                if (_cache.TryGetValue(cacheKey, out GetTopBestSellersResponse? cached))
                {
                    await Task.Delay(500);
                    return cached!;
                }

                await Task.Delay(1500);
                var bestSellersList = await Task.Run(() => _bookService.GetTopBestSellers());

                if(bestSellersList == null || bestSellersList.Count == 0)
                {
                    response.ErrorMessage = "Error: No best sellers found.";
                    return response;
                }

                response.BestSellers = bestSellersList;
                response.Success = true;

                _cache.Set(
                  cacheKey,
                  response,
                  TimeSpan.FromMinutes(10)
                 );


            }
            catch (Exception ex)
            {
                response.ErrorMessage = $"An error occurred: {ex.Message}";
            }

            return response;
        }
    }
}
