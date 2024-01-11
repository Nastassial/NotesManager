using Microsoft.EntityFrameworkCore;
using NotesManager.Database;
using NotesManager.Entities;
using NotesManager.Models.DataTransferObject;
using NotesManager.Services.Interfaces;

namespace NotesManager.Services;

public class DbDataProvider : IDataProvider
{
    private readonly NoteDbContext _db;

    public DbDataProvider(NoteDbContext db)
    {
        _db = db;
    }

    public void AddNote(Note note)
    {
        Console.WriteLine($"Title = {note.Title}, Content = {note.Content}, CategoryId = {note.CategoryId}, UserId = {note.UserId}");

        _db.Notes.Add(note);
        _db.SaveChanges();

        //await _db.Notes.AddAsync(note);
        //await _db.SaveChangesAsync();
    }

    public Note? GetNote(int id)
    {
        Console.WriteLine($"id = {id}");

        return _db.Notes.Where(x => x.Id == id).FirstOrDefault();

        //return await _db.Notes.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public void DeleteNote(int id)
    {
        Console.WriteLine($"id = {id}");

        Note? note = GetNote(id);

        if (note != null)
        {
            _db.Notes.Remove(note);
            _db.SaveChanges();

            //_db.Notes.Remove(note);
            //await _db.SaveChangesAsync();
        }
    }

    public Note? UpdateNote(Note note)
    {
        Console.WriteLine($"id = {note.Id}");

        _db.Notes.Update(note);
        _db.SaveChanges();

        //_db.Notes.Update(note);
        //await _db.SaveChangesAsync();

        return note;
    }

    public void UpdateNoteCategory(Note note)
    {
        Console.WriteLine($"id = {note.Id}");

        Note? noteDb = GetNote(note.Id);

        if (noteDb != null)
        {
            noteDb.CategoryId = note.CategoryId;

            _db.Notes.Update(noteDb);
            _db.SaveChanges();
            
            //_db.Notes.Update(noteDb);
            //await _db.SaveChangesAsync();
        }
    }

    public void AddCategory(Category category)
    {
        Console.WriteLine($"categoryName = {category.Name}");

        _db.Categories.Add(category);
        _db.SaveChanges();
        
        //await _db.Categories.AddAsync(category);
        //await _db.SaveChangesAsync();
    }

    public Category? GetCategory(int id)
    {
        Console.WriteLine($"id = {id}");

        return _db.Categories.Where(x => x.Id == id).FirstOrDefault();
        
        //return await _db.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public void DeleteCategory(int id)
    {
        Console.WriteLine($"id = {id}");

        Category? category = GetCategory(id);

        if (category != null)
        {
            _db.Categories.Remove(category);
            _db.SaveChanges();

            //_db.Categories.Remove(category);
            //await _db.SaveChangesAsync();
        }
    }

    public Category? UpdateCategory(Category category)
    {
        Console.WriteLine($"id = {category.Id}");

        _db.Categories.Update(category);
        _db.SaveChanges();

        //_db.Categories.Update(category);
        //await _db.SaveChangesAsync();

        return category;
    }

    public List<Category> GetUserCategoryList(int userId)
    {
        return _db.Categories.Where(c => c.UserId == userId).ToList();
        
        //return await _db.Categories.Where(c => c.UserId == userId).ToListAsync();
    }
}
