using HotChocolate.Checker.Extensions;
using HotChocolate.Checker.GraphQL.EntityToTypeMapping;
using HotChocolate.Checker.GraphQL.TypeExtensions;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence;
using HotChocolate.Checker.Persistence.Entities;
using HotChocolate.Resolvers;

namespace HotChocolate.Checker.GraphQL;

[QueryType]
public static class Query
{
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<BookEntity> Books(CheckerDbContext checkerDbContext)
    {
        return checkerDbContext.Set<BookEntity>();
    }

    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Book> BooksSelection(CheckerDbContext checkerDbContext)
    {
        return checkerDbContext.Set<BookEntity>()
            .Select(static b => b.ToBook());
    }

    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public static IQueryable<Book> BooksFix(CheckerDbContext checkerDbContext, IResolverContext resolverContext)
    {
        resolverContext.ReportError(new InvalidOperationException("Some error"), static eb => eb.SetPath(new[]
        {
            "input", "elem",
        }));
        return checkerDbContext.Set<BookEntity>().ProjectToFix<BookEntity, Book>(resolverContext);
    }

    public static async Task<Genre> GenreById(int genreId, IGenreByIdDataLoader dataLoader, CancellationToken cancellationToken)
    {
        return await dataLoader.LoadAsync(genreId, cancellationToken);
    }
}