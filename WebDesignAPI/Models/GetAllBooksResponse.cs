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

    public class GetTopBestSellersResponse
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public List<BestSellerBookDto> BestSellers { get; set; } = [];
    }

    public class BestSellerBookDto
    {
        public Book Book { get; set; } = null!;
        public int SoldThisWeek { get; set; }
        public List<BookCommentDto> Comments { get; set; } = [];
    }

    public class BookCommentDto
    {
        public string Username { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }
}
