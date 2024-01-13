using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.ContactDtoGroup;
using NotesManager.Services.Interfaces;
using System.Numerics;

namespace NotesManager.Services;

public class ContactService : IContactService
{
    private readonly IDataProvider _provider;

    public ContactService(IDataProvider provider) 
    {
        _provider = provider;
    }

    public void AddContact(ContactDto contactDto)
    {
        Contact contact = new Contact()
        {
            FirstName = contactDto.FirstName,
            LastName = contactDto.LastName,
            MiddleName = contactDto.MiddleName,
            Email = contactDto.Email,
            Phone = contactDto.Phone,
            Comment = contactDto.Comment,
            //CategoryId = contactDto.CategoryId,
            UserId = contactDto.UserId,
};

        _provider.AddContact(contact);
    }

    public ContactDto? GetContact(EntityIdDto contactDto)
    {
        Contact? contact = _provider.GetContact(contactDto.Id);

        if (contact == null) { return null; }

        return new ContactDto
        {
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            MiddleName = contact.MiddleName,
            Email = contact.Email,
            Phone = contact.Phone,
            Comment = contact.Comment,
            //CategoryId = contact.CategoryId,
            UserId = contact.UserId,
        };
    }

    public Contact? UpdateContact(ContactUpdateDto contactUpdateDto)
    {
        Contact? contact = _provider.GetContact(contactUpdateDto.Id);

        if (contact == null) { return null; }

        //contact.Updated = DateTime.UtcNow;
        contact.FirstName = contact.FirstName;
        contact.LastName = contact.LastName;
        contact.MiddleName = contact.MiddleName;
        contact.Email = contact.Email;
        contact.Phone = contact.Phone;
        contact.Comment = contact.Comment;
        contact.UserId = contact.UserId;

        return _provider.UpdateContact(contact);
    }

    public void DeleteContact(EntityIdDto contactChangeDto)
    {
        _provider.DeleteContact(contactChangeDto.Id);
    }
}
