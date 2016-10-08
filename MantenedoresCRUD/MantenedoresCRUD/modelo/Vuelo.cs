using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    class Vuelo
    {
        private DateTime fechaSalida;
        private DateTime fechaArribo;
        private string horaSalida;
        private string horaArribo;
        private int idCondicionVuelo;
        private string matriculaAeronave;
        private string ciudadOrigen;
        private string ciudadDestino;
        private Tripulacion tripulacion;
        private string kilometros;

        public Vuelo() { }

        public DateTime FechaSalida
        {
            get
            {
                return fechaSalida;
            }

            set
            {
                fechaSalida = value;
            }
        }

        public DateTime FechaArribo
        {
            get
            {
                return fechaArribo;
            }

            set
            {
                fechaArribo = value;
            }
        }

        public string HoraSalida
        {
            get
            {
                return horaSalida;
            }

            set
            {
                horaSalida = value;
            }
        }

        public string HoraArribo
        {
            get
            {
                return horaArribo;
            }

            set
            {
                horaArribo = value;
            }
        }

        public int IdCondicionVuelo
        {
            get
            {
                return idCondicionVuelo;
            }

            set
            {
                idCondicionVuelo = value;
            }
        }

        public string MatriculaAeronave
        {
            get
            {
                return matriculaAeronave;
            }

            set
            {
                matriculaAeronave = value;
            }
        }

        public string CiudadOrigen
        {
            get
            {
                return ciudadOrigen;
            }

            set
            {
                ciudadOrigen = value;
            }
        }

        public string CiudadDestino
        {
            get
            {
                return ciudadDestino;
            }

            set
            {
                ciudadDestino = value;
            }
        }

        internal Tripulacion Tripulacion
        {
            get
            {
                return tripulacion;
            }

            set
            {
                tripulacion = value;
            }
        }

        public string Kilometros
        {
            get
            {
                return kilometros;
            }

            set
            {
                kilometros = value;
            }
        }

        public Vuelo(DateTime fechaSalida, DateTime fechaArribo, string horaSalida, string horaArribo, int idCondicionVuelo, string matriculaAeronave, string ciudadOrigen, string ciudadDestino, Tripulacion tripulacion)
        {
            this.fechaSalida = fechaSalida;
            this.fechaArribo = fechaArribo;
            this.horaSalida = horaSalida;
            this.horaArribo = horaArribo;
            this.idCondicionVuelo = idCondicionVuelo;
            this.matriculaAeronave = matriculaAeronave;
            this.ciudadOrigen = ciudadOrigen;
            this.ciudadDestino = ciudadDestino;
            this.tripulacion = tripulacion;
        }
    }
}
