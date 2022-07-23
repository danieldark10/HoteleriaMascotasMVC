using System;
using System.Collections.Generic;

namespace HoteleriaMascotas.Models.DB
{
    public partial class Status
    {
        public int Idstatus { get; set; }
        public int Idmascota { get; set; }
        public string Nombrestatus { get; set; } = null!;

        public virtual Mascotum IdmascotaNavigation { get; set; } = null!;
    }
}
