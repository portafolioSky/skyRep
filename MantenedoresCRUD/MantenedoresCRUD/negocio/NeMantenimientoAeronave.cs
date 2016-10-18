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
    class NeMantenimientoAeronave
    {
        public DataSet getMantenimientos(Aeronave nave)
        {
            string matricula;
            matricula = nave.Matricula.ToLower();
            if (matricula.Equals("")) nave.Matricula = "%";
            else nave.Matricula = matricula + "%";
            MantenimientoAeronaveDao mantenimiento = new MantenimientoAeronaveDao();
            return mantenimiento.ListarMantenimientos(nave);
        }

        public void delMantenimiento(MantenimientoAeronave mantNave)
        {
            MantenimientoAeronaveDao mantenimiento = new MantenimientoAeronaveDao();
            mantenimiento.EliminarMantenimientoAeronave(mantNave);
        }
    }
}
