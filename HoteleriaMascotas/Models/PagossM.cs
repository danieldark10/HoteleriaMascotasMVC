using System;
namespace HoteleriaMascotas.Models
{
    class PagossM
    {

        private int IdPago;
        private DateTime FechaPago;
        private Decimal MontoPago;
        private Boolean Estado;
        private String NumeroComprobante;
        private DateTime FechaEmision;


        public DateTime fechapago

        {
            set
            {
                FechaPago = value;
            }
            get
            {
                return FechaPago;
            }
        }

        public Decimal montopago
        {
            set
            {
                MontoPago = value;
            }
            get
            {
                return MontoPago;
            }
        }

        public Boolean estado
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
        public String numerocomprobante
        {
            set
            {
                NumeroComprobante = value;
            }
            get
            {
                return NumeroComprobante;
            }
        }
        public DateTime fechaemision
        {
            set
            {
                FechaEmision = value;
            }
            get
            {
                return FechaEmision;
            }
        }

    }
}
