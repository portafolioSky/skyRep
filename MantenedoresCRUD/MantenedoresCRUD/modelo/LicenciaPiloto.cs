using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class LicenciaPiloto
    {
        private DateTime fechaEmision;
        private DateTime fechaExpiracion;
        private char Estado;
        private TipoLicencia tipoLicencia;

        public DateTime FechaEmision
        {
            get
            {
                return fechaEmision;
            }

            set
            {
                fechaEmision = value;
            }
        }

        public DateTime FechaExpiracion
        {
            get
            {
                return fechaExpiracion;
            }

            set
            {
                fechaExpiracion = value;
            }
        }

     

        internal TipoLicencia TipoLicencia
        {
            get
            {
                if (tipoLicencia == null)
                {
                    tipoLicencia = new TipoLicencia();
                }
                return tipoLicencia;
            }

            set
            {
                tipoLicencia = value;
            }
        }

        public char Estado1
        {
            get
            {
                return Estado;
            }

            set
            {
                Estado = value;
            }
        }
    }
}
