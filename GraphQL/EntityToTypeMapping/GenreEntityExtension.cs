using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.EntityToTypeMapping;

public static class GenreEntityExtension
{
    public static Genre? ToGenre(this GenreEntity? entity)
    {
        return new()
        {
            Id = entity.Id,
            Name = entity.Name,
        };
    }
}