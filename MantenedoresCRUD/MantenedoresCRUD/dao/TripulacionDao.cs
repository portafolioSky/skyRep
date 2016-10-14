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
using System.Collections;

namespace MantenedoresCRUD.dao
{
    class TripulacionDao
    {
        private static Data conn;

        public TripulacionDao()
        {
            conn = Data.getInstance();
        }

        public void ingresarTripulacion(List<Tripulacion> tripualacion)
        {
            conn.Open();
            for (int i = 0; i < tripualacion.Count; i++)
            {
              

             OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "TRIPULACION_INGRESAR", conn.Cnn);
             ora_cmd.BindByName = true;
             ora_cmd.CommandType = CommandType.StoredProcedure;

             ora_cmd.Parameters.Add("var_cantHoras", OracleDbType.Double, tripualacion[i].CantidadHoras, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_rutPiloto", OracleDbType.Varchar2, tripualacion[i].RutPiloto, ParameterDirection.Input);
             ora_cmd.Parameters.Add("var_puesto", OracleDbType.Varchar2, tripualacion[i].PuestoVuelo, ParameterDirection.Input);

             ora_cmd.ExecuteNonQuery();
             

            }
            conn.Close();

        }
    }
}
