using Microsoft.AspNetCore.Mvc;

namespace Turnos.Controllers
{
  public class EspecialidadController : Controller
  {
    public EspecialidadController()
    {

    }
    
    // IActionResult : retornara una vista
    public IActionResult Index()
    {
      return View();
    } 
  }
}