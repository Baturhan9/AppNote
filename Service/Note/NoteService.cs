using NoteWebApplication.Models;
namespace NoteWebApplication.Service.NoteDb;

public class NoteService : INoteService
{
    private List<Note> _notes = new List<Note>();
    public void CreateNote(Note note)
    {
        _notes.Add(note);
    }

    public List<Note> GetAllNotes()
    {
        return _notes;
    }

    public Note? GetOneNote(Guid? id)
    {
        return _notes.FirstOrDefault(x => x.Id == id);
    }

    public void DeleteNote (Note dnote)
    {
        _notes.Remove(dnote);
    }
}