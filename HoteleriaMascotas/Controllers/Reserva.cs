using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class Reserva : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
