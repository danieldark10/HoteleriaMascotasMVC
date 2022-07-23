using System;
namespace HoteleriaMascotas.Models
{
    class ClienteM
    {

        private int IdCliente;
        private int NumerodePagos;
       

        public int numerodePagos
        {
            set
            {
                NumerodePagos = value;
            }
            get
            {
                return NumerodePagos;
            }
        }
    }
    }
