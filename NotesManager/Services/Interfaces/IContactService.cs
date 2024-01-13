using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.ContactDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface IContactService
{
    public void AddContact(ContactDto contactDto);

    public ContactDto? GetContact(ContactIdDto contactChangeDto);

    public Contact? UpdateContact(ContactUpdateDto contactUpdateDto);

    public void DeleteContact(ContactIdDto contactChangeDto);
}
