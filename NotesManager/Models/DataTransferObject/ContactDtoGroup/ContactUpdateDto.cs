namespace NotesManager.Models.DataTransferObject.ContactDtoGroup;

public class ContactUpdateDto
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Comment { get; set; }

    //public int? CategoryId { get; set; }
}
