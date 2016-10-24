using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.dataBase;
using MantenedoresCRUD.modelo;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;


namespace MantenedoresCRUD.dao
{
    class MantenimientoAeronaveDao
    {
        private static Data conn;
        public MantenimientoAeronaveDao()
        {
            conn = Data.getInstance();
        }

        public DataSet ListarMantenimientos(Aeronave aeronave)
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "MANTENCION_BY_MATRICULA", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("matricula_nave_var", OracleDbType.Varchar2, aeronave.Matricula, ParameterDirection.Input);
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaMantenimientos", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public void EliminarMantenimientoAeronave(MantenimientoAeronave mantNave)
        {
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "DELETE_MANT_NAVE", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("id_mant", OracleDbType.Int64, mantNave.IdMantenimiento, ParameterDirection.Input);
                oraCmd.ExecuteNonQuery();
                conn.Close();
            }    
        }

        public void IngresarMantenimientoAeronave(MantenimientoAeronave mantNave)
        {
            if (conn.Open())
            {
                OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "INSERT_MANT_NAVE", conn.Cnn);
                ora_cmd.BindByName = true;
                ora_cmd.CommandType = CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("mn_matricula", OracleDbType.Varchar2, mantNave.Matricula, ParameterDirection.Input);
                ora_cmd.Parameters.Add("mn_fecha", OracleDbType.Date, mantNave.Ispecccion, ParameterDirection.Input);
                ora_cmd.Parameters.Add("mn_estado", OracleDbType.Varchar2, mantNave.Estado, ParameterDirection.Input);
                ora_cmd.Parameters.Add("mn_encargado", OracleDbType.Varchar2, mantNave.RutUsuario, ParameterDirection.Input);
                ora_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ModificarMantenimientoAeronave(MantenimientoAeronave mantNave)
        {
            if (conn.Open())
            {
                OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "UPDATE_MANT_NAVE", conn.Cnn);
                ora_cmd.BindByName = true;
                ora_cmd.CommandType = CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("var_idMant", OracleDbType.Varchar2, mantNave.IdMantenimiento, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_matricula", OracleDbType.Varchar2, mantNave.Matricula, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_fechaInspeccion", OracleDbType.Date, mantNave.Ispecccion, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_estado", OracleDbType.Varchar2, mantNave.Estado, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_rutEncargado", OracleDbType.Varchar2, mantNave.RutUsuario, ParameterDirection.Input);
                ora_cmd.ExecuteNonQuery();
                conn.Close();
            }
            
        }

        public int ObtenerultimoMantenimiento()
        {
            int idLastMant =0;
            if (conn.Open())
            {
                OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "MANT_NAVE_ULTIMO_ID", conn.Cnn);
                ora_cmd.BindByName = true;
                ora_cmd.CommandType = CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("var_out", OracleDbType.Int16, idLastMant, ParameterDirection.Output);
                ora_cmd.ExecuteNonQuery();
                conn.Close();

            }
            return idLastMant;
        }
            
        
    }
}
