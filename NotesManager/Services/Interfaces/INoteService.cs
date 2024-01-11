using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;

namespace NotesManager.Services.Interfaces;

public interface INoteService
{
    public void AddNote(NoteDto noteDto);

    public NoteDto? GetNote(NoteChangeDto noteChangeDto);

    public Note? UpdateNote(NoteUpdateDto noteUpdateDto);

    public void DeleteNote(NoteChangeDto noteChangeDto);

    public void UpdateNoteCategory(NoteChangeCategoryDto noteChangeCategoryDto);
}
