using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.ContactDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface IContactService
{
    public void AddContact(ContactDto contactDto);

    public ContactDto? GetContact(EntityIdDto contactChangeDto);

    public Contact? UpdateContact(ContactUpdateDto contactUpdateDto);

    public void DeleteContact(EntityIdDto contactChangeDto);
}
