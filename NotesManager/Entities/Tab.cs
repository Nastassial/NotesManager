namespace NotesManager.Entities;

public class Tab
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string? Description { get; set; }

    public string Url { get; set; }



    public int UserId { get; set; }
    public UserProfile? UserProfile { get; set; }

    //public int? CategoryId { get; set; }
    public List<Category> Categories { get; set; }
}
