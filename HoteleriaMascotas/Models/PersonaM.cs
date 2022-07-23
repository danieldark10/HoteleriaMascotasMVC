using System;
namespace HoteleriaMascotas.Models
{
    class PersonaM
    {

        private int IdPersona;
        private String Sexo;
        private String Nombre;
        private String Apellido;
        private String Rut;
        private String Email;
        private String Direccion;
        private int Telefono;

        public String sexo
        {
            set
            {
                Sexo = value;
            }
            get
            {
                return Sexo;
            }
        }

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

        public String apellido
        {
            set
            {
                Apellido = value;
            }
            get
            {
                return Apellido;
            }
        }
        public String rut
        {
            set
            {
                Rut = value;
            }
            get
            {
                return Rut;
            }
        }
        public String email
        {
            set
            {
                Email = value;
            }
            get
            {
                return Email;
            }
        }
        public String direccion
        {
            set
            {
                Direccion = value;
            }
            get
            {
                return Direccion;
            }
        }
        public int telefono
        {
            set
            {
                Telefono = value;
            }
            get
            {
                return Telefono;
            }
        }
    }
    }
