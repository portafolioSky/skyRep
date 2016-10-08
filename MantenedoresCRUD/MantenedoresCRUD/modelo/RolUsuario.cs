using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
   public class RolUsuario
    {
        private int id_rol;
        private string nombre;
        private string descripcion;

        public RolUsuario() { }

        public RolUsuario(int id_rol, string nombre, string descripcion)
        {
            this.id_rol = id_rol;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int Id_rol
        {
            get
            {
                return id_rol;
            }

            set
            {
                id_rol = value;
            }
        }

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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
    }
}
