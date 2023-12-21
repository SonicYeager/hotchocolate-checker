namespace HotChocolate.Checker.Persistence.Entities;

public sealed class UserEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string SurName { get; set; } = null!;
}