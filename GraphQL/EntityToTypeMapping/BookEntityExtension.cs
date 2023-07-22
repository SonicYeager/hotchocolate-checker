using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.EntityToTypeMapping;

public static class BookEntityExtension
{
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