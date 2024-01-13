using NotesManager.Entities;

namespace NotesManager.Models.DataTransferObject.TabDtoGroup;

public class TabUpdateDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Url { get; set; } = null!;

    //public int? CategoryId { get; set; }
}
