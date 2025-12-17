namespace WebDesignAPI.Models
{
    public class GetAllBooksResponse
    {
        public bool Success { get; set; } = false;
        public List<Book> Books { get; set; } = [];
        public string? ErrorMessage { get; set; }
    }

    public class GetBookByIdResponse
    {
        public bool Success { get; set; } = false;
        public Book? Book { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
