using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.dao;
using System.Data;

namespace MantenedoresCRUD.negocio
{
    class NeAeronave
    {
        public DataSet getTipoAeronave()
        {
            AeronaveDao aeronave = new AeronaveDao();
            return aeronave.ListarTipoAeronave();
        }

        public DataSet getAeronave(Aeronave nave)
        {
            string matricula;
            string tipo;
            matricula = nave.Matricula.ToLower();
            tipo = nave.TipoAeronave.NombreTipo;
            if (matricula.Equals("")) nave.Matricula = "%";
            else nave.Matricula = matricula+"%";
            if (tipo.Equals("")) nave.TipoAeronave.NombreTipo = "%";
            else nave.TipoAeronave.NombreTipo = tipo+"%";
            AeronaveDao aeronave = new AeronaveDao();
            return aeronave.ListarTodasAeronaves(nave);
        }


    }
}
