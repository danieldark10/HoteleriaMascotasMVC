using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class SolicitarAdopcion : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
