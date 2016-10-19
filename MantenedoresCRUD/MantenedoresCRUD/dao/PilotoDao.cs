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
		
		        public DataSet listarTodosPilotos(string tipo, string rut, string nombre)
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "PILOTO_SELECT_ALL", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("rut_var", OracleDbType.Varchar2, rut, ParameterDirection.Input);
                oraCmd.Parameters.Add("tipo_var", OracleDbType.Varchar2, tipo, ParameterDirection.Input);
                oraCmd.Parameters.Add("nombre_var", OracleDbType.Varchar2, nombre, ParameterDirection.Input);
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaPilotos", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public DataSet listarTipoPiloto()
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "PILOTO_TIPO_SELECT", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaTipoPiloto", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public int piloto_Insert(Usuario persona)
        {
            conn.Open();
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PILOTO_INGRESAR", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("P_rut", OracleDbType.Varchar2, persona.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_nombre", OracleDbType.Varchar2, persona.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_ap_paterno", OracleDbType.Varchar2, persona.ApPaterno, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_ap_materno", OracleDbType.Varchar2, persona.ApMaterno, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_user", OracleDbType.Varchar2, persona.User, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_pass", OracleDbType.Varchar2, persona.Password, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_correo", OracleDbType.Varchar2, persona.Correo, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_vencMedicina", OracleDbType.Date, persona.FechaMeAeroespacial, ParameterDirection.Input);
            ora_cmd.Parameters.Add("l_tipoLicencia", OracleDbType.Int16, persona.Licencia.TipoLicencia.IdTipoLIcencia, ParameterDirection.Input);
            ora_cmd.Parameters.Add("l_emisLicencia", OracleDbType.Date, persona.Licencia.FechaEmision, ParameterDirection.Input);
            ora_cmd.Parameters.Add("l_vencLicencia", OracleDbType.Date, persona.Licencia.FechaExpiracion, ParameterDirection.Input);
            ora_cmd.Parameters.Add("l_estadoLicencia", OracleDbType.Char, persona.Licencia.Estado1, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            conn.Close();
            return resp;
        }
    }
}
