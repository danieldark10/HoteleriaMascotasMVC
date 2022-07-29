using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class Habitacion : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
