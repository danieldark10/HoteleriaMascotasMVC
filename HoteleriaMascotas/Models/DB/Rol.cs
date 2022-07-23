using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Rol
    {
        public Rol()
        {
            Clientes = new HashSet<Cliente>();
            Trabajadors = new HashSet<Trabajador>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Idrol { get; set; }
        public string Nombrerol { get; set; } = null!;

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Trabajador> Trabajadors { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
