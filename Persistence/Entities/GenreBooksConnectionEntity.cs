namespace HotChocolate.Checker.Persistence.Entities;

public class GenreBooksConnectionEntity
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int GenreId { get; set; }
}