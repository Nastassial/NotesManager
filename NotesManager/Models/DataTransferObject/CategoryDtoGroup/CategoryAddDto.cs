using NotesManager.Entities;

namespace NotesManager.Models.DataTransferObject.CategoryDtoGroup;

public class CategoryAddDto
{
    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public int? ParentId { get; set; }
    public Category? Parent { get; set; }
}
