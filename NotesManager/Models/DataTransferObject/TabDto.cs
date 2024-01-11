namespace NotesManager.Models.DataTransferObject;

public class TabDto
{
    public int? CategoryId { get; set; }

    public string Title { get; set; }

    public string? Description { get; set; }

    public string Url { get; set; } = string.Empty;
}
