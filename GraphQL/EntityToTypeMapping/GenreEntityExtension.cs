using System.Linq.Expressions;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.EntityToTypeMapping;

public static class GenreEntityExtension
{
    public static Expression<Func<GenreEntity, string>> GetSelectionExpression()
    {
        return static b => b.Name;
    }

    public static Func<GenreEntity, string> GetSelection()
    {
        return static b => b.Name;
    }
}