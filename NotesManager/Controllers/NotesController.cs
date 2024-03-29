using Microsoft.AspNetCore.Mvc;
using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.NoteDtoGroup;
using NotesManager.Services.Interfaces;

namespace NotesManager.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> _logger;

        private readonly INoteService _noteService;

        public NotesController(ILogger<NotesController> logger, INoteService service)
        {
            _logger = logger;
            _noteService = service;
        }

        [HttpPost]
        public IActionResult AddNote([FromBody] NoteDto noteDto)
        {
            _noteService.AddNote(noteDto);

            return Ok(noteDto);
        }

        [HttpPost]
        public IActionResult GetNote([FromBody] EntityIdDto noteIdDto)
        {
            NoteDto? note = _noteService.GetNote(noteIdDto);

            if (note == null) { return BadRequest(string.Empty); }

            return Ok(note);
        }

        [HttpPost]
        public IActionResult DeleteNote([FromBody] EntityIdDto noteIdDto)
        {
            _noteService.DeleteNote(noteIdDto);

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateNote([FromBody] NoteUpdateDto noteUpdateDto)
        {
            Note? note = _noteService.UpdateNote(noteUpdateDto);

            if (note == null) { return BadRequest(string.Empty); }

            return Ok(note);
        }

        [HttpPost]
        public IActionResult UpdateNoteCategory([FromBody] NoteChangeCategoryDto noteChangeCategoryDto)
        {
            _noteService.UpdateNoteCategory(noteChangeCategoryDto);

            return Ok();
        }

    }
}
