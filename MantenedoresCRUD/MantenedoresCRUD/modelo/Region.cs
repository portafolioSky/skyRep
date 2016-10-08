using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    class Region
    {
        private int idRegion;
        private string nombreRegion;
        private Pais pais;

        public Region(int idRegion, string nombreRegion, Pais pais)
        {
            this.idRegion = idRegion;
            this.nombreRegion = nombreRegion;
            this.pais = pais;
        }

        public int IdRegion
        {
            get
            {
                return idRegion;
            }

            set
            {
                idRegion = value;
            }
        }

        public string NombreRegion
        {
            get
            {
                return nombreRegion;
            }

            set
            {
                nombreRegion = value;
            }
        }

        internal Pais Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }
    }
}
