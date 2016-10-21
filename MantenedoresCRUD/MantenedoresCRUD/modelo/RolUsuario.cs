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

        public RolUsuario() { }

        public RolUsuario(int id_rol, string nombre)
        {
            this.id_rol = id_rol;
            this.nombre = nombre;
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


    }
}
