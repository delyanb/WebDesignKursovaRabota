using WebDesignAPI.Models;

namespace WebDesignAPI.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books = new()
        {
             new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Price = 39.99m, Description = "A Handbook of Agile Software Craftsmanship", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780132350884-L.jpg" },
    new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt & David Thomas", Price = 42.50m, Description = "Journey to Mastery for Programmers", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780201616224-L.jpg" },
    new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma et al.", Price = 49.00m, Description = "Elements of Reusable Object-Oriented Software", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780201633610-L.jpg" },
    new Book { Id = 4, Title = "Refactoring", Author = "Martin Fowler", Price = 45.00m, Description = "Improving the Design of Existing Code", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780201485677-L.jpg" },
    new Book { Id = 5, Title = "Head First Design Patterns", Author = "Eric Freeman & Elisabeth Robson", Price = 38.50m, Description = "A Brain-Friendly Guide to Design Patterns", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780596007126-L.jpg" },
    new Book { Id = 6, Title = "Effective Java", Author = "Joshua Bloch", Price = 47.00m, Description = "Best Practices for Java Programming", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780134685991-L.jpg" },
    new Book { Id = 7, Title = "You Don’t Know JS: Up & Going", Author = "Kyle Simpson", Price = 35.00m, Description = "A Deep Dive into JavaScript Fundamentals", ImageUrl = "https://covers.openlibrary.org/b/isbn/9781491924464-L.jpg" },
    new Book { Id = 8, Title = "JavaScript: The Good Parts", Author = "Douglas Crockford", Price = 32.00m, Description = "Unearthing the Excellence in JavaScript", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780596517748-L.jpg" },
    new Book { Id = 9, Title = "Cracking the Coding Interview", Author = "Gayle Laakmann McDowell", Price = 44.00m, Description = "189 Programming Questions and Solutions", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780984782857-L.jpg" },
    new Book { Id = 10, Title = "Introduction to Algorithms", Author = "Thomas H. Cormen et al.", Price = 59.99m, Description = "Comprehensive Algorithm Reference", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780262033848-L.jpg" },
    new Book { Id = 11, Title = "Clean Architecture", Author = "Robert C. Martin", Price = 40.00m, Description = "A Craftsman's Guide to Software Structure", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780134494166-L.jpg" },
    new Book { Id = 12, Title = "Domain-Driven Design", Author = "Eric Evans", Price = 50.00m, Description = "Tackling Complexity in the Heart of Software", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780321125217-L.jpg" },
    new Book { Id = 13, Title = "Working Effectively with Legacy Code", Author = "Michael Feathers", Price = 42.00m, Description = "Practical Techniques for Legacy Code", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780131177055-L.jpg" },
    new Book { Id = 14, Title = "Patterns of Enterprise Application Architecture", Author = "Martin Fowler", Price = 48.00m, Description = "Enterprise Software Design Patterns", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780321127426-L.jpg" },
    new Book { Id = 15, Title = "Test-Driven Development: By Example", Author = "Kent Beck", Price = 36.00m, Description = "Practical Guide to TDD", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780321146533-L.jpg" },
    new Book { Id = 16, Title = "Continuous Delivery", Author = "Jez Humble & David Farley", Price = 46.00m, Description = "Reliable Software Releases through Automation", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780321601919-L.jpg" },
    new Book { Id = 17, Title = "The Mythical Man-Month", Author = "Frederick P. Brooks", Price = 33.00m, Description = "Essays on Software Engineering", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780201835953-L.jpg" },
    new Book { Id = 18, Title = "Algorithms", Author = "Robert Sedgewick", Price = 55.00m, Description = "Algorithms in Java", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780321573513-L.jpg" },
    new Book { Id = 19, Title = "The Art of Computer Programming", Author = "Donald Knuth", Price = 99.99m, Description = "Classic Multi-Volume Reference", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780201896831-L.jpg" },
    new Book { Id = 20, Title = "Code Complete", Author = "Steve McConnell", Price = 43.00m, Description = "A Practical Handbook of Software Construction", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780735619678-L.jpg" }
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
