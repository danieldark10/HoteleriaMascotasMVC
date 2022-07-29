using Microsoft.AspNetCore.Mvc;
using HoteleriaMascotas.Models;
using HoteleriaMascotas.Models.DB;
namespace HoteleriaMascotas.Controllers
{
    public class MascotaController : Controller
    {

        [HttpPost]
        public ActionResult Index (MascotaM Models)
        {
           
            try
            {
               
                if (ModelState.IsValid)
                {
                    using (var db = new Models.DB.HoteleriaMascotasContext())
                    {
                        var Tabla = new Mascotum();
                        Tabla.Idcliente = Models.idCliente;
                        Tabla.Nombre = Models.Nombre;
                        Tabla.Edad = Models.Edad;
                        Tabla.Chip = Models.Chip;
                        Tabla.Raza = Models.Raza;
                        Tabla.Tipoanimal = Models.TipoDeAnimal;
                        Tabla.Personalidad = Models.Personalidad;

                        db.Mascota.Add(Tabla);
                        db.SaveChanges();

                    }
                    return Redirect("/");
                }
                return View(Models);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
