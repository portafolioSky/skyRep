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


        public DataSet getHabilitarPiloto()
        {

            PilotoDao listpiloto = new PilotoDao();
            return listpiloto.listHabilitarPiloto();
        }


        public void updatePiloto(Usuario piloto)
        {

            PilotoDao updateP = new PilotoDao();
            updateP.habilitarPiloto(piloto);
        }
    }
}
