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
    class NeMantenimientoComponente
    {
        public DataSet getMantenimientosComp(Componente componente)
        {
            int idComp;
            idComp = componente.IdComponente;
            MantenimientoComponenteDAO mantenimientoComp = new MantenimientoComponenteDAO();
            return mantenimientoComp.ListarMantenimientosComponentes(componente);
        }

        public void delMantenimientoComp(MantenimientoComponente mantComp)
        {
            MantenimientoComponenteDAO mantenimiento = new MantenimientoComponenteDAO();
            mantenimiento.EliminarMantenimientoComponente(mantComp);
        }
    }
}
