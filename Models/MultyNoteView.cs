using System.Collections;

namespace NoteWebApplication.Models;

public class MultyNoteView
{
    public string Title { get; set; }
    public string Description { get; set; }
    public IEnumerable<Note> Notes {get;set;}
}