using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class Tripulacion
    {
        private double cantidadHoras;
        private string rutPiloto;
        private string tipoLicencia;
        private string nombre;
        private String puestoVuelo;

        public double CantidadHoras
        {
            get
            {
                return cantidadHoras;
            }

            set
            {
                cantidadHoras = value;
            }
        }

        public string RutPiloto
        {
            get
            {
                return rutPiloto;
            }

            set
            {
                rutPiloto = value;
            }
        }

        public string PuestoVuelo
        {
            get
            {
                return puestoVuelo;
            }

            set
            {
                puestoVuelo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string TipoLicencia
        {
            get
            {
                return tipoLicencia;
            }

            set
            {
                tipoLicencia = value;
            }
        }
		
	
    }
}
