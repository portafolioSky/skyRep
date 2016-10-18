using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    class MantenimientoComponente
    {
        private int idMantenimiento;
        private int idComponente;
        private DateTime fechaInspeccion;
        private string rutEncargado;
        private string estado;

        public MantenimientoComponente() { }

        public int IdMantenimiento
        {
            get
            {
                return idMantenimiento;
            }

            set
            {
                idMantenimiento = value;
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

        public DateTime FechaInspeccion
        {
            get
            {
                return fechaInspeccion;
            }

            set
            {
                fechaInspeccion = value;
            }
        }

        public string RutEncargado
        {
            get
            {
                return rutEncargado;
            }

            set
            {
                rutEncargado = value;
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

        public MantenimientoComponente(int idMantenimiento, int idComponente, DateTime fechaInspeccion, string rutEncargado, string estado)
        {
            this.IdMantenimiento = idMantenimiento;
            this.IdComponente = idComponente;
            this.FechaInspeccion = fechaInspeccion;
            this.RutEncargado = rutEncargado;
            this.Estado = estado;
        }
    }
}
