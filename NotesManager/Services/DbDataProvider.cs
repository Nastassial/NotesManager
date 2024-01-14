using NotesManager.Database;
using NotesManager.Entities;
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
        Console.WriteLine($"Title = {note.Title}, Content = {note.Content}, CategoryId = empty, UserId = {note.UserId}");

        _db.Notes.Add(note);
        _db.SaveChanges();

        //await _db.Notes.AddAsync(note);
        //await _db.SaveChangesAsync();
    }

    public Note? GetNote(int id)
    {
        Console.WriteLine($"id = {id}");

        return _db.Notes.Where(n => n.Id == id).FirstOrDefault();

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
            //noteDb.CategoryId = note.CategoryId;

            _db.Notes.Update(noteDb);
            _db.SaveChanges();
            
            //_db.Notes.Update(noteDb);
            //await _db.SaveChangesAsync();
        }
    }

    public void AddCategory(Category category)
    {
        Console.WriteLine($"categoryName = {category.Name}");

        Category? categoryDb = _db.Categories
                                    .Where(c => c.Name.Trim() == category.Name.Trim() 
                                        && c.ParentId == category.ParentId 
                                        && c.UserId == category.UserId)
                                    .FirstOrDefault();

        if (categoryDb == null) 
        {
            _db.Categories.Add(category);
            _db.SaveChanges();

            //await _db.Categories.AddAsync(category);
            //await _db.SaveChangesAsync();
        }
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
        User? user = GetUser(userId);

        if (user == null) { return new List<Category>(); }

        //return _db.Categories.Where(c => c.Users.Contains(user)).ToList();
        return new List<Category>();

        //return await _db.Categories.Where(c => c.Users.Contains(user)).ToListAsync();
    }

    public User? GetUser(int id)
    {
        Console.WriteLine($"id = {id}");

        return _db.Users.Where(u => u.Id == id).FirstOrDefault();

        //return await _db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
    }

    public void AddTab(Tab tab)
    {
        Console.WriteLine($"Title = {tab.Title}, Content = {tab.Description}, CategoryId = empty, UserId = {tab.UserId}");

        _db.Tabs.Add(tab);
        _db.SaveChanges();

        //await _db.Tabs.AddAsync(tab);
        //await _db.SaveChangesAsync();
    }

    public Tab? GetTab(int id)
    {
        Console.WriteLine($"id = {id}");

        List<Tab> tabs = _db.Tabs.ToList();

        return _db.Tabs.Where(n => n.Id == id).FirstOrDefault();

        //return await _db.Tabs.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public void DeleteTab(int id)
    {
        Console.WriteLine($"id = {id}");

        Tab? tab = GetTab(id);

        if (tab != null)
        {
            _db.Tabs.Remove(tab);
            _db.SaveChanges();

            //_db.Tabs.Remove(tab);
            //await _db.SaveChangesAsync();
        }
    }

    public Tab? UpdateTab(Tab tab)
    {
        Console.WriteLine($"id = {tab.Id}");

        _db.Tabs.Update(tab);
        _db.SaveChanges();

        //_db.Tabs.Update(tab);
        //await _db.SaveChangesAsync();

        return tab;
    }

    public void AddContact(Contact contact)
    {
        //Console.WriteLine($"Title = {note.Title}, Content = {note.Content}, CategoryId = empty, UserId = {note.UserId}");

        _db.Contacts.Add(contact);
        _db.SaveChanges();

        //await _db.Contacts.AddAsync(contact);
        //await _db.SaveChangesAsync();
    }

    public Contact? GetContact(int id)
    {
        Console.WriteLine($"id = {id}");

        return _db.Contacts.Where(n => n.Id == id).FirstOrDefault();

        //return await _db.Contacts.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public void DeleteContact(int id)
    {
        Console.WriteLine($"id = {id}");

        Contact? contact = GetContact(id);

        if (contact != null)
        {
            _db.Contacts.Remove(contact);
            _db.SaveChanges();

            //_db.Contacts.Remove(contact);
            //await _db.SaveChangesAsync();
        }
    }

    public Contact? UpdateContact(Contact contact)
    {
        Console.WriteLine($"id = {contact.Id}");

        _db.Contacts.Update(contact);
        _db.SaveChanges();

        //_db.Contacts.Update(contact);
        //await _db.SaveChangesAsync();

        return contact;
    }

    public void AddUser(User user)
    {
        //Console.WriteLine($"Title = {tab.Title}, Content = {tab.Description}, CategoryId = empty, UserId = {tab.UserId}");

        _db.Users.Add(user);
        _db.SaveChanges();

        //await _db.Users.AddAsync(user);
        //await _db.SaveChangesAsync();
    }

    public void DeleteUser(int id)
    {
        Console.WriteLine($"id = {id}");

        User? user = GetUser(id);

        if (user != null)
        {
            _db.Users.Remove(user);
            _db.SaveChanges();

            //_db.Users.Remove(user);
            //await _db.SaveChangesAsync();
        }
    }
}
