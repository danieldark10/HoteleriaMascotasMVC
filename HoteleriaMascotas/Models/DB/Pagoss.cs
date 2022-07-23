using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Pagoss
    {
        public int Idpago { get; set; }
        public int Idadministacionsolicitud { get; set; }
        public DateTime Fechapago { get; set; }
        public decimal Montopago { get; set; }
        public bool Estado { get; set; }
        public string Numerocomprobante { get; set; } = null!;
        public DateTime Fechaemision { get; set; }

        public virtual Administracionsolicitud IdadministacionsolicitudNavigation { get; set; } = null!;
    }
}
