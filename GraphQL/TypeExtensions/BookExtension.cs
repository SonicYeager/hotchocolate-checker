using HotChocolate.Checker.GraphQL.EntityToTypeMapping;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence;
using HotChocolate.Checker.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotChocolate.Checker.GraphQL.TypeExtensions;

[ExtendObjectType<Book>]
public static class BookExtension
{
    [UseProjection]
    public static IQueryable<Genre> Genre([Parent] Book book, CheckerDbContext dbContext)
    {
        return dbContext.Set<GenreEntity>()
            .Where(g => g.Book.Any(b => b.Id == book.Id))
            .Select(GenreEntityExtension.GetSelection());
    }

    public static async Task<Book> AssociatedBook(int? bookId, [Parent] Book book, IBookByIdDataLoader dataLoader)
    {
        return await dataLoader.LoadAsync(bookId ?? 1);
    }

    [DataLoader]
    public static async Task<Genre?> GenreById(
        int id,
        CheckerDbContext dbContext,
        CancellationToken cancellationToken)
    {
        var fetched = await dbContext.Set<GenreEntity>()
            .FirstOrDefaultAsync(g => g.Id == id, cancellationToken: cancellationToken);

        return new()
        {
            Id = fetched.Id, Name = fetched.Name,
        };
    }

    [DataLoader]
    public static async Task<Book?> BookById(
        int id,
        CheckerDbContext dbContext,
        CancellationToken cancellationToken)
    {
        var fetched = await dbContext.Set<BookEntity>()
            .FirstOrDefaultAsync(g => g.Id == id, cancellationToken: cancellationToken);

        return fetched?.ToBook();
    }
}