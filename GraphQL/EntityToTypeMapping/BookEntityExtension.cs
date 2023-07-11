using System.Linq.Expressions;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.EntityToTypeMapping;

public static class BookEntityExtension
{
    public static Expression<Func<BookEntity, Book>> GetSelection()
    {
        return static b => new()
        {
            Id = b.Id,
            Author = b.Author.ToUser(),
            Genre = b.Genre.Select(GenreEntityExtension.GetSelection()),
            ISBN = b.ISBN,
            Language = b.Language,
            PageCount = b.PageCount,
            PublicationDate = b.PublicationDate,
            Title = b.Title,
        };
    }
}