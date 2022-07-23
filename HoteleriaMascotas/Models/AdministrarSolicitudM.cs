using System;
namespace HoteleriaMascotas.Models
{
    class AdministrarSolicitudM
    {

        private int Idsolicitud;
        private String Observaciones;
        private String Respuesta;
        private Boolean Estado;

        public String observaciones
        {
            set
            {
                Observaciones = value;
            }
            get
            {
                return Observaciones;
            }
        }

        public String respuesta
        {
            set
            {
                Respuesta = value;
            }
            get
            {
                return Respuesta;
            }
        }

        public Boolean estado
        {
            set
            {
                Estado = value;
            }
            get
            {
                return Estado;
            }
        }
       
        }
    }
    
