using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Tipodesolicitud
    {
        public Tipodesolicitud()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int Idtipodesolicitud { get; set; }
        public string Nombresolicitud { get; set; } = null!;

        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
