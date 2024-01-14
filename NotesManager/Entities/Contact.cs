namespace NotesManager.Entities;

public class Contact
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string? Comment { get; set; }



    public int UserId { get; set; }
    public User? User { get; set; }

    public List<Category> Categories { get; set; } = new List<Category>();
}
