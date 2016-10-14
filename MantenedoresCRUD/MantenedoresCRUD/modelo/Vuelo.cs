using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class Vuelo
    {
        private DateTime fechaSalida;
        private DateTime fechaArribo;
        private double totalTiempo;
        private int idCondicionVuelo;
        private string matriculaAeronave;
        private int ciudadOrigen;
        private int ciudadDestino;
        private string kilometros;
        private string estado;

        public Vuelo() { }

        public Vuelo(DateTime fechaSalida, DateTime fechaArribo, double totalTiempo, int idCondicionVuelo, string matriculaAeronave, int ciudadOrigen, int ciudadDestino, string kilometros, string estado)
        {
            this.fechaSalida = fechaSalida;
            this.fechaArribo = fechaArribo;
            this.totalTiempo = totalTiempo;
            this.idCondicionVuelo = idCondicionVuelo;
            this.matriculaAeronave = matriculaAeronave;
            this.ciudadOrigen = ciudadOrigen;
            this.ciudadDestino = ciudadDestino;
            this.kilometros = kilometros;
            this.estado = estado;
        }

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

        public int CiudadOrigen
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

        public int CiudadDestino
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

        public double TotalTiempo
        {
            get
            {
                return totalTiempo;
            }

            set
            {
                totalTiempo = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
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

        
    }
}
