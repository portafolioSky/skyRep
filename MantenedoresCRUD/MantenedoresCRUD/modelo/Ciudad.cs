using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class Ciudad
    {
        private int idCiudad;
        private string nombreCiudad;
        private Region region;
        private string latitud;
        private string longitud;

        public Ciudad() { }
        public int IdCiudad
        {
            get
            {
                return idCiudad;
            }

            set
            {
                idCiudad = value;
            }
        }

        public string NombreCiudad
        {
            get
            {
                return nombreCiudad;
            }

            set
            {
                nombreCiudad = value;
            }
        }

        internal Region Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        public string Latitud
        {
            get
            {
                return latitud;
            }

            set
            {
                latitud = value;
            }
        }

        public string Longitud
        {
            get
            {
                return longitud;
            }

            set
            {
                longitud = value;
            }
        }
    }
}
