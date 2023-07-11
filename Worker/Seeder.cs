using System.ComponentModel;
using Bogus;
using HotChocolate.Checker.Persistence;
using HotChocolate.Checker.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotChocolate.Checker.Worker;

public class Seeder : BackgroundService
{
    private readonly DbContextOptions<CheckerDbContext> _contextOptions;
    private readonly ILogger<CheckerDbContext> _logger;

    public Seeder(DbContextOptions<CheckerDbContext> context, ILogger<CheckerDbContext> logger)
    {
        _contextOptions = context;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Seeding Started!");
        try
        {
            await using var context = new CheckerDbContext(_contextOptions);

            await context.Database.EnsureDeletedAsync(stoppingToken);
            await context.Database.EnsureCreatedAsync(stoppingToken);
            await context.SaveChangesAsync(stoppingToken);

            _logger.LogInformation("Database Reset!");

            var users = new List<UserEntity>();
            for (var i = 1; i < 100; i++)
            {
                var faker = new Faker();
                users.Add(new()
                {
                    Name = faker.Person.FirstName, SurName = faker.Person.LastName,
                });
            }

            await context.Set<UserEntity>().AddRangeAsync(users, stoppingToken);
            await context.SaveChangesAsync(stoppingToken);

            var genre = new List<GenreEntity>();
            for (var i = 1; i < 100; i++)
            {
                var faker = new Faker();
                genre.Add(new()
                {
                    Name = faker.Music.Genre(),
                });
            }

            await context.Set<GenreEntity>().AddRangeAsync(genre, stoppingToken);
            await context.SaveChangesAsync(stoppingToken);

            var books = new List<BookEntity>();
            for (var i = 1; i < 100; i++)
            {
                var faker = new Faker();
                books.Add(new()
                {
                    Author = context.Set<UserEntity>().First(),
                    Language = faker.Random.Word(),
                    Title = faker.Company.CompanyName(),
                    PageCount = faker.Random.Int(10, 9999),
                    ISBN = faker.Commerce.Ean13(),
                    PublicationDate = faker.Date.Past(),
                });
            }

            await context.Set<BookEntity>().AddRangeAsync(books, stoppingToken);
            await context.SaveChangesAsync(stoppingToken);

            var genreBooksConnections = new List<GenreBooksConnectionEntity>();
            var bookIds = context.Set<BookEntity>().Select(static b => b.Id).ToList();
            var genreIds = context.Set<GenreEntity>().Select(static g => g.Id).ToList();
            for (var i = 1; i < 200; i++)
            {
                var bookId = Random.Shared.Next(bookIds.Count);
                var genreId = Random.Shared.Next(genreIds.Count);
                genreBooksConnections.Add(new()
                {
                    BookId = bookIds.ElementAt(bookId), GenreId = genreIds.ElementAt(genreId),
                });
            }

            await context.Set<GenreBooksConnectionEntity>().AddRangeAsync(genreBooksConnections, stoppingToken);
            await context.SaveChangesAsync(stoppingToken);

            _logger.LogInformation("Seeding Completed!");
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occured while seeding!");
            throw;
        }
    }
}