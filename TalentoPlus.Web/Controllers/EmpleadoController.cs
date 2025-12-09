using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TalentoPlus.Core.Entities;
using TalentoPlus.Infrastructure.Data;

namespace TalentoPlus.Web.Controllers;

public class EmpleadoController : Controller
{
    private readonly ApplicationDbContext _context;

    public EmpleadoController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Empleado
    public async Task<IActionResult> Index()
    {
        var empleados = await _context.Empleados.ToListAsync();
        return View(empleados);
    }
    
    
    public IActionResult Create()
    {
        return View();
    }

    // POST: Empleado/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Empleado empleado)
    {
        if (ModelState.IsValid)
        {
            try
            {
                // Verificar si ya existe un empleado con ese documento
                var existeDocumento = await _context.Empleados
                    .AnyAsync(e => e.Documento == empleado.Documento);
                
                if (existeDocumento)
                {
                    ModelState.AddModelError("Documento", "Ya existe un empleado con este documento");
                    return View(empleado);
                }

                // Verificar si ya existe un empleado con ese email
                var existeEmail = await _context.Empleados
                    .AnyAsync(e => e.Email == empleado.Email);
                
                

                _context.Add(empleado);
                await _context.SaveChangesAsync();
                
                TempData["SuccessMessage"] = "Empleado creado exitosamente";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error al crear el empleado: {ex.Message}");
            }
        }
        
        return View(empleado);
    }
    
}