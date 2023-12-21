using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.Types;

public sealed class User
{
    //[IsProjected]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string SurName { get; set; } = null!;

    public static implicit operator User(UserEntity entity)
    {
        return new()
        {
            Id = entity.Id, Name = entity.Name, SurName = entity.SurName,
        };
    }
}