using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class Componente
    {
        private string nombre;
        private int idComponente;
        private DateTime fechaVencimiento;
        private DateTime fechaFabricacion;
        private string matriculaAeronave;
        private float horasVuelo;
        private int idPadre;
        private float limiteHorasVuelo;
        private string estado;
        private Componente hijo;


        public Componente() { }
		
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

        public int IdComponente
        {
            get
            {
                return idComponente;
            }

            set
            {
                idComponente = value;
            }
        }

        public DateTime FechaVencimiento
        {
            get
            {
                return fechaVencimiento;
            }

            set
            {
                fechaVencimiento = value;
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

        public float HorasVuelo
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

        public int IdPadre
        {
            get
            {
                return idPadre;
            }

            set
            {
                idPadre = value;
            }
        }

        public float LimiteHorasVuelo
        {
            get
            {
                return limiteHorasVuelo;
            }

            set
            {
                limiteHorasVuelo = value;
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

        public Componente(string nombre, int idComponente, DateTime fechaVencimiento, string matriculaAeronave, float horasVuelo, int idPadre, float limiteHorasVuelo, string estado)
        {
            this.Nombre = nombre;
            this.IdComponente = idComponente;
            this.FechaVencimiento = fechaVencimiento;
            this.MatriculaAeronave = matriculaAeronave;
            this.HorasVuelo = horasVuelo;
            this.IdPadre = idPadre;
            this.LimiteHorasVuelo = limiteHorasVuelo;
            this.Estado = estado;
        }

        public Componente(int idComponente)
        {
            
            this.IdComponente = idComponente;
          
        }
    }
}
