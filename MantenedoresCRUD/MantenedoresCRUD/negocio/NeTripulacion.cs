using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.dao;
using System.Data;
using MantenedoresCRUD.vista;
using System.Collections;

namespace MantenedoresCRUD.negocio
{
    class NeTripulacion
    {
        public void calcularPromedioVueloTripulacion(Tripulacion triPiloto, Tripulacion triCopiloto, string promedioVuelo, string relacion)
        {
            double tiempoTotal = Sesion.GetValue<double>("horavuelo");

            if (promedioVuelo == "50/50")
            {
                double tiempo50 = tiempoTotal * 50 / 100;
                triPiloto.CantidadHoras = tiempo50;
                triCopiloto.CantidadHoras = tiempo50;
            }

            if (promedioVuelo == "60/40")
            {
                double tiempo60 = tiempoTotal * 60 / 100;
                double tiempo40 = tiempoTotal * 40 / 100;

                if (relacion == "C/P")
                {
                    triPiloto.CantidadHoras = tiempo40;
                    triCopiloto.CantidadHoras = tiempo60;
                }
                else
                {
                    triPiloto.CantidadHoras = tiempo60;
                    triCopiloto.CantidadHoras = tiempo40;
                }
                
            }

            if (promedioVuelo == "80/20")
            {
                double tiempo80 = tiempoTotal *80 / 100;
                double tiempo20 = tiempoTotal * 20 / 100;

                if (relacion == "C/P")
                {
                    triPiloto.CantidadHoras = tiempo20;
                    triCopiloto.CantidadHoras = tiempo80;
                }
                else
                {
                    triPiloto.CantidadHoras = tiempo80;
                    triCopiloto.CantidadHoras = tiempo20;
                }


            }
        }


        public void insertTripulacion(Tripulacion piloto, Tripulacion copiloto)
        {

            List<Tripulacion> tripulacion = new List<Tripulacion>();
            tripulacion.Add(piloto);
            tripulacion.Add(copiloto);

            TripulacionDao tripulaciondao = new TripulacionDao();

            tripulaciondao.ingresarTripulacion(tripulacion);

        }
    }
}
