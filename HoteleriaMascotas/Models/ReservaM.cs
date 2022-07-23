using System;
namespace HoteleriaMascotas.Models
{
    class ReservaM
    {

        private int IdReserva;
        private DateTime FechaEntrada;
        private DateTime FechaSalida;
        private DateTime HoraEntrada;
        private DateTime HoraSalida;
        private DateTime FechaReserva;
        private String  Estado;
        private decimal Precio;

        public DateTime fechaentrada
        {
            set
            {
               FechaEntrada = value;
            }
            get
            {
                return FechaEntrada;
            }
        }

        public DateTime fechasalida
        {
            set
            {
                FechaSalida = value;
            }
            get
            {
                return FechaSalida;
            }
        }
        public DateTime horaentrada
        {
            set
            {
                HoraEntrada = value;
            }
            get
            {
                return HoraEntrada;
            }
        }
        public DateTime fechaReserva
        {
            set
            {
                FechaReserva = value;
            }
            get
            {
                return FechaReserva;
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

        public Decimal precio
        {
            set
            {
                Precio = value;
            }
            get
            {
                return Precio;
            }
        }
    }
    }
