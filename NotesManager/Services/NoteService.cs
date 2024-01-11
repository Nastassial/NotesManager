using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Services.Interfaces;

namespace NotesManager.Services;

public class NoteService : INoteService
{
    private readonly IDataProvider _provider;

    public NoteService(IDataProvider provider) 
    {
        _provider = provider;
    }

    public void AddNote(NoteDto noteDto)
    {
        Note note = new Note()
        {
            Title = noteDto.Title,
            Content = noteDto.Content,
            CategoryId = noteDto.CategoryId,
            UserId = noteDto.UserId,
        };

        _provider.AddNote(note);
    }

    public NoteDto? GetNote(NoteChangeDto noteChangeDto)
    {
        Note? note = _provider.GetNote(noteChangeDto.Id);

        if (note == null) { return null; }

        return new NoteDto
        {
            Title = note.Title,
            Content = note.Content,
            CategoryId = note.CategoryId,
            UserId = note.UserId,
        };
    }

    public Note? UpdateNote(NoteUpdateDto noteUpdateDto)
    {
        Note? note = _provider.GetNote(noteUpdateDto.Id);

        if (note == null) { return null; }

        note.Updated = DateTime.UtcNow;

        return _provider.UpdateNote(note);
    }

    public void DeleteNote(NoteChangeDto noteChangeDto)
    {
        _provider.DeleteNote(noteChangeDto.Id);
    }

    public void UpdateNoteCategory(NoteChangeCategoryDto noteChangeCategoryDto)
    {
        _provider.UpdateNoteCategory(new Note { Id = noteChangeCategoryDto.Id, CategoryId = noteChangeCategoryDto.CategoryId });
    }
}
