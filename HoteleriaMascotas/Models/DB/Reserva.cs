using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Reserva
    {
        public int Idreserva { get; set; }
        public int Idsolicitud { get; set; }
        public int Idhabitacion { get; set; }
        public DateTime Fechaentrada { get; set; }
        public DateTime Fechasalida { get; set; }
        public DateTime Horarioentrada { get; set; }
        public DateTime Horariosalida { get; set; }
        public DateTime Fechareserva { get; set; }
        public string Estado { get; set; } = null!;
        public decimal Precio { get; set; }

        public virtual Habitacion IdhabitacionNavigation { get; set; } = null!;
        public virtual Solicitud IdsolicitudNavigation { get; set; } = null!;
    }
}
