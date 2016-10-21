using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenedoresCRUD.modelo
{
    public class Usuario
    {
        private string rut;
        private string nombre;
        private string apPaterno;
        private string apMaterno;
        private string user;
        private string password;
        private string correo;
        private RolUsuario rolUsuario;
        private DateTime fechaMeAeroespacial;
        private LicenciaPiloto licencia;



        public Usuario() { }
        public Usuario(string rut,string nombre, string apPaterno, string apMaterno, string user, string correo, RolUsuario rolUsuario) {
            this.rut = rut;
            this.nombre = nombre;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.user = user;
            this.correo = correo;
            this.rolUsuario = rolUsuario;
        }

        public Usuario(string rut, string nombre, string apPaterno, string apMaterno, string user, string correo, string rolUsuario)
        {

            this.rut = rut;
            this.nombre = nombre;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.user = user;
            this.correo = correo;
            this.rolUsuario = new RolUsuario();
            this.rolUsuario.Nombre = rolUsuario;
        }

        public Usuario(string rut)
        {
            this.rut = rut;
        }

        public string Rut
        {
            get
            {return rut;}

            set
            {rut = value;}
        }


        public string Nombre
        {
            get
            {return nombre;}

            set
            {nombre = value;}
        }

        public string ApPaterno
        {
            get
            {return apPaterno;}

            set
            {apPaterno = value;}
        }

        public string ApMaterno
        {
            get
            {return apMaterno;}

            set
            {apMaterno = value;}
        }

        public string User
        {
            get
            {return user;}

            set
            {user = value;}
        }

        public string Password
        {
            get
            {return password;}

            set
            {password = value;
            }
        }

        public string Correo
        {
            get
            {return correo;}

            set
            {correo = value;}
        }

        public RolUsuario RolUsuario
        {
            get
            {
                if (rolUsuario == null)
                {
                    rolUsuario = new RolUsuario();
                }
                return rolUsuario;

            }

            set
            {rolUsuario = value;}
        }

        public DateTime FechaMeAeroespacial
        {
            get
            {
                return fechaMeAeroespacial;
            }

            set
            {
                fechaMeAeroespacial = value;
            }
        }

        public LicenciaPiloto Licencia
        {
            get
            {
                if (licencia == null)
                {
                    licencia = new LicenciaPiloto();
                }
                return licencia;
            }

            set
            {
                licencia = value;
            }
        }

        public override string ToString()
        {
            return Rut + " " + Nombre + " " + ApPaterno + " "+ ApMaterno +" " + Correo + " "+ User + " " + RolUsuario.Nombre;
        }

        public string NombreCompleto()
        {
            return Nombre + " " + ApPaterno + " " + ApMaterno;
        }
    }

}
