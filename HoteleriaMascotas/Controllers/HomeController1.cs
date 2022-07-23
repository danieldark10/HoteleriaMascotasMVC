using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
