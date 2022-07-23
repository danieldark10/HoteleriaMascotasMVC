using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class MascotaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
