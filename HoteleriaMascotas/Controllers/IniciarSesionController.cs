using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class IniciarSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
