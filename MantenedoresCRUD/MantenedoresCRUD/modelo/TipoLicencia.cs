using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class TipoLicencia
    {
        private int idTipoLIcencia;
        private string nombreLicencia;

        public int IdTipoLIcencia
        {
            get
            {
                return idTipoLIcencia;
            }

            set
            {
                idTipoLIcencia = value;
            }
        }

        public string NombreLicencia
        {
            get
            {
                return nombreLicencia;
            }

            set
            {
                nombreLicencia = value;
            }
        }
    }
}
