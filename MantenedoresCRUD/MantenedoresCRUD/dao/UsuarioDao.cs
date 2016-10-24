using MantenedoresCRUD.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.dataBase;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace MantenedoresCRUD.dao
{
    class UsuarioDao
    {


        private static Data conn;

        public UsuarioDao()
        {
            conn = Data.getInstance();
        }

        public DataSet obtenerOperadores()
        {
            DataSet ds = new DataSet();
            if (conn.Open() == true)
            {
                OracleCommand oraCmd = new OracleCommand(conn.getUsuario() + "GET_OPERADORES", conn.Cnn);
                oraCmd.BindByName = true;
                oraCmd.CommandType = CommandType.StoredProcedure;
                oraCmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
                oraCmd.ExecuteNonQuery();
                OracleDataAdapter ad = new OracleDataAdapter(oraCmd);
                ad.Fill(ds, "operadores", (OracleRefCursor)(oraCmd.Parameters["p_recordset"].Value));
                conn.Close();
            }
            return ds;
        }

        //Login usuario
        public int Ingresar(Usuario persona)
        {
          conn.Open();
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "USUARIO_LOGIN", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("P_user", OracleDbType.Varchar2, persona.User, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_pass", OracleDbType.Varchar2, persona.Password, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());
            
            if (resp != -1 & resp != -2)
            {
                OracleDataReader odr = ((OracleRefCursor)ora_cmd.Parameters["p_recordset"].Value).GetDataReader();
                while (odr.Read())
                {
                    persona.Nombre = odr.GetString(0);
                    persona.ApPaterno = odr.GetString(1);
                    persona.ApMaterno = odr.GetString(2);
                    persona.User = odr.GetString(3);
                    persona.Correo = odr.GetString(4);
                    persona.RolUsuario.Nombre = odr.GetString(5);
                }
                conn.Close();
                return resp;
            }
            conn.Close();
            return resp;
        }

       
        //Insertar persona
        public  int sqlInsertarPersona(Usuario persona)
        {
            conn.Open();
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "USUARIO_INGRESAR", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("P_rut", OracleDbType.Varchar2, persona.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_nombre", OracleDbType.Varchar2, persona.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_ap_paterno", OracleDbType.Varchar2, persona.ApPaterno, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_ap_materno", OracleDbType.Varchar2, persona.ApMaterno, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_user", OracleDbType.Varchar2, persona.User, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_pass", OracleDbType.Varchar2, persona.Password, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_correo", OracleDbType.Varchar2, persona.Correo, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_rol", OracleDbType.Int16, persona.RolUsuario.Id_rol, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            conn.Close();
            return resp;
        }

        //Seleccionar persona por rut
        public static int seleccionarPersonaByRut(Usuario persona)
        {
           
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PRO_SELECT_PERSONA", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;


            ora_cmd.Parameters.Add("rut", OracleDbType.Varchar2, persona.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            if (resp == 0)
            {
                OracleDataReader odr = ((OracleRefCursor)ora_cmd.Parameters["p_recordset"].Value).GetDataReader();
                while (odr.Read())
                {
                    persona.Nombre = odr.GetString(0);
                    persona.ApPaterno = odr.GetString(1);
                    persona.ApMaterno = odr.GetString(2);
                    persona.User = odr.GetString(3);
                    persona.Correo = odr.GetString(4);
                    persona.RolUsuario.Nombre = odr.GetString(5);
                }
            }
            return resp;

        }


        //Seleccionar persona por rol (perfil)
        public static int seleccionarPersonaByRol(Usuario persona)
        {

            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "PRO_SELECT_PERSONA", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;


            ora_cmd.Parameters.Add("rol", OracleDbType.Varchar2, persona.RolUsuario.Id_rol, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            if (resp == 0)
            {
                OracleDataReader odr = ((OracleRefCursor)ora_cmd.Parameters["p_recordset"].Value).GetDataReader();
                while (odr.Read())
                {
                    persona.Nombre = odr.GetString(0);
                    persona.ApPaterno = odr.GetString(1);
                    persona.ApMaterno = odr.GetString(2);
                    persona.User = odr.GetString(3);
                    persona.Correo = odr.GetString(4);
                    persona.RolUsuario.Nombre = odr.GetString(5);
                }
            }
            return resp;

        }


        public DataSet seleccionarPersonaAll(Usuario persona)
        {
            conn.Open();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "USUARIO_SELECT_ALL", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;


            ora_cmd.Parameters.Add("rut_var", OracleDbType.Varchar2, persona.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("rol_var", OracleDbType.Varchar2, persona.RolUsuario.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_recordset", OracleDbType.RefCursor, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            OracleDataAdapter adapter = new OracleDataAdapter(ora_cmd);
            DataSet data = new DataSet();
            adapter.Fill(data, "usuarioLista", (OracleRefCursor)(ora_cmd.Parameters["p_recordset"].Value));
            conn.Close();
            return data;

        }

        public int cambioPassword(Usuario persona)
        {
            conn.Open();
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "USUARIO_CAMBIOPASS", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;


            ora_cmd.Parameters.Add("P_rut", OracleDbType.Varchar2, persona.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_pass", OracleDbType.Varchar2, persona.Password, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);
            ora_cmd.ExecuteNonQuery();

            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());
            conn.Close();
            return resp;

        }


        //Actualizar persona
        public int UpdatePersona(Usuario persona)
        {
            conn.Open();
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "USUARIO_UPDATE", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("P_rut", OracleDbType.Varchar2, persona.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_nombre", OracleDbType.Varchar2, persona.Nombre, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_ap_paterno", OracleDbType.Varchar2, persona.ApPaterno, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_ap_materno", OracleDbType.Varchar2, persona.ApMaterno, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_user", OracleDbType.Varchar2, persona.User, ParameterDirection.Input);
            ora_cmd.Parameters.Add("rolid", OracleDbType.Int16, persona.RolUsuario.Id_rol, ParameterDirection.Input);
            ora_cmd.Parameters.Add("P_correo", OracleDbType.Varchar2, persona.Correo, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            conn.Close();
            return resp;

        }

        //Desactivar persona por rut
        public int desactivarByRut(Usuario persona)
        {
            conn.Open();
            int resp = new int();
            OracleCommand ora_cmd = new OracleCommand(conn.getUsuario() + "USUARIO_DESACTIVAR", conn.Cnn);
            ora_cmd.BindByName = true;
            ora_cmd.CommandType = CommandType.StoredProcedure;

            ora_cmd.Parameters.Add("p_rut", OracleDbType.Varchar2, persona.Rut, ParameterDirection.Input);
            ora_cmd.Parameters.Add("resp", OracleDbType.Int16, ParameterDirection.Output);

            ora_cmd.ExecuteNonQuery();
            resp = int.Parse(ora_cmd.Parameters["resp"].Value.ToString());

            conn.Close();
            return resp;
        }

        
    }
}
