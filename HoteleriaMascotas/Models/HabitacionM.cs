using System;
namespace HoteleriaMascotas.Models
{
    class HabitacionM
    {

        private int IdHabitacion;
        private String TipoHabitacion;
        private String NumeroHabitacion;
        private decimal PrecioHora;
        private String Caracteristicas;
        private String Estado;

        public String tipohabitacion
        {
            set
            {
                TipoHabitacion = value;
            }
            get
            {
                return TipoHabitacion;
            }
        }

        public String numerohabitacion
        {
            set
            {
                NumeroHabitacion = value;
            }
            get
            {
                return NumeroHabitacion;
            }
        }

        public Decimal preciohora
        {
            set
            {
                PrecioHora= value;
            }
            get
            {
                return PrecioHora;
            }
        }
        public String caracterisitas
        {
            set
            {
                   Caracteristicas = value;
            }
            get
            {
                return Caracteristicas;
            }
        }
        public String estado
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
    
