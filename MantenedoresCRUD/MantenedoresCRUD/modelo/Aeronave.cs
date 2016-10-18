using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class Aeronave
    {
        private string matricula;
        private string marca;
        private string modelo;
        private DateTime fechaFabricacion;
        private Double horasVuelo;
        private DateTime certificadoDgac;
        private DateTime vencimientoDgac;
        private string estadoAeronave;
        private TipoAeronave tipoAeronave;
        private string kmh;

        public string Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public DateTime FechaFabricacion
        {
            get
            {
                return fechaFabricacion;
            }

            set
            {
                fechaFabricacion = value;
            }
        }

        public Double HorasVuelo
        {
            get
            {
                return horasVuelo;
            }

            set
            {
                horasVuelo = value;
            }
        }

        public DateTime CertificadoDgac
        {
            get
            {
                return certificadoDgac;
            }

            set
            {
                certificadoDgac = value;
            }
        }

        public DateTime VencimientoDgac
        {
            get
            {
                return vencimientoDgac;
            }

            set
            {
                vencimientoDgac = value;
            }
        }

        public string EstadoAeronave
        {
            get
            {
                return estadoAeronave;
            }

            set
            {
                estadoAeronave = value;
            }
        }

        public TipoAeronave TipoAeronave
        {
            get
            {
                if (tipoAeronave == null)
                {
                    tipoAeronave = new TipoAeronave();
                }
                return tipoAeronave;
            }

            set
            {
                tipoAeronave = value;
            }
        }

        public string Kmh
        {
            get
            {
                return kmh;
            }

            set
            {
                kmh = value;
            }
        }
    }
}
