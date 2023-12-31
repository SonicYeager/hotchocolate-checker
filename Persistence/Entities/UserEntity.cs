﻿namespace HotChocolate.Checker.Persistence.Entities;

public sealed class UserEntity
{
    [IsProjected(true)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
}