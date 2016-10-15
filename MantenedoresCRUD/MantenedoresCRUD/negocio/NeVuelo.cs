using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MantenedoresCRUD.dao;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.vista;

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

        public string[] recomendarDespegue()
        {
            DateTime fechaActual = DateTime.Today;
            double horaADouble = Convert.ToSingle(DateTime.Now.ToString("HH,mm"));
            decimal t = Convert.ToDecimal(horaADouble);
            var ts = TimeSpan.FromHours((double)t);
            var hora = ts.Hours+2;
            var min = ts.Minutes;
            string horaRecomendada;
            string[] fechayHora;

            if (ts.Minutes > 0) min = 5;

            if (hora >= 24)
            {
                double dias = hora / 24;
                decimal d = Convert.ToDecimal(dias);
                var tsDias = TimeSpan.FromDays((double)d); // calcular cuanto dias pasaron
                fechaActual = fechaActual.AddDays(tsDias.Days);
                hora = hora - 24;
                if (min > 0)
                horaRecomendada = string.Format("{0},{1}",hora,min);
                else
                horaRecomendada = string.Format("{0}", hora);

                 fechayHora= new string[]  { horaRecomendada,fechaActual.ToString()};
                return fechayHora;
            }
            else
            {
                if (min > 0)
                    horaRecomendada = string.Format("{0},{1}", hora, min);
                else
                    horaRecomendada = string.Format("{0}", hora);

                fechayHora = new string[] { horaRecomendada, fechaActual.ToString() };
                return fechayHora;
            }
        }

        public string getHoraDespegue(string hora)
        {
            decimal t = Convert.ToDecimal(hora);
            var ts = TimeSpan.FromHours((double)t);
            if (ts.Hours.Equals(0) && ts.Minutes.Equals(0)) return string.Format("0{0}:0{1}", ts.Hours, ts.Minutes);
            else if (ts.Hours.ToString().Length == 1 && ts.Minutes.ToString().Length == 1) return string.Format("0{0}:0{1}", ts.Hours, ts.Minutes);
            else if (ts.Hours.ToString().Length == 1) return string.Format("0{0}:{1}", ts.Hours, ts.Minutes);
            else if (ts.Minutes.ToString().Length == 1) return string.Format("{0}:0{1}", ts.Hours, ts.Minutes);
            else return string.Format("{0}:{1}", ts.Hours, ts.Minutes);
        }


        public int validarFechaHora(DateTime fechaSeleccion, string horaSeleccion)
        {
            DateTime hselect = new DateTime();
            hselect = DateTime.ParseExact(horaSeleccion, "HH:mm", null);

            DateTime fechaActual = DateTime.Today;
            DateTime fechalimite = fechaActual.AddDays(30);
            DateTime horaActual = DateTime.Now;
            DateTime horalimite = horaActual.AddHours(2);
            int resp = new int();

            int result1 = DateTime.Compare(fechaSeleccion, fechaActual);
            int result2 = DateTime.Compare(fechaSeleccion, fechalimite);
            if (result1 >= 0 & result2 < 0)
            {
                if (result1 == 0)
                {
                    int result3 = DateTime.Compare(hselect, horalimite);
                    if (result3 < 0) return resp = -2;
                }
                return resp=0;
            }
            else
                return resp=-1;

        }

        public string calcularHorasVuelo(Aeronave aeronave, double kmDistancia)
        {
            double velocidad = double.Parse(aeronave.Kmh.Substring(0, aeronave.Kmh.Length - 5));
            double horavuelo = Math.Round(kmDistancia / velocidad, 1);
            Sesion.SetValue("horavuelo", horavuelo);
            decimal t = Convert.ToDecimal(horavuelo);
            var ts = TimeSpan.FromHours((double)t);
            if (ts.Hours.Equals(0) && ts.Minutes.ToString().Length == 1) return string.Format("0{0}",ts.Minutes);
            if (ts.Hours.Equals(0)) return string.Format("{0}", ts.Minutes);
            else if (ts.Hours.ToString().Length == 1 && ts.Minutes.ToString().Length == 1) return string.Format("0{0}:0{1}", ts.Hours, ts.Minutes);
            else if (ts.Hours.ToString().Length == 1) return string.Format("0{0}:{1}", ts.Hours, ts.Minutes);
            else if (ts.Minutes.ToString().Length == 1) return string.Format("{0}:0{1}", ts.Hours, ts.Minutes);
            else return string.Format("{0}:{1}", ts.Hours, ts.Minutes);
        }

        public string calcularHoraLLegada()
        {
            double horavuelo = Sesion.GetValue<double>("horavuelo");
            string horaPartida = Sesion.GetValue<string>("horaPartida");
            double horaLLegada = Convert.ToDouble(horaPartida) + horavuelo;
            DateTime fechaPartida = Sesion.GetValue<DateTime>("fechaPartida");
            DateTime fechaLlegada = new DateTime();

            if (horaLLegada >= 24)
            {
                double dias = horaLLegada / 24;
                decimal d = Convert.ToDecimal(dias);
                var tsDias = TimeSpan.FromDays((double)d); // calcular cuanto dias pasaron
                fechaLlegada= fechaPartida.AddDays(tsDias.Days);
                Sesion.SetValue("fechaLlegada", fechaLlegada);
                horaLLegada = horaLLegada - 24;
                decimal h = Convert.ToDecimal(horaLLegada);
                var ts = TimeSpan.FromHours((double)h);
                if (ts.Hours.Equals(0) && ts.Minutes.ToString().Length == 1) return string.Format("00:0{0}", ts.Minutes);
                if (ts.Hours.Equals(0)) return string.Format("00:{0}", ts.Minutes);
                else if (ts.Hours.ToString().Length == 1 && ts.Minutes.ToString().Length == 1) return string.Format("0{0}:0{1}", ts.Hours, ts.Minutes);
                else if (ts.Hours.ToString().Length == 1) return string.Format("0{0}:{1}", ts.Hours, ts.Minutes);
                else if (ts.Minutes.ToString().Length == 1) return string.Format("{0}:0{1}", ts.Hours, ts.Minutes);
                else return string.Format("{0}:{1}", ts.Hours, ts.Minutes);
            } else
            {
                fechaLlegada = fechaPartida;
                Sesion.SetValue("fechaLlegada", fechaLlegada);
                decimal h = Convert.ToDecimal(horaLLegada);
                var ts = TimeSpan.FromHours((double)h);
                if (ts.Hours.Equals(0) && ts.Minutes.ToString().Length == 1) return string.Format("0{0}", ts.Minutes);
                if (ts.Hours.Equals(0)) return string.Format("{0}", ts.Minutes);
                else if (ts.Hours.ToString().Length == 1 && ts.Minutes.ToString().Length == 1) return string.Format("0{0}:0{1}", ts.Hours, ts.Minutes);
                else if (ts.Hours.ToString().Length == 1) return string.Format("0{0}:{1}", ts.Hours, ts.Minutes);
                else if (ts.Minutes.ToString().Length == 1) return string.Format("{0}:0{1}", ts.Hours, ts.Minutes);
                else return string.Format("{0}:{1}", ts.Hours, ts.Minutes);
            }

        }

    }
}
