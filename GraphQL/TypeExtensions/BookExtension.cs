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
    public static IQueryable<Genre?> Genre([Parent] Book book, CheckerDbContext dbContext)
    {
        return dbContext.Set<GenreEntity>()
            .Where(g => g.Book.Any(b => b.Id == book.Id))
            .Select(static g => g.ToGenre());
    }

    public static async Task<Book> AssociatedBook(int? bookId, [Parent] Book book, IBooksByIdsDataLoader dataLoader,
        CancellationToken cancellationToken)
    {
        return await dataLoader.LoadAsync(bookId ?? 1, cancellationToken: cancellationToken);
    }

    [DataLoader]
    public static async Task<Genre?> GenreById(
        int id,
        CheckerDbContext dbContext,
        CancellationToken cancellationToken)
    {
        var fetched = await dbContext.Set<GenreEntity>()
            .FirstOrDefaultAsync(g => g.Id == id, cancellationToken);

        if (fetched == null) return null;
        return new()
        {
            Id = fetched.Id, Name = fetched.Name,
        };
    }

    [DataLoader]
    public static async Task<IReadOnlyDictionary<int, Book>> BooksByIds(
        IReadOnlyList<int> ids,
        CheckerDbContext dbContext,
        CancellationToken cancellationToken)
    {
        return await dbContext.Set<BookEntity>()
            .Select(static b => b.ToBook())
            .Where(b => ids.Contains(b.Id))
            .ToDictionaryAsync(static b => b.Id, cancellationToken: cancellationToken);
    }
}