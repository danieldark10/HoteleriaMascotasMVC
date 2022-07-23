using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Pregunta
    {
        public Pregunta()
        {
            Respuesta = new HashSet<Respuesta>();
        }

        public int Idpregunta { get; set; }
        public int Idsolicitud { get; set; }
        public string Textopregunta { get; set; } = null!;

        public virtual Solicitud IdsolicitudNavigation { get; set; } = null!;
        public virtual ICollection<Respuesta> Respuesta { get; set; }
    }
}
