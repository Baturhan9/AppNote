using NoteWebApplication.Models;

namespace NoteWebApplication.Service.NoteDb;

public interface INoteService
{
    void CreateNote(Note note);
    void DeleteNote(Note dnote);
    Note? GetOneNote(Guid? id);
    List<Note> GetAllNotes();
}