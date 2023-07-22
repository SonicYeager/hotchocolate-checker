namespace HotChocolate.Checker.GraphQL.Types;

public class Book : IType
{
    [IsProjected]
    public int Id { get; set; } // Unique Identifier for the book
    public string Title { get; set; } // Title of the book
    [IsProjected]
    public User? Author { get; set; } // Author of the book
    public DateTime PublicationDate { get; set; } // Date when the book was published
    public string ISBN { get; set; } // International Standard Book Number
    public int PageCount { get; set; } // Number of pages in the book
    public string Language { get; set; } // Language in which the book is written
}