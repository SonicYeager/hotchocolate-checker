namespace HotChocolate.Checker.Persistence.Entities;

public sealed class GenreEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IEnumerable<BookEntity> Book { get; set; }
}