using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Solicitud
    {
        public Solicitud()
        {
            Administracionsolicituds = new HashSet<Administracionsolicitud>();
            Agendabanos = new HashSet<Agendabano>();
            
            Reservas = new HashSet<Reserva>();
        }

        public int Idsolicitud { get; set; }
        public int Idmascota { get; set; }
        public int Idtipodesolicitud { get; set; }
        public int Idcliente { get; set; }
        public string Descripcionsolicitud { get; set; } = null!;

        public virtual Cliente IdclienteNavigation { get; set; } = null!;
        public virtual Mascotum IdmascotaNavigation { get; set; } = null!;
        public virtual Tipodesolicitud IdtipodesolicitudNavigation { get; set; } = null!;
        public virtual ICollection<Administracionsolicitud> Administracionsolicituds { get; set; }
        public virtual ICollection<Agendabano> Agendabanos { get; set; }
        
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
