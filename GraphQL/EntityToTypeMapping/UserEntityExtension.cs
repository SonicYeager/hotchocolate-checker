using System.Linq.Expressions;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.EntityToTypeMapping;

public static class UserEntityExtension
{
    public static Expression<Func<UserEntity, User>> GetSelection()
    {
        return static entity => new()
        {
            Id = entity.Id, Name = entity.Name, SurName = entity.SurName,
        };
    }

    public static User? ToUser(this UserEntity entity)
    {
        return new()
        {
            Id = entity.Id, Name = entity.Name, SurName = entity.SurName,
        };
    }
}