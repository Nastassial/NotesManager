namespace NotesManager.Entities;

public class Contact
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Email { get; set; }

    public string Phone { get; set; }

    public string? Comment { get; set; }



    public int UserId { get; set; }
    public UserProfile? User { get; set; }
    //public List<UserProfile> Users { get; set; }

    //public int? CategoryId { get; set; }
    public List<Category> Categories { get; set; }
}
