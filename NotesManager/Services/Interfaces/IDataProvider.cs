using NotesManager.Entities;

namespace NotesManager.Services.Interfaces;

public interface IDataProvider
{
    public void AddNote(Note note);

    public Note? GetNote(int id);

    public Note? UpdateNote(Note note);

    public void DeleteNote(int id);

    public void UpdateNoteCategory(Note note);

    public void AddCategory(Category category);

    public void DeleteCategory(int id);

    public Category? GetCategory(int id);

    public Category? UpdateCategory(Category category);

    public List<Category> GetUserCategoryList(int userId);
}
