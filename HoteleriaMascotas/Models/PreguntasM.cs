using System;
namespace HoteleriaMascotas.Models
{
    class PreguntasM
    {

        private int IdPregunta;
        private String TextoPregunto;


        public String textopregunto
        {
            set
            {
                TextoPregunto = value;
            }
            get
            {
                return TextoPregunto;
            }
        }


    }
}