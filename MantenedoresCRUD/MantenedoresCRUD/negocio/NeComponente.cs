using MantenedoresCRUD.dao;
using MantenedoresCRUD.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.negocio
{
    class NeComponente
    {
        public DataSet getComponentes(Aeronave nave)
        {
            string matricula;
            matricula = nave.Matricula.ToLower();
            if (matricula.Equals("")) nave.Matricula = "%";
            else nave.Matricula = matricula + "%";
            ComponenteDAO componente = new ComponenteDAO();
            return componente.ListarComponentes(nave);
        }
    }
}
