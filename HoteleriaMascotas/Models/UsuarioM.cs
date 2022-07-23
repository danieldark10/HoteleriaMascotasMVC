using System;
namespace HoteleriaMascotas.Models
{
    class UsuarioM
    {

        private int IdUsuario;
        private String NombreUsuario;
        private String Contraseña;

        public String nombreusuario
        {
            set
            {
                NombreUsuario = value;
            }
            get
            {
                return NombreUsuario;
            }
        }

        public String contraseña
        {
            set
            {
                Contraseña = value;
            }
            get
            {
                return Contraseña;
            }
        }

    }
}
