namespace HotChocolate.Checker.GraphQL.Types;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    [IsProjected(true)]
    public string SurName { get; set; }
}