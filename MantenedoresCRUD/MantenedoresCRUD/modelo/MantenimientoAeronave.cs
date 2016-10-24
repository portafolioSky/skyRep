using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    class MantenimientoAeronave
    {
        private int idMantenimiento;
        private DateTime ispecccion;
        private string estado;
        private string rutUsuario;
        private string matricula;

        public MantenimientoAeronave() { }
        public MantenimientoAeronave(int idMantenimiento, DateTime ispecccion, string estado, string rutUsuario, string matricula)
        {
            this.IdMantenimiento = idMantenimiento;
            this.Ispecccion = ispecccion;
            this.Estado = estado;
            this.RutUsuario = rutUsuario;
            this.Matricula = matricula;
        }

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

        public DateTime Ispecccion
        {
            get
            {
                return ispecccion;
            }

            set
            {
                ispecccion = value;
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

        public string RutUsuario
        {
            get
            {
                return rutUsuario;
            }

            set
            {
                rutUsuario = value;
            }
        }

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

       
    }
}
