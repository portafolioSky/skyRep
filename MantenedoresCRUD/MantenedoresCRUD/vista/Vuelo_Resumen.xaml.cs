using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.negocio;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para Vuelo_Resumen.xaml
    /// </summary>
    public partial class Vuelo_Resumen : Window
    {
        Aeronave aeronave = new Aeronave();
        NeVuelo nevuelo = new NeVuelo();
        NeTripulacion neTripulacion = new NeTripulacion();
        Tripulacion tri_piloto = new Tripulacion();
        Tripulacion tri_copiloto = new Tripulacion();
        public Vuelo_Resumen(Tripulacion piloto, Tripulacion copiloto)
        {
            InitializeComponent();

            tri_piloto = piloto;
            tri_copiloto = copiloto;

            aeronave = Sesion.GetValue<Aeronave>("aeronave");

            labelFeParida.Content = Sesion.GetValue<DateTime>("fechaPartida").ToString("dd'/'MM'/'yyyy");
            labelHoraSalida.Content = Sesion.GetValue<string>("showHoraPartida") + " Hrs";
            labelFeLlegada.Content = Sesion.GetValue<DateTime>("fechaLlegada").ToString("dd'/'MM'/'yyyy");
            labelHoraLlegada.Content = Sesion.GetValue<string>("showHoraLlegada")+ " Hrs";
            if(Sesion.GetValue<string>("horatotalvisual").Length ==2)
            labelCantHorasVuelo.Content = Sesion.GetValue<string>("horatotalvisual") + " Minutos aprox.";
            else labelCantHorasVuelo.Content = Sesion.GetValue<string>("horatotalvisual") + " Hrs aprox.";
            labelCondiVuelo.Content = Sesion.GetValue<string>("NombreCondicionVuelo");
            labelCiudadOrigen.Content = Sesion.GetValue<string>("origen");
            labelCiudadDestino.Content = Sesion.GetValue<string>("destino");
            labelKmDistancia.Content = string.Format("{0} Km", Sesion.GetValue<double>("kmDistancia"));
            
            labelMatricula.Content = aeronave.Matricula.ToUpper();
            labelMarca.Content = aeronave.Marca;
            labelVencDgac.Content = aeronave.VencimientoDgac;
            labelTipoAeronave.Content = aeronave.TipoAeronave.NombreTipo;
            labelVelMaxAeronave.Content = aeronave.Kmh;
            labelHorasVueloAeronave.Content = string.Format("{0} ({1})", Sesion.GetValue<double>("horavuelo"), nevuelo.getHoraDespegue(Sesion.GetValue<double>("horavuelo").ToString())); ;

            labelRutPiloto.Content = piloto.RutPiloto;
            labelNombrePiloto.Content = piloto.Nombre;
            labelHorasPiloto.Content = string.Format("{0} ({1})", piloto.CantidadHoras, nevuelo.getHoraDespegue(piloto.CantidadHoras.ToString()));
            labelTipoLicenciaPiloto.Content = piloto.TipoLicencia;

            labelRutCopiloto.Content = copiloto.RutPiloto;
            labelNombreCopiloto.Content = copiloto.Nombre;
            labelHorasCopiloto.Content = string.Format("{0} ({1})", copiloto.CantidadHoras, nevuelo.getHoraDespegue(copiloto.CantidadHoras.ToString()));
            labelTipoLicenciaCopiloto.Content = copiloto.TipoLicencia;

            //////////////////////////////////////////
           
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonIngresar_Click(object sender, RoutedEventArgs e)
        {
            DateTime fechaP = Sesion.GetValue<DateTime>("fechaPartida");
            DateTime horaP = Convert.ToDateTime(Sesion.GetValue<string>("showHoraPartida"));
            DateTime fechaL = Sesion.GetValue<DateTime>("fechaLlegada");
            DateTime horaL = Convert.ToDateTime(Sesion.GetValue<string>("showHoraLlegada"));

            DateTime hora = DateTime.Now;

        DateTime fechaSalida = fechaP.AddHours(horaP.Hour).AddMinutes(horaP.Minute).AddSeconds(horaP.Second);
        DateTime fechaArribo = fechaL.AddHours(horaL.Hour).AddMinutes(horaL.Minute).AddSeconds(horaL.Second);
        double totalTiempo = Sesion.GetValue<double>("horavuelo");
        int idCondicionVuelo = Sesion.GetValue<int>("idCondicionVuelo");
        string matriculaAeronave = aeronave.Matricula;
        int ciudadOrigen =Sesion.GetValue<int>("idOrigen"); 
        int ciudadDestino = Sesion.GetValue<int>("idDestino"); 
        string kilometros = Sesion.GetValue<double>("kmDistancia").ToString();
        string estado = "EN PROCESO";

        Vuelo vuelo = new Vuelo(fechaSalida, fechaArribo, totalTiempo, idCondicionVuelo, matriculaAeronave, ciudadOrigen, ciudadDestino, kilometros, estado);

         nevuelo.insertVuelo(vuelo);
         neTripulacion.insertTripulacion(tri_piloto,tri_copiloto);
            MessageBox.Show("Vuelo ingresado correctamente");
            this.Close();
      }
    }
}
