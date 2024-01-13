namespace NotesManager.Models.DataTransferObject.TabDtoGroup;

public class TabDto
{
    //public int? CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Url { get; set; } = null!;

    public int UserId { get; set; }
}
