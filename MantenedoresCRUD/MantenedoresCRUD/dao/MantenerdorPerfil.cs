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
    class MantenerdorPerfil
    {

        private static Data conn;

        public static int sqlIngresarRol(RolUsuario rol)
        {
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PRO_INGRESAR_ROL", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("nombre_rol", OracleDbType.Varchar2, rol.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("descripcion", OracleDbType.Varchar2, rol.Descripcion, ParameterDirection.Input); 
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            return resp;
        }


        public static int seleccionarRol(RolUsuario rol)
        {

            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PRO_SELECT_ROL", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;


            ora_cmd.Parameters.Add("id_rol", OracleDbType.Varchar2, rol.Id_rol, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            if (resp == 0)
            {
                OracleDataReader odr = ((OracleRefCursor)ora_cmd.Parameters["p_recordset"].Value).GetDataReader();
                while (odr.Read())
                {
                    rol.Id_rol = int.Parse(odr.GetString(0));
                    rol.Nombre = odr.GetString(1);
                    rol.Descripcion = odr.GetString(2);
                }
            }
            return resp;
        }


        public static int UpdateRol(RolUsuario rol)
        {

            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PRO_UPDATE_ROL", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("id_rol", OracleDbType.Varchar2, rol.Id_rol, ParameterDirection.Input);
            ora_cmd.Parameters.Add("nombre_rol", OracleDbType.Varchar2, rol.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("descripcion", OracleDbType.Varchar2, rol.Descripcion, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());


            return resp;

        }

        public static int deleteROL(RolUsuario rol)
        {
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PRO_DELETE_ROL", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("id_rol", OracleDbType.Varchar2, rol.Id_rol, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());


            return resp;
        }



    }
}
