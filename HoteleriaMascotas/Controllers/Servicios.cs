using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class Servicios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
