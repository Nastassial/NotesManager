using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.NoteDtoGroup;

namespace NotesManager.Services.Interfaces;

public interface INoteService
{
    public void AddNote(NoteDto noteDto);

    public NoteDto? GetNote(NoteIdDto noteChangeDto);

    public Note? UpdateNote(NoteUpdateDto noteUpdateDto);

    public void DeleteNote(NoteIdDto noteChangeDto);

    public void UpdateNoteCategory(NoteChangeCategoryDto noteChangeCategoryDto);
}
