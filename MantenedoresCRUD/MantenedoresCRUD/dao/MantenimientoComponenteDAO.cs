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


    }
}
