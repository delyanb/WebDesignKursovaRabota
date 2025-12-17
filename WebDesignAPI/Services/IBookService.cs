using WebDesignAPI.Models;

namespace WebDesignAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book? GetBookById(int id);
    }
}
