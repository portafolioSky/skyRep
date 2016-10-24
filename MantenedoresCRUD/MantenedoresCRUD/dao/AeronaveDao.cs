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
    class AeronaveDao
    {

        private static Data conn;

        public AeronaveDao()
        {
            conn = Data.getInstance();
        }
        public DataSet ListarAeronaves(Aeronave aeronave)
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "AERONAVE_SELECT", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("tipo_aeronave_var", OracleDbType.Varchar2, aeronave.TipoAeronave.NombreTipo, ParameterDirection.Input);
                oraCmd.Parameters.Add("matricula_var", OracleDbType.Varchar2, aeronave.Matricula, ParameterDirection.Input);
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaAeronaves", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public DataSet ListarTodasAeronaves(Aeronave aeronave)
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "AERONAVE_SELECT_ALL", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("tipo_aeronave_var", OracleDbType.Varchar2, aeronave.TipoAeronave.NombreTipo, ParameterDirection.Input);
                oraCmd.Parameters.Add("matricula_var", OracleDbType.Varchar2, aeronave.Matricula, ParameterDirection.Input);
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaAeronaves", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;   
        }

        public DataSet ListarTipoAeronave()
        {
            DataSet ds = new DataSet();
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "AERONAVE_TIPO_SELECT", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "listaTipoAeronave", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        public void IngresarAeronave(Aeronave nave)
        {
            //string respuesta = "nada";
            int id_tipo = nave.TipoAeronave.IdTipo;
            string matricula = nave.Matricula;
            string marca = nave.Marca;
            string modelo = nave.Modelo;
            DateTime fecha_fabricacion = nave.FechaFabricacion;
            Double horasVuelo = nave.HorasVuelo;
            DateTime fecha_certificado = nave.CertificadoDgac;
            DateTime fecha_vencimiento = nave.VencimientoDgac;

            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "AERONAVE_INGRESAR_SIN", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("var_tipo", OracleDbType.Int16, nave.TipoAeronave.IdTipo, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_matricula", OracleDbType.Varchar2, nave.Matricula, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_marca", OracleDbType.Varchar2, nave.Marca, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_modelo", OracleDbType.Varchar2, nave.Modelo, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_fecha_fabricacion", OracleDbType.Date, nave.FechaFabricacion, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_horas_vuelo", OracleDbType.Double, nave.HorasVuelo, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_fecha_certificado", OracleDbType.Date, nave.CertificadoDgac, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_fecha_vencimiento", OracleDbType.Date, nave.VencimientoDgac, ParameterDirection.Input);
                //oraCmd.Parameters.Add("var_out", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                oraCmd.ExecuteNonQuery();
                //respuesta = (string)(oraCmd.Parameters["var_out"].Value);
                conn.Close();
            }
        }

        public int aeronave_existe(Aeronave nave)
        {
            int res = 0;
            if (conn.Open())
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "AERONAVE_EXISTE", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("var_matricula", OracleDbType.Varchar2, nave.Matricula, ParameterDirection.Input);
                oraCmd.Parameters.Add("var_out", OracleDbType.Int16, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                res = int.Parse(oraCmd.Parameters["var_out"].Value.ToString());
                conn.Close();
            }
            return res;
        }
    }
}
