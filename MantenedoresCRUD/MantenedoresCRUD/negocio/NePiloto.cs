using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.dao;
using System.Data;
using MantenedoresCRUD.vista;
using System.Globalization;

namespace MantenedoresCRUD.negocio
{
    class NePiloto
    {
        public DataSet getTipoPiloto()
        {
            Aeronave aeronave = new Aeronave();
            aeronave = Sesion.GetValue<Aeronave>("aeronave");
            string tipo= aeronave.TipoAeronave.NombreTipo;
            PilotoDao piloto = new PilotoDao();
            return piloto.pilotoTipo(tipo);
        }

        public DataSet getTipoPilotoAll()
        {

            PilotoDao piloto = new PilotoDao();
            return piloto.pilotoTipoAll();
        }

        public DataSet listarPiloto(Usuario piloto)
        {
            string rut = piloto.Rut;
            string UpperNombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(piloto.Nombre); 
            string tipo_piloto = piloto.Licencia.TipoLicencia.NombreLicencia;
            Aeronave aeronave = new Aeronave();
            aeronave = Sesion.GetValue<Aeronave>("aeronave");
            string tipo = aeronave.TipoAeronave.NombreTipo;

            if (rut.Equals("")) piloto.Rut = "%";
            else piloto.Rut = rut + "%";
            if (UpperNombre.Equals("")) piloto.Nombre = "%";
            else piloto.Nombre = UpperNombre + "%";
            if (tipo_piloto.Equals("")) piloto.Licencia.TipoLicencia.NombreLicencia = "%" + tipo + "%";

            PilotoDao listpiloto = new PilotoDao();
            return listpiloto.getPiloto(piloto);
        }


        public DataSet getHabilitarPiloto(Usuario piloto)
        {
            string rut = piloto.Rut;
            string UpperNombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(piloto.Nombre);

            if (rut.Equals("")) piloto.Rut = "%";
            else piloto.Rut = rut + "%";
            if (UpperNombre.Equals("")) piloto.Nombre = "%";
            else piloto.Nombre = UpperNombre + "%";

            PilotoDao listpiloto = new PilotoDao();
            return listpiloto.listHabilitarPiloto(piloto);
        }


        public void updatePiloto(Usuario piloto)
        {

            PilotoDao updateP = new PilotoDao();
            updateP.habilitarPiloto(piloto);
        }
		
		 public DataSet listarTodosPilotos(string tipo, string rut)
        {

            if (rut.Equals("")) rut = "%";
            else rut = rut + "%";

            string nombre = "%";

            if (tipo.Equals("")) tipo = "%";
            else tipo = tipo + "%";


            PilotoDao pilotoDao = new PilotoDao();
            return pilotoDao.listarTodosPilotos(tipo, rut, nombre);
        }

        public DataSet listarTipoPiloto()
        {
            PilotoDao piltoDao = new PilotoDao();
            return piltoDao.listarTipoPiloto();
        }
    }
}
