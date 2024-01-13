using NotesManager.Entities;
using NotesManager.Models.DataTransferObject.NoteDtoGroup;
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
            //CategoryId = noteDto.CategoryId,
            UserId = noteDto.UserId,
        };

        _provider.AddNote(note);
    }

    public NoteDto? GetNote(NoteIdDto noteChangeDto)
    {
        Note? note = _provider.GetNote(noteChangeDto.Id);

        if (note == null) { return null; }

        return new NoteDto
        {
            Title = note.Title,
            Content = note.Content,
            //CategoryId = note.CategoryId,
            UserId = note.UserId,
            Created = note.Created,
            Updated = note.Updated,
        };
    }

    public Note? UpdateNote(NoteUpdateDto noteUpdateDto)
    {
        Note? note = _provider.GetNote(noteUpdateDto.Id);

        if (note == null) { return null; }

        note.Updated = DateTime.UtcNow;
        note.Title = noteUpdateDto.Title ?? string.Empty;
        note.Content = noteUpdateDto.Content ?? string.Empty;

        return _provider.UpdateNote(note);
    }

    public void DeleteNote(NoteIdDto noteChangeDto)
    {
        _provider.DeleteNote(noteChangeDto.Id);
    }

    public void UpdateNoteCategory(NoteChangeCategoryDto noteChangeCategoryDto)
    {
       // _provider.UpdateNoteCategory(new Note { Id = noteChangeCategoryDto.Id, CategoryId = noteChangeCategoryDto.CategoryId });
    }
}
