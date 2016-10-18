using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.dataBase;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using MantenedoresCRUD.modelo;

namespace MantenedoresCRUD.dao
{
    class PilotoDao
    {
        private static Data conn;

        public PilotoDao()
        {
            conn = Data.getInstance();
        }


        //Login usuario
        public DataSet pilotoTipo(string tipo)
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PILOTO_TIPO", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("tipo_var", OracleDbType.Varchar2, "%"+tipo+"%", ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

            OracleDataAdapter adapter = new OracleDataAdapter(ora_cmd);
            DataSet data = new DataSet();
            adapter.Fill(data, "piloto_tipo", (OracleRefCursor)(ora_cmd.Parameters["p_recordset"].Value));
            conn.Close();
            return data;
        }


        public DataSet pilotoTipoAll()
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PILOTO_TIPO_ALL", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

            OracleDataAdapter adapter = new OracleDataAdapter(ora_cmd);
            DataSet data = new DataSet();
            adapter.Fill(data, "piloto_tipoAll", (OracleRefCursor)(ora_cmd.Parameters["p_recordset"].Value));
            conn.Close();
            return data;
        }

        public DataSet getPiloto(Usuario piloto)
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PILOTO_SELECT", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("rut_var", OracleDbType.Varchar2, piloto.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("nombre_var", OracleDbType.Varchar2, piloto.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("tipo_var", OracleDbType.Varchar2, piloto.Licencia.TipoLicencia.NombreLicencia, ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

            OracleDataAdapter adapter = new OracleDataAdapter(ora_cmd);
            DataSet data = new DataSet();
            adapter.Fill(data, "listaPiloto", (OracleRefCursor)(ora_cmd.Parameters["p_recordset"].Value));
            conn.Close();
            return data;
        }


        public DataSet listHabilitarPiloto(Usuario piloto)
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PILOTO_HABILITAR", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("rut_var", OracleDbType.Varchar2, piloto.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("nombre_var", OracleDbType.Varchar2, piloto.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

            OracleDataAdapter adapter = new OracleDataAdapter(ora_cmd);
            DataSet data = new DataSet();
            adapter.Fill(data, "habilitarPiloto", (OracleRefCursor)(ora_cmd.Parameters["p_recordset"].Value));
            conn.Close();
            return data;
        }


        public void habilitarPiloto(Usuario piloto)
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PILOTO_UPDATE", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("var_rut", OracleDbType.Varchar2, piloto.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("var_feMedicina", OracleDbType.Date, piloto.FechaMeAeroespacial, ParameterDirection.Input);
            ora_cmd.Parameters.Add("var_tipoLicencia", OracleDbType.Int16, piloto.Licencia.TipoLicencia.IdTipoLIcencia, ParameterDirection.Input);
            ora_cmd.Parameters.Add("var_estadoLicnecia", OracleDbType.Char, piloto.Licencia.Estado1, ParameterDirection.Input);
            ora_cmd.Parameters.Add("var_emisionLicencia", OracleDbType.Date, piloto.Licencia.FechaEmision, ParameterDirection.Input);
            ora_cmd.Parameters.Add("var_ExpiracionLicencia", OracleDbType.Date, piloto.Licencia.FechaExpiracion, ParameterDirection.Input);
            ora_cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
