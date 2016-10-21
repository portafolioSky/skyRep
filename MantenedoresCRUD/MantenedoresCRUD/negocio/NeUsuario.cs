using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.dao;
using System.Data;

namespace MantenedoresCRUD.negocio
{
    class NeUsuario
    {
       public int Login(Usuario  usuario)
        {
            if (usuario.Password == "" || usuario.Rut == "")
                return -3; //Retorna -3 en el caso de encontrar datos vacios

            UsuarioDao daoUsuario = new UsuarioDao();
            byte[] data = Encoding.ASCII.GetBytes(usuario.Password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);
            usuario.Password = hash;
            return daoUsuario.Ingresar(usuario);
        }

        public DataSet getUsuario(Usuario usuario)
        {
            string rut = usuario.Rut;
            string Rol = usuario.RolUsuario.Nombre;

            if (rut.Equals("")) usuario.Rut = "%";
            else usuario.Rut = rut + "%";
            if (Rol.Equals("")) usuario.RolUsuario.Nombre = "%";
            else usuario.RolUsuario.Nombre = Rol + "%";

            UsuarioDao daoUsuario = new UsuarioDao();
            return daoUsuario.seleccionarPersonaAll(usuario);
        }


        public int cambioPass(Usuario usuario,string pass1, string pass2)
        {
            if(pass1 == "" || pass2 == "")
                return -1;

            if (pass1 != pass2)
                return -2;

            byte[] data = Encoding.ASCII.GetBytes(pass1);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);
            usuario.Password = hash;

            UsuarioDao daoUsuario = new UsuarioDao();
            return daoUsuario.cambioPassword(usuario);
        }

        public int desactivarUsuario(Usuario usuario)
        {
            if (usuario.RolUsuario.Nombre == "piloto")
                return -2;

            UsuarioDao daoUsuario = new UsuarioDao();
            return daoUsuario.desactivarByRut(usuario);
        }

        public int modificarUsuario(Usuario usuario)
        {
            if (usuario.Nombre == "" || usuario.ApMaterno == "" || usuario.ApPaterno == "" || usuario.Correo == "" || usuario.RolUsuario.Nombre == "" || usuario.User == "")
                return -2;

             UsuarioDao daoUsuario = new UsuarioDao();
            return daoUsuario.UpdatePersona(usuario);
        }
    }
}
