using NotesManager.Entities;

namespace NotesManager.Models.DataTransferObject.NoteDtoGroup;

public class NoteDto
{
    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    //public int? CategoryId { get; set; }

    public int UserId { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Updated { get; set; }
}
