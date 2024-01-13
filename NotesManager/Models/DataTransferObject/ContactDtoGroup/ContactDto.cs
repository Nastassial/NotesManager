using NotesManager.Entities;

namespace NotesManager.Models.DataTransferObject.ContactDtoGroup;

public class ContactDto
{
    //public int? CategoryId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string? Comment { get; set; }

    public int UserId { get; set; }
}
