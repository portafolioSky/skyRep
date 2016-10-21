using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.dao;
using System.Data;
using MantenedoresCRUD.vista;

namespace MantenedoresCRUD.negocio
{
    class NePerfil
    {
        public DataSet getPerfil()
        {
            PerfilDao perfil = new PerfilDao();
            return perfil.seleccionarRol();
        }
    }
}
