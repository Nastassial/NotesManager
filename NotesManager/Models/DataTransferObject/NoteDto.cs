namespace NotesManager.Models.DataTransferObject;

public class NoteDto
{
    public string Title { get; set; }

    public string Content { get; set; }

    public int? CategoryId { get; set; }

    public int UserId { get; set; }
}
