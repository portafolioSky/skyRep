using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.dao;

namespace MantenedoresCRUD.negocio
{
    class NeUsuario
    {
       public int Login(Usuario  usuario)
        {
            if (usuario.Password == "" || usuario.Rut == "")
                return -3; //Retorna -3 en el caso de encontrar datos vacios
            MantenedorPersona daoUsuario = new MantenedorPersona();

            byte[] data = Encoding.ASCII.GetBytes(usuario.Password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = Encoding.ASCII.GetString(data);

            Console.Write("Clave: "+hash);
            return daoUsuario.Ingresar(usuario);
        }
    }
}
