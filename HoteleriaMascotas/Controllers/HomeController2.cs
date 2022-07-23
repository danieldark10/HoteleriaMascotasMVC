using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
