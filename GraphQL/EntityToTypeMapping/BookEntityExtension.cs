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
            ISBN = b.ISBN,
            Language = b.Language,
            PageCount = b.PageCount,
            PublicationDate = b.PublicationDate,
            Title = b.Title,
        };
    }

    public static Book ToBook(this BookEntity bookEntity)
    {
        return new()
        {
            Id = bookEntity.Id,
            Author = bookEntity.Author?.ToUser(),
            ISBN = bookEntity.ISBN,
            Language = bookEntity.Language,
            PageCount = bookEntity.PageCount,
            PublicationDate = bookEntity.PublicationDate,
            Title = bookEntity.Title,
        };
    }
}