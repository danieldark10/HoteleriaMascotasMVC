using System.Linq;
using System.Threading.Tasks;
using HoteleriaMascotas.Models;
using HoteleriaMascotas.Models.DB;
using Microsoft.AspNetCore.Mvc;

namespace HoteleriaMascotas.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            List<PersonaM> lst = new List<PersonaM>();
            using (var db = new Models.DB.HoteleriaMascotasContext())
            {
                lst = (from d in db.Personas
                       select new PersonaM
                       {
                           sexo = d.Sexo,
                           nombre = d.Nombre,
                           apellido = d.Apellido,
                           rut = d.Rut,
                           email = d.Email,
                           direccion = d.Direccion,
                           telefono = d.Telefono,
                       }).ToList();
            }
            
            return View(lst);
        }

        public IActionResult RegistrarPersona()
          
        {
            

            return View();
        }

    }
}
