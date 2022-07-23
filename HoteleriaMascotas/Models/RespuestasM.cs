using System;
namespace HoteleriaMascotas.Models
{
    class RespuestaM
    {

        private int IdRespuesta;
        private String Textorespuesta;

        public String sexo
        {
            set
            {
                Textorespuesta = value;
            }
            get
            {
                return Textorespuesta;
            }
        }

        
    }
 }
