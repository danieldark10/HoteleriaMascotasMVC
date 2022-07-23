using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
