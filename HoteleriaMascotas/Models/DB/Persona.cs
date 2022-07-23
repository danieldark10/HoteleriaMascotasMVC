using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Persona
    {
        public Persona()
        {
            Clientes = new HashSet<Cliente>();
            Trabajadors = new HashSet<Trabajador>();
        }

        public int Idpersona { get; set; }
        public string Sexo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Rut { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int Telefono { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Trabajador> Trabajadors { get; set; }
    }
}
