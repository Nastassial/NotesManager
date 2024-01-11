namespace NotesManager.Entities;

public class UserProfile
{
    public int Id { get; set; }

    public string Nickname { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }


    public int UserId { get; set; }
    public User? User { get; set; }
}
