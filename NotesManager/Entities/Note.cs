namespace NotesManager.Entities;

public class Note
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;

    public DateTime? Updated { get; set; }


    public int UserId { get; set; }
    public UserProfile? User { get; set; }
    //public List<UserProfile> Users { get; set; }

    //public int? CategoryId { get; set; }
    public List<Category> Categories { get; set; } // навигационное св-во
}
