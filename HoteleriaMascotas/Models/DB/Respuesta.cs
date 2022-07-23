using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Respuesta
    {
        public int Idrespuesta { get; set; }
        public int Idpregunta { get; set; }
        public string Textorespuesta { get; set; } = null!;

        public virtual Pregunta IdpreguntaNavigation { get; set; } = null!;
    }
}
