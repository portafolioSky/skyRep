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
    }
}
