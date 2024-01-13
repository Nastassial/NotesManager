namespace NotesManager.Entities;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;


    public int? ParentId { get; set; }
    public Category? Parent { get; set; }
    public List<Category> Children { get; set; } = new List<Category>();

    public List<User> Users { get; set; } = new List<User>();
}
