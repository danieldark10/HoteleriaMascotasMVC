using System;
namespace HoteleriaMascotas.Models
{
    class TrabajdorM
    {

        private int IdTrabajador;
        private DateOnly FechaIngreso;
        private String Area;

        public DateOnly fechaingreso
        {
            set
            {
                FechaIngreso = value;
            }
            get
            {
                return FechaIngreso;
            }
        }

        public String area
        {
            set
            {
                Area = value;
            }
            get
            {
                return Area;
            }
        }

       
    }
    }
