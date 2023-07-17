﻿using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.GraphQL.Types;

public class User
{
    [IsProjected(true)] public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }

    public static implicit operator User(UserEntity? entity)
    {
        return new()
        {
            Id = entity.Id, Name = entity.Name, SurName = entity.SurName,
        };
    }
}