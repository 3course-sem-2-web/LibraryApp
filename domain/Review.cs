namespace domain;

public class Review
{
    public int Id { get; set; }
    public string Message { get; set; } = null!;
    public string Reviewer { get; set; } = null!;
    public int BookId { get; set; }
}