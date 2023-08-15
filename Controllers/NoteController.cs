using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NoteWebApplication.Models;
using NoteWebApplication.Service.NoteDb;

namespace NoteWebApplication.Controllers;

public class NoteController : Controller
{
    private INoteService _noteService;


    public NoteController(INoteService noteService)
    {
        _noteService = noteService;
    }

    public IActionResult Index()
    {
        MultyNoteView modelView = new MultyNoteView();
        modelView.Notes = _noteService.GetAllNotes();
        return View(modelView);

    }

    [HttpPost]
    public IActionResult CreateNote(MultyNoteView multyNoteView)
    {
        var noteobj = new Note(
            multyNoteView.Title,
            multyNoteView.Description
        );
        _noteService.CreateNote(noteobj);

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult DeleteNote(Guid? id)
    {
        var noteobj = _noteService.GetOneNote(id);
        if(noteobj == null)
            return NotFound();
        _noteService.DeleteNote(noteobj);
        return RedirectToAction("Index");
    }
}