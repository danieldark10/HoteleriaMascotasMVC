using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class SolicitudBaños : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
