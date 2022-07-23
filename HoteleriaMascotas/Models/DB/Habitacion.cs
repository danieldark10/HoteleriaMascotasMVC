using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Habitacion
    {
        public Habitacion()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int Idhabitacion { get; set; }
        public string Tipohabitacion { get; set; } = null!;
        public string Numerohabitacion { get; set; } = null!;
        public decimal Preciohora { get; set; }
        public string Caracteristicas { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
