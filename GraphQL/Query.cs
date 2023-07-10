using HotChocolate.Checker.Extensions;
using HotChocolate.Checker.GraphQL.EntityToTypeMapping;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence;
using HotChocolate.Checker.Persistence.Entities;
using HotChocolate.Resolvers;

namespace HotChocolate.Checker.GraphQL;

[QueryType]
public sealed class Query
{
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<BookEntity> Books([Service] CheckerDbContext checkerDbContext)
    {
        return checkerDbContext.Set<BookEntity>();
    }

    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Book> BooksSelection([Service] CheckerDbContext checkerDbContext)
    {
        return checkerDbContext.Set<BookEntity>()
            .Select(BookEntityExtension.GetSelection());
    }

    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Book> BooksFix([Service] CheckerDbContext checkerDbContext, IResolverContext resolverContext)
    {
        return checkerDbContext.Set<BookEntity>().ProjectToFix<BookEntity, Book>(resolverContext);
    }
}