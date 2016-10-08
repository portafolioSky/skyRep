using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class TipoAeronave
    {
        private int idTipo;
        private string nombreTipo;
        public int IdTipo
        {
            get
            {
                return idTipo;
            }

            set
            {
                idTipo = value;
            }
        }

        public string NombreTipo
        {
            get
            {
                return nombreTipo;
            }

            set
            {
                nombreTipo = value;
            }
        }

    }
}
