using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.EntityToTypeMapping;

public static class UserEntityExtension
{
    public static User? ToUser(this UserEntity entity)
    {
        return new()
        {
            Id = entity.Id, Name = entity.Name, SurName = entity.SurName,
        };
    }
}