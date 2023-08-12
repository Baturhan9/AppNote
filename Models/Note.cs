namespace NoteWebApplication.Models;

public class Note
{
    public int Id {get;}
    public string Title {get;}
    public string Description {get;}
    public bool IsDone {get;}
    public Note(int id, string title, string description, bool isDone = false)
    {
        Id = id;
        Title = title;
        Description = description;
        IsDone = isDone;
    }
    
}