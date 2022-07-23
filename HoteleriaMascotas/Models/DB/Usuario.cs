using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Usuario
    {
        public int Idusuario { get; set; }
        public int Idrol { get; set; }
        public string Nombreusuario { get; set; } = null!;
        public string Contrasena { get; set; } = null!;

        public virtual Rol IdrolNavigation { get; set; } = null!;
    }
}
