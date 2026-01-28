namespace WebDesign.Models
{

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }

    public class GetTopBestSellersResponse
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
        public List<BestSellerBook> BestSellers { get; set; } = [];
    }


    public class BestSellerBook
    {
        public Book Book { get; set; } = null!;
        public int SoldThisWeek { get; set; }
        public List<BookComment> Comments { get; set; } = [];
    }


    public class BookComment
    {
        public string Username { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }


}
