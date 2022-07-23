using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Trabajador
    {
        public Trabajador()
        {
            Administracionsolicituds = new HashSet<Administracionsolicitud>();
            Agendabanos = new HashSet<Agendabano>();
        }

        public int Idtrabajador { get; set; }
        public int Idpersona { get; set; }
        public int Idrol { get; set; }
        public DateTime Fechaingreso { get; set; }
        public string Area { get; set; } = null!;

        public virtual Persona IdpersonaNavigation { get; set; } = null!;
        public virtual Rol IdrolNavigation { get; set; } = null!;
        public virtual ICollection<Administracionsolicitud> Administracionsolicituds { get; set; }
        public virtual ICollection<Agendabano> Agendabanos { get; set; }
    }
}
