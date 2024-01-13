using Microsoft.AspNetCore.Mvc;
using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.ContactDtoGroup;
using NotesManager.Services.Interfaces;

namespace NotesManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ContactsController : ControllerBase
    {
        private readonly ILogger<ContactsController> _logger;

        private readonly IContactService _contactService;

        public ContactsController(ILogger<ContactsController> logger, IContactService service)
        {
            _logger = logger;
            _contactService = service;
        }

        [HttpPost]
        public IActionResult AddContact([FromBody] ContactDto contactDto)
        {
            _contactService.AddContact(contactDto);

            return Ok(contactDto);
        }

        [HttpPost]
        public IActionResult GetContact([FromBody] EntityIdDto contactIdDto)
        {
            ContactDto? contact = _contactService.GetContact(contactIdDto);

            if (contact == null) { return BadRequest(string.Empty); }

            return Ok(contact);
        }

        [HttpPost]
        public IActionResult DeleteContact([FromBody] EntityIdDto contactIdDto)
        {
            _contactService.DeleteContact(contactIdDto);

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateContact([FromBody] ContactUpdateDto contactUpdateDto)
        {
            Contact? contact = _contactService.UpdateContact(contactUpdateDto);

            if (contact == null) { return BadRequest(string.Empty); }

            return Ok(contact);
        }
    }
}
