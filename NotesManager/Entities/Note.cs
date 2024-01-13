namespace NotesManager.Entities;

public class Note
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime Created { get; set; } = DateTime.UtcNow;

    public DateTime? Updated { get; set; }


    public int UserId { get; set; }
    public User? User { get; set; }

    //public List<Category> Categories { get; set; }
}
