using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Mascotum
    {
        public Mascotum()
        {
            Solicituds = new HashSet<Solicitud>();
            Statuses = new HashSet<Status>();
        }

        public int Idmascota { get; set; }
        public int Idcliente { get; set; }
        public string Nombre { get; set; } = null!;
        public float Edad { get; set; }
        public int Chip { get; set; }
        public string Raza { get; set; } = null!;
        public string Tipoanimal { get; set; } = null!;
        public string Personalidad { get; set; } = null!;

        public virtual Cliente IdclienteNavigation { get; set; } = null!;
        public virtual ICollection<Solicitud> Solicituds { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }
    }
}
