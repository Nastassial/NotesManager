namespace NotesManager.Entities;

public class User
{
    public int Id { get; set; }
 
    public string Login { get; set; } = null!;
    
    public string Password { get; set; } = null!;


    public UserProfile? Profile { get; set; }

    public List<Tab> Tabs { get; set; } = new List<Tab>();

    public List<Note> Notes { get; set; } = new List<Note>();

    public List<Contact> Contacts { get; set; } = new List<Contact>();
}
