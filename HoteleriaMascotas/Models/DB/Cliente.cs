using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Cliente
    {
        public Cliente()
        {
            Mascota = new HashSet<Mascotum>();
            Solicituds = new HashSet<Solicitud>();
        }

        public int Idcliente { get; set; }
        public int Idpersona { get; set; }
        public int Idrol { get; set; }
        public int Numeropagos { get; set; }

        public virtual Persona IdpersonaNavigation { get; set; } = null!;
        public virtual Rol IdrolNavigation { get; set; } = null!;
        public virtual ICollection<Mascotum> Mascota { get; set; }
        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
