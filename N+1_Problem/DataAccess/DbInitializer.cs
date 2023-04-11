using WebApi.Entities;

namespace WebApi.DataAccess;

public class DbInitializer
{
    public static async Task Seed(IApplicationBuilder applicationBuilder)
    {
        using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
        var _dbContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
        await _dbContext.Database.EnsureCreatedAsync();

        if (!_dbContext.Authors.Any())
        {
            var authors = new List<Author>()
            {
                new Author() {Name = "Author1"},
                new Author() {Name = "Author2"},
                new Author() {Name = "Author3"},
            };

            await _dbContext.Authors.AddRangeAsync(authors);
            await _dbContext.SaveChangesAsync();
        }

        if (!_dbContext.Books.Any())
        {
            var books = new List<Book>()
            {
                new Book() { Title = "Book1", YearOfPublication = 2013, AuthorId = 1, },
                new Book() { Title = "Book2", YearOfPublication = 2017, AuthorId = 1, },
                new Book() { Title = "Book3", YearOfPublication = 2019, AuthorId = 1, },
                new Book() { Title = "Book4", YearOfPublication = 2020, AuthorId = 2, },
                new Book() { Title = "Book5", YearOfPublication = 2023, AuthorId = 2, },
                new Book() { Title = "Book6", YearOfPublication = 2005, AuthorId = 3, },
            };

            await _dbContext.Books.AddRangeAsync(books);
            await _dbContext.SaveChangesAsync();
        }
    }
}

