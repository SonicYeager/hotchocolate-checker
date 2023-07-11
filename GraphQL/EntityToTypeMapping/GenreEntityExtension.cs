using System.Linq.Expressions;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.EntityToTypeMapping;

public static class GenreEntityExtension
{
    public static Expression<Func<GenreEntity, Genre>> GetSelection()
    {
        return static g => new()
        {
            Id = g.Id,
            Name = g.Name,
        };
    }
}