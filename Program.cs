using NoteWebApplication.Service.NoteDb;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();
    builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
    builder.Services.AddSingleton<INoteService, NoteService>();
}

var app = builder.Build();
{
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    app.Run();
}


