using WebDesignAPI.Models;

namespace WebDesignAPI.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books = new()
        {
        new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Price = 39.99m, Description = "A Handbook of Agile Software Craftsmanship" },
        new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Price = 42.50m, Description = "Your Journey to Mastery" },
        new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", Price = 49.00m, Description = "Elements of Reusable Object-Oriented Software" },
        new Book { Id = 4, Title = "Refactoring", Author = "Martin Fowler", Price = 45.00m, Description = "Improving the Design of Existing Code" },
        new Book { Id = 5, Title = "Head First Design Patterns", Author = "Eric Freeman", Price = 38.50m, Description = "A Brain-Friendly Guide" },
        new Book { Id = 6, Title = "Effective Java", Author = "Joshua Bloch", Price = 47.00m, Description = "Best Practices for Java Programming" },
        new Book { Id = 7, Title = "You Don’t Know JS", Author = "Kyle Simpson", Price = 35.00m, Description = "Deep Dive into JavaScript" },
        new Book { Id = 8, Title = "JavaScript: The Good Parts", Author = "Douglas Crockford", Price = 32.00m, Description = "Unearthing the Excellence in JavaScript" },
        new Book { Id = 9, Title = "Cracking the Coding Interview", Author = "Gayle Laakmann McDowell", Price = 44.00m, Description = "189 Programming Questions and Solutions" },
        new Book { Id = 10, Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", Price = 59.99m, Description = "Comprehensive Algorithm Reference" },
        new Book { Id = 11, Title = "Clean Architecture", Author = "Robert C. Martin", Price = 40.00m, Description = "A Craftsman's Guide to Software Structure" },
        new Book { Id = 12, Title = "Domain-Driven Design", Author = "Eric Evans", Price = 50.00m, Description = "Tackling Complexity in the Heart of Software" },
        new Book { Id = 13, Title = "Working Effectively with Legacy Code", Author = "Michael Feathers", Price = 42.00m, Description = "Practical Techniques for Legacy Code" },
        new Book { Id = 14, Title = "Patterns of Enterprise Application Architecture", Author = "Martin Fowler", Price = 48.00m, Description = "Enterprise Software Design Patterns" },
        new Book { Id = 15, Title = "Test-Driven Development", Author = "Kent Beck", Price = 36.00m, Description = "By Example" },
        new Book { Id = 16, Title = "Continuous Delivery", Author = "Jez Humble", Price = 46.00m, Description = "Reliable Software Releases through Build, Test, and Deployment Automation" },
        new Book { Id = 17, Title = "The Mythical Man-Month", Author = "Frederick P. Brooks", Price = 33.00m, Description = "Essays on Software Engineering" },
        new Book { Id = 18, Title = "Algorithms", Author = "Robert Sedgewick", Price = 55.00m, Description = "Algorithms in Java" },
        new Book { Id = 19, Title = "The Art of Computer Programming", Author = "Donald Knuth", Price = 99.99m, Description = "Classic Multi-Volume Reference" },
        new Book { Id = 20, Title = "Code Complete", Author = "Steve McConnell", Price = 43.00m, Description = "A Practical Handbook of Software Construction" }
        };

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }
        public Book? GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }
    }
}
