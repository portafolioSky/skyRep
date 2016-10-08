using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    class Tripulacion
    {
        private int cantidadHoras;
        private Usuario rutPiloto;
        private String puestoVuelo;

        public int CantidadHoras
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

        public Usuario RutPiloto
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

        public Tripulacion(int cantidadHoras, Usuario rutPiloto, string puestoVuelo)
        {
            this.cantidadHoras = cantidadHoras;
            this.rutPiloto = rutPiloto;
            this.puestoVuelo = puestoVuelo;
        }
    }
}
