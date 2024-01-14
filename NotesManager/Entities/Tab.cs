namespace NotesManager.Entities;

public class Tab
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Url { get; set; } = null!;



    public int UserId { get; set; }
    public User? User { get; set; }

    public List<Category> Categories { get; set; } = new List<Category>();
}
