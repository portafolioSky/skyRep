using MantenedoresCRUD.dataBase;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using Oracle.ManagedDataAccess.Types;

namespace MantenedoresCRUD.dao
{
    class ComponenteDAO
    {
        private static Data conn;

        public ComponenteDAO()
        {
            conn = Data.getInstance();
        }
        public DataSet ListarComponentes(Aeronave nave)
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "COMPONENTE_BY_MATRICULA", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("matricula_nave_var", OracleDbType.Varchar2, nave.Matricula, ParameterDirection.Input);
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaComponentes", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public int UltimoID()
        {
            int id = 0;
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "COMPONENTE_ULTIMO_ID", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("var_out", OracleDbType.Int16, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                id = int.Parse(oraCmd.Parameters["var_out"].Value.ToString());
                conn.Close();
            }
            return id;
        }

        public int IngresarComponente(Componente componente)
        {
            int id = 0;
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "COMPONENTE_INGRESAR", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("var_id", OracleDbType.Int16,componente.IdComponente, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_nombre", OracleDbType.Varchar2,componente.Nombre, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_horas_vuelo", OracleDbType.Double,componente.HorasVuelo, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_limite_horas", OracleDbType.Double,componente.LimiteHorasVuelo, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_fecha_vencimiento", OracleDbType.Date, componente.FechaVencimiento,ParameterDirection.Input);
                oraCmd.Parameters.Add("var_matricula_aeronave", OracleDbType.Varchar2,componente.MatriculaAeronave, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_estado", OracleDbType.Varchar2,componente.Estado, ParameterDirection.Input);
                if (componente.IdPadre == 0)
                {
                    oraCmd.Parameters.Add("var_id_padre", OracleDbType.Int16, ParameterDirection.Input);
                }
                else
                {

                    oraCmd.Parameters.Add("var_id_padre", OracleDbType.Int16, componente.IdPadre, ParameterDirection.Input);
                }
                oraCmd.Parameters.Add("var_out", OracleDbType.Int16,ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                id = int.Parse(oraCmd.Parameters["var_out"].Value.ToString());
                conn.Close();
            }
            return id;
        }

    }
}
