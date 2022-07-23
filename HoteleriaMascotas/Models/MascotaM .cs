using System;
namespace HoteleriaMascotas.Models
{
    class MascotaM
    {

        private int IdMascota;
        private String Nombre;
        private float Edad;
        private int Chip;
        private String Raza;
        private String TipoAnimal;
        private String Personalidad;

        public String nombre
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return Nombre;
            }
        }

        public float edad
        {
            set
            {
                Edad = value;
            }
            get
            {
                return Edad;
            }
        }

        public int chip
        {
            set
            {
                Chip = value;
            }
            get
            {
                return Chip;
            }
        }
        public String raza
        {
            set
            {
                Raza = value;
            }
            get
            {
                return Raza;
            }
        }
        public String tipoanimal
        {
            set
            {
                TipoAnimal = value;
            }
            get
            {
                return TipoAnimal;
            }
        }
        public String personalidad
        {
            set
            {
                Personalidad = value;
            }
            get
            {
                return Personalidad;
            }
        }
        
    }
    }
