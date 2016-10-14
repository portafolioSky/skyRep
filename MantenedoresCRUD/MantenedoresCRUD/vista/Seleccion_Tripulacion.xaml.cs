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
    /// Lógica de interacción para Seleccion_Tripulacion.xaml
    /// </summary>
    public partial class Seleccion_Tripulacion : Window
    {
        private Usuario piloto;
        private Tripulacion triPiloto = new Tripulacion();
        private Tripulacion triCopiloto;
        private Ingresar_Vuelo_Pilotos vistaPiloto;
        private string rut = "";

        public Seleccion_Tripulacion()
        {
            InitializeComponent();

        }
        public Seleccion_Tripulacion(Usuario p, Ingresar_Vuelo_Pilotos vista )
        {
            InitializeComponent();

            vistaPiloto = vista;
            

            if (labeRutPilto.Content.ToString() == "")
            {
                piloto = new Usuario();
                piloto = p;
                labeRutPilto.Content = piloto.Rut;
                labelNombrePiloto.Content = piloto.Nombre;

                triPiloto.RutPiloto = piloto.Rut;
                triPiloto.Nombre = piloto.Nombre;
                triPiloto.PuestoVuelo = "Piloto";

                checkBox5050.IsEnabled = false;
                checkBox6040.IsEnabled = false;
                checkBox8020.IsEnabled = false;
                radioButtoncp.IsEnabled = false;
                radioButtonpc.IsEnabled = false;

            }

        }

        public Seleccion_Tripulacion(Usuario p, Tripulacion t, Ingresar_Vuelo_Pilotos vista)
        {
            InitializeComponent();

            vistaPiloto = vista;
            triCopiloto = new Tripulacion();

            if (t.PuestoVuelo == "Piloto")
            {
                labeRutPilto.Content = t.RutPiloto;
                labelNombrePiloto.Content = t.Nombre;
                labeRutCopiloto.Content = p.Rut;
                labelNombreCopiloto.Content = p.Nombre;

            }
            else if (t.PuestoVuelo == "Copiloto")
            {
                labeRutCopiloto.Content = t.RutPiloto;
                labelNombreCopiloto.Content = t.Nombre;
                labeRutPilto.Content = p.Rut;
                labelNombrePiloto.Content = p.Nombre;
            }

            radioButtoncp.IsEnabled = false;
            radioButtonpc.IsEnabled = false;


        }

        private void buttonLeft_Click(object sender, RoutedEventArgs e)
        {
            if (labeRutPilto.Content.ToString() == "")
            {
                labeRutPilto.Content = piloto.Rut;
                labelNombrePiloto.Content = piloto.Nombre;
                triCopiloto = null;
                triPiloto = new Tripulacion();
                triPiloto.RutPiloto = piloto.Rut;
                triPiloto.Nombre = piloto.Nombre;
                triPiloto.PuestoVuelo = "Piloto";

                labeRutCopiloto.Content = "";
                labelNombreCopiloto.Content = "";
            }

            if (labeRutPilto.Content.ToString() != "" && labeRutCopiloto.Content.ToString() !="")
            {
                if (labeRutCopiloto.Content.ToString() != rut)
                {
                    string nombre;
                    nombre = labelNombrePiloto.Content.ToString();
                    labelNombrePiloto.Content = labelNombreCopiloto.Content.ToString();
                    labelNombreCopiloto.Content = nombre;

                    rut = labeRutPilto.Content.ToString();
                    labeRutPilto.Content = labeRutCopiloto.Content.ToString();
                    labeRutCopiloto.Content = rut;
                }
               
             
            }
        }

        private void buttonRigth_Click(object sender, RoutedEventArgs e)
        {
            if (labeRutCopiloto.Content.ToString() == "")
            {
                labeRutCopiloto.Content = piloto.Rut;
                labelNombreCopiloto.Content = piloto.Nombre;
                triPiloto = null;
                triCopiloto = new Tripulacion();
                triCopiloto.RutPiloto = piloto.Rut;
                triCopiloto.Nombre = piloto.Nombre;
                triCopiloto.PuestoVuelo = "Copiloto";

                labeRutPilto.Content = "";
                labelNombrePiloto.Content = "";
            }

            if (labeRutPilto.Content.ToString() != "" && labeRutCopiloto.Content.ToString() != "")
            {
                if (labeRutPilto.Content.ToString() != rut)
                {
                    string nombre;
                    nombre = labelNombreCopiloto.Content.ToString();
                    labelNombreCopiloto.Content = labelNombrePiloto.Content.ToString();
                    labelNombrePiloto.Content = nombre;

                    rut = labeRutCopiloto.Content.ToString();
                    labeRutCopiloto.Content = labeRutPilto.Content.ToString();
                    labeRutPilto.Content = rut;
                }
 
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (triPiloto == null)
            {
                this.Hide();
                vistaPiloto.IngresarTripulacion(triCopiloto);
            }
            
            else if (triCopiloto == null)
            {
                this.Hide();
                vistaPiloto.IngresarTripulacion(triPiloto);
            }
                

            if (triPiloto !=null && triCopiloto != null)
            {
                if (radioButtoncp.IsChecked == true || radioButtonpc.IsChecked == true )
                {
                    this.Hide();
                    string relacion = "cp";
                    if (radioButtoncp.IsChecked == true) { relacion = radioButtoncp.Content.ToString(); }

                    if (radioButtonpc.IsChecked == true) { relacion = radioButtonpc.Content.ToString(); }


                    string promedioVuelo = Sesion.GetValue<string>("promedioVuelo");
                    NeTripulacion neTripulacion = new NeTripulacion();
                    triPiloto.Nombre = labelNombrePiloto.Content.ToString();
                    triPiloto.RutPiloto = labeRutPilto.Content.ToString();
                    triCopiloto.Nombre = labelNombreCopiloto.Content.ToString();
                    triCopiloto.RutPiloto = labeRutCopiloto.Content.ToString();

                    neTripulacion.calcularPromedioVueloTripulacion(triPiloto, triCopiloto, promedioVuelo, relacion);
                    double c = triCopiloto.CantidadHoras;
                    double p = triPiloto.CantidadHoras;
                    vistaPiloto.tripulacionOk(triPiloto, triCopiloto);
                }
                else
                    MessageBox.Show("Seleccione el promedio de vuelo");
            }
        }

        private void checkBox5050_Checked(object sender, RoutedEventArgs e)
        {
            radioButtoncp.IsEnabled = true;
            radioButtonpc.IsEnabled = true;

            radioButtoncp.IsChecked = false;
            radioButtonpc.IsChecked = false;


            checkBox5050.IsEnabled = false;
            checkBox6040.IsChecked = false;
            checkBox8020.IsChecked = false;
            checkBox6040.IsEnabled = true;
            checkBox8020.IsEnabled = true;


            Sesion.SetValue("promedioVuelo", checkBox5050.Content.ToString());
        }

        private void checkBox6040_Checked(object sender, RoutedEventArgs e)
        {
            radioButtoncp.IsEnabled = true;
            radioButtonpc.IsEnabled = true;

            radioButtoncp.IsChecked = false;
            radioButtonpc.IsChecked = false;

            checkBox6040.IsEnabled = false;
            checkBox8020.IsChecked = false;
            checkBox5050.IsChecked = false;
            checkBox8020.IsEnabled = true;
            checkBox5050.IsEnabled = true;

            Sesion.SetValue("promedioVuelo", checkBox6040.Content.ToString());
        }

        private void checkBox8020_Checked(object sender, RoutedEventArgs e)
        {
            radioButtoncp.IsEnabled = true;
            radioButtonpc.IsEnabled = true;

            radioButtoncp.IsChecked = false;
            radioButtonpc.IsChecked = false;

            checkBox8020.IsEnabled = false;
            checkBox5050.IsChecked = false;
            checkBox6040.IsChecked = false;
            checkBox5050.IsEnabled = true;
            checkBox6040.IsEnabled = true;

            Sesion.SetValue("promedioVuelo", checkBox8020.Content.ToString());
        }
    }
}
