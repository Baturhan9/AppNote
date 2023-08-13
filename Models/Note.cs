namespace NoteWebApplication.Models;

public class Note
{
    public Guid Id {get;}
    public string Title {get;}
    public string? Description {get;}
    public bool IsDone {get;}
    public Note(string title, string? description, bool isDone = false)
    {
        Id = Guid.NewGuid();
        Title = title;
        Description = description;
        IsDone = isDone;
    }
    
}