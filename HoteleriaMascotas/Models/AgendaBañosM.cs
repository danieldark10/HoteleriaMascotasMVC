using System;
namespace HoteleriaMascotas.Models
{
    class AgendaBañosM
    {

        public int Idagendabanos;
        public DateTime Fechabano;
        public DateTime Horariobanoinicio;
        public DateTime Horariobanotermino;
        public decimal Precioporbano;


        public DateTime fechabano

        {
            set
            {
                Fechabano = value;
            }
            get
            {
                return Fechabano;
            }
        }
        public DateTime horariobanoinicio

        {
            set
            {
                Horariobanoinicio = value;
            }
            get
            {
                return Horariobanoinicio;
            }
        }
        public DateTime horariobanotermino

        {
            set
            {
                Horariobanotermino = value;
            }
            get
            {
                return Horariobanotermino;
            }
        }

        public decimal preciobano
        {
            set
            {
                Precioporbano = value;
            }
            get
            {
                return Precioporbano;
            }
        }
    }
    }
    
