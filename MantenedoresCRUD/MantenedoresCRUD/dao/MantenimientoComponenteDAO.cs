using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using System.Data;
using MantenedoresCRUD.dataBase;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace MantenedoresCRUD.dao
{
    class MantenimientoComponenteDAO
    {
        private static Data conn;

        public MantenimientoComponenteDAO()
        {
            conn = Data.getInstance();
        }

        public DataSet ListarMantenimientosComponentes(Componente componente)
        {
            DataSet ds = new DataSet();
            if (conn.Open() == true)
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "MANTENCION_BY_IDCOMPONENTE", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("id_comp_var", OracleDbType.Int64, componente.IdComponente, ParameterDirection.Input);
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaMantenimientos", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public void EliminarMantenimientoComponente(MantenimientoComponente mantComp)
        {
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "DELETE_MANT_COMP", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("id_mant", OracleDbType.Int64, mantComp.IdMantenimiento, ParameterDirection.Input);
                oraCmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void IngresarMantenimientoComponente(MantenimientoComponente mantComp)
        {
            if (conn.Open())
            {
                OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "INSERT_MANT_COMP", conn.Cnn);
                ora_cmd.BindByName = true;
                ora_cmd.CommandType = CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("mc_idComp", OracleDbType.Varchar2, mantComp.IdComponente, ParameterDirection.Input);
                ora_cmd.Parameters.Add("mc_fecha", OracleDbType.Date, mantComp.FechaInspeccion, ParameterDirection.Input);
                ora_cmd.Parameters.Add("mc_estado", OracleDbType.Varchar2, mantComp.Estado, ParameterDirection.Input);
                ora_cmd.Parameters.Add("mc_encargado", OracleDbType.Varchar2, mantComp.RutEncargado, ParameterDirection.Input);
                ora_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void ModificarMantenimientoComponente(MantenimientoComponente mantComp)
        {
            if (conn.Open())
            {
                OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "UPDATE_MANT_COMP", conn.Cnn);
                ora_cmd.BindByName = true;
                ora_cmd.CommandType = CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("var_idMantComp", OracleDbType.Int16, mantComp.IdMantenimiento, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_idComp", OracleDbType.Int16, mantComp.IdComponente, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_fechaInspeccion", OracleDbType.Date, mantComp.FechaInspeccion, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_estado", OracleDbType.Varchar2, mantComp.Estado, ParameterDirection.Input);
                ora_cmd.Parameters.Add("var_rutEncargado", OracleDbType.Varchar2, mantComp.RutEncargado, ParameterDirection.Input);
                ora_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
