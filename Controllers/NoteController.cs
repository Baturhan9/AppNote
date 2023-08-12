using Microsoft.AspNetCore.Mvc;

namespace NoteWebApplication.Controllers;

public class NoteController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}