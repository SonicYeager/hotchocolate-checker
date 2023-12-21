namespace HotChocolate.Checker.GraphQL.Types;

public sealed class Book : IType
{
    //[IsProjected]
    public int Id { get; set; } // Unique Identifier for the book

    public string Title { get; set; } = null!; // Title of the book

    //[IsProjected] //TODO uncomment for testing bug
    public User? Author { get; set; } // Author of the book

    public int GenreCount { get; set; }

    public Genre? FirstGenre { get; set; }

    public DateTime PublicationDate { get; set; } // Date when the book was published
    public string ISBN { get; set; } = null!; // International Standard Book Number
    public int PageCount { get; set; } // Number of pages in the book
    public string Language { get; set; } = null!; // Language in which the book is written
}