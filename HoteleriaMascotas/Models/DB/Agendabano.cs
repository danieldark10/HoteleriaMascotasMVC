using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Agendabano
    {
        public int Idsolicitud { get; set; }
        public int Idagendabanos { get; set; }
        public int Idtrabajador { get; set; }
        public DateTime Fechabano { get; set; }
        public DateTime Horariobanoinicio { get; set; }
        public DateTime Horariobanotermino { get; set; }
        public decimal Precioporbano { get; set; }

        public virtual Solicitud IdsolicitudNavigation { get; set; } = null!;
        public virtual Trabajador IdtrabajadorNavigation { get; set; } = null!;
    }
}
