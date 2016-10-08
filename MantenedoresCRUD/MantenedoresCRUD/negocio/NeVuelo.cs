using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MantenedoresCRUD.dao;
using MantenedoresCRUD.modelo;

namespace MantenedoresCRUD.negocio
{
    public class NeVuelo
    {
        public DataSet ciudadOrigen()
        {
            VueloDao getCiudad = new VueloDao();
            return getCiudad.getCiudadOrigen();
        }


        public DataSet ciudadDestino(Ciudad ciudad)
        {
            VueloDao getCiudad = new VueloDao();
            return getCiudad.getCiudadDestino(ciudad);
        }

        public double getDintancia(Ciudad idOrigen, Ciudad idDestino)
        {
            VueloDao getcord = new VueloDao();
            getcord.getCoordenadas(idOrigen, idDestino);
            double radTierra = 6371;

            double lantO = double.Parse(idOrigen.Latitud) * (Math.PI / 180); //lant
            double lngO = double.Parse(idOrigen.Longitud) * (Math.PI / 180); //lng
            double lantD = double.Parse(idDestino.Latitud) * (Math.PI / 180);
            double lngD = double.Parse(idDestino.Longitud) * (Math.PI / 180);
            double i =
                (Math.Cos(lantO) * Math.Cos(lantD) * Math.Cos(lngO) * Math.Cos(lngD)
                + Math.Cos(lantO) * Math.Sin(lngO) * Math.Cos(lantD) * Math.Sin(lngD)
                + Math.Sin(lantO) * Math.Sin(lantD));
            double j = Math.Acos(i);
            double k = (radTierra * j);
            return Math.Round(k, 2); //Distancia en KM
        }


        public DateTime getHoraDespegue(string hora)
        {
            DateTime horavuelo = new DateTime();

            if (hora.Length == 1)
                hora = "0" + hora+ ":00";
            else if (hora.Length == 2)
                hora = hora + ":00";
            else if (hora.Length >= 3)
            {
                string[] horasMinutos = hora.Split(',');
                if (horasMinutos[0].Length == 1)
                    hora = "0" + hora.Replace(",5", ":30");
                else
                    hora = hora.Replace(",5", ":30");
            }

             horavuelo= DateTime.ParseExact(hora, "HH:mm",System.Globalization.CultureInfo.InvariantCulture);

            return horavuelo;
        }


        public int validarFechaHora(DateTime fechaSeleccion, DateTime horaSeleccion)
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechalimite = fechaActual.AddDays(30);
            DateTime horaActual = DateTime.Now;
            DateTime horalimite = horaActual.AddHours(4);
            int resp = new int();

            int result1 = DateTime.Compare(fechaSeleccion, fechaActual);
            int result2 = DateTime.Compare(fechaSeleccion, fechalimite);
            if (result1 >= 0 & result2 < 0)
            {
                if (result1 == 0)
                {
                    int result3 = DateTime.Compare(horaSeleccion, horalimite);
                    if (result3 < 0) return resp = -2;
                }
                return resp=0;
            }
            else
                return resp=-1;

        }

    }
}
