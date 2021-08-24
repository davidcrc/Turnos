using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Turnos.Models;

namespace Turnos.Controllers
{
  public class EspecialidadController : Controller
  {
    private readonly TurnosContext _context;

    public EspecialidadController(TurnosContext context)
    {
      _context = context;
    }
    
    // IActionResult : retornara una vista
    public IActionResult Index()
    {
      // Pasando datos de la tabla especialidad a la vista
      return View(_context.Especialidad.ToList());
    } 
  }
}