using System;
namespace HoteleriaMascotas.Models
{
    class TipoSolicitudM
    {

        private int IdTipoSolicitud;
        private String NombreSolicitud;
    

        public int idtiposolicitud
        {
            set
            {
                IdTipoSolicitud = value;
            }
            get
            {
                return IdTipoSolicitud;
            }
        }

        public String nombresolicitud
        {
            set
            {
                NombreSolicitud = value;
            }
            get
            {
                return NombreSolicitud;
            }
        }

        
    }
    }
