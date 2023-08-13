using NoteWebApplication.Models;

namespace NoteWebApplication.Service.NoteDb;

public interface INoteService
{
    void CreateNote(Note note);
    Note? GetOneNote(Guid id);
    List<Note> GetAllNotes();
}