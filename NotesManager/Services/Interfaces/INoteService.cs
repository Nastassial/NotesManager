using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.CommonDtoGroup;
using NotesManager.Models.DataTransferObject.NoteDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface INoteService
{
    public void AddNote(NoteDto noteDto);

    public NoteDto? GetNote(EntityIdDto noteChangeDto);

    public Note? UpdateNote(NoteUpdateDto noteUpdateDto);

    public void DeleteNote(EntityIdDto noteChangeDto);

    public void UpdateNoteCategory(NoteChangeCategoryDto noteChangeCategoryDto);
}
