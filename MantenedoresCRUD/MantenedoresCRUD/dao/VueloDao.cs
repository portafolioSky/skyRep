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
    public class VueloDao
    {
        private static Data conn;

        public VueloDao()
        {
            conn = Data.getInstance();
        }


        //Login usuario
        public DataSet getCiudadOrigen()
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "CIUDAD_SELECT_ALL", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

                    OracleDataAdapter adapter = new OracleDataAdapter(ora_cmd);
                    DataSet data = new DataSet();
                    adapter.Fill(data, "nombre_ciudad", (OracleRefCursor)(ora_cmd.Parameters["p_recordset"].Value));
                conn.Close();
                return data;
        }


        public DataSet getCiudadDestino(Ciudad ciudad)
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "CIUDAD_SELECT_DESTINO", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("id", OracleDbType.Int16, ciudad.IdCiudad, ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

            OracleDataAdapter adapter = new OracleDataAdapter(ora_cmd);
            DataSet data = new DataSet();
            adapter.Fill(data, "nombre_ciudad", (OracleRefCursor)(ora_cmd.Parameters["p_recordset"].Value));
            conn.Close();
            return data;
        }

        public void getCoordenadas(Ciudad idOrigen, Ciudad idDestino)
        {
            conn.Open();
            int cont1 = 0;
            int cont2 = 1;
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "GET_COORDENADAS", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;
            
            ora_cmd.Parameters.Add("origen_id", OracleDbType.Varchar2, idOrigen.IdCiudad, ParameterDirection.Input);
            ora_cmd.Parameters.Add("destino_id", OracleDbType.Varchar2, idDestino.IdCiudad, ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

                OracleDataReader odr = ((OracleRefCursor)ora_cmd.Parameters["p_recordset"].Value).GetDataReader();
                while (odr.Read())
                {
                if (cont1 == 0)
                {
                    idOrigen.Latitud = odr.GetString(0);
                    idOrigen.Longitud = odr.GetString(1);
                }
                if (cont2 == 0)
                {
                    idDestino.Latitud = odr.GetString(0);
                    idDestino.Longitud = odr.GetString(1);
                }
                cont1 = 1;
                cont2 = 0;

            }
                conn.Close();

        }

        public void ingresarVuelo (Vuelo vuelo)
        {
            conn.Open();
  
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "VUELO_INGRESAR", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

             ora_cmd.Parameters.Add("var_fechaSalida", OracleDbType.Date, vuelo.FechaSalida, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_fechaArribo", OracleDbType.Date, vuelo.FechaArribo, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_tiempoTotal", OracleDbType.Double, vuelo.TotalTiempo, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_idCondicion", OracleDbType.Int16, vuelo.IdCondicionVuelo, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_matriculaAeronave", OracleDbType.Varchar2, vuelo.MatriculaAeronave, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_idOrigen", OracleDbType.Int16, vuelo.CiudadOrigen, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_idDestino", OracleDbType.Int16, vuelo.CiudadDestino, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_estado", OracleDbType.Varchar2, vuelo.Estado, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_kilometros", OracleDbType.Varchar2, vuelo.Kilometros, ParameterDirection.Input);
             ora_cmd.ExecuteNonQuery();
             conn.Close();

        }

    }
}
