using Microsoft.AspNetCore.Mvc;

namespace TalentoPlus.API.Controllers;

public class EmpleadoController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}