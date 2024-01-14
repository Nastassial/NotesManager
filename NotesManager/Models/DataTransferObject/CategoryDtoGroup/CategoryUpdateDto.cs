using NotesManager.Entities;

namespace NotesManager.Models.DataTransferObject.CategoryDtoGroup;

public class CategoryUpdateDto
{
    public int Id { get; set; }

    public string? Name { get; set; } = null!;


    public int? ParentId { get; set; }
    public Category? Parent { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }
}
