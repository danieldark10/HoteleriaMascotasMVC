using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Administracionsolicitud
    {
        public Administracionsolicitud()
        {
            Pagosses = new HashSet<Pagoss>();
        }

        public int Idsolicitud { get; set; }
        public string Observaciones { get; set; } = null!;
        public string Respuesta { get; set; } = null!;
        public int Idadministacionsolicitud { get; set; }
        public int Idtrabajador { get; set; }
        public bool Estado { get; set; }

        public virtual Solicitud IdsolicitudNavigation { get; set; } = null!;
        public virtual Trabajador IdtrabajadorNavigation { get; set; } = null!;
        public virtual ICollection<Pagoss> Pagosses { get; set; }
    }
}
