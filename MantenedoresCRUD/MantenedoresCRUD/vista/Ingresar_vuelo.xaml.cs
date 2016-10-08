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
using System.Data;
using MantenedoresCRUD.negocio;
using MantenedoresCRUD.modelo;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para Ingresar_vuelo.xaml
    /// </summary>
    public partial class Ingresar_vuelo : Window
    {

        private DataSet dsCiudad;
        private NeVuelo neVueloGetCiudad;
        private Ciudad ciudadOrigen;
        private Ciudad ciudadDestino;
        private int idCondicionVuelo;
        private DateTime hora;


        public Ingresar_vuelo()
        {
            InitializeComponent();
            neVueloGetCiudad = new NeVuelo();
            dsCiudad = new DataSet();
            dsCiudad = neVueloGetCiudad.ciudadOrigen();
            comboBoxOrigen.DisplayMemberPath = "NOMBRE_CIUDAD";
            comboBoxOrigen.SelectedValuePath = "ID_CIUDAD";
            comboBoxOrigen.ItemsSource = dsCiudad.Tables["nombre_ciudad"].DefaultView;
            comboBoxDestino.IsEnabled = false;
            dpFechaSalida.DisplayDateStart = DateTime.Now;
            dpFechaSalida.DisplayDateEnd = DateTime.Now.AddDays(30);

        }


        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboBoxOrigen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxOrigen.SelectedValue != null)
            {
                ciudadOrigen = new Ciudad();
                ciudadOrigen.IdCiudad = Convert.ToInt32(comboBoxOrigen.SelectedValue.ToString());
                neVueloGetCiudad = new NeVuelo();
                dsCiudad = new DataSet();
                dsCiudad = neVueloGetCiudad.ciudadDestino(ciudadOrigen);
                comboBoxDestino.DisplayMemberPath = "NOMBRE_CIUDAD";
                comboBoxDestino.SelectedValuePath = "ID_CIUDAD";
                comboBoxDestino.ItemsSource = dsCiudad.Tables["nombre_ciudad"].DefaultView;
                comboBoxDestino.IsEnabled = true;
            }

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string shora = horaDespegue.Value.ToString();
            NeVuelo getHrDes = new NeVuelo();
            hora = getHrDes.getHoraDespegue(shora);
            labelHorasDespegue.Content= hora.ToString("HH:mm")+" Hrs";

        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                DateTime fechaSelect = new DateTime();
                fechaSelect = dpFechaSalida.SelectedDate.Value;
                NeVuelo valFechaHora = new NeVuelo();
                int resp;
                resp= valFechaHora.validarFechaHora(fechaSelect,hora);

                switch (resp)
                {
                    case -1:
                         MessageBox.Show("Debe seleccionar un fecha futura");
                        break;
                    case -2:
                         MessageBox.Show("Hora despegue debe tener 4 horas de anticipacion");
                        break;
                    case 0:
                        if (radioButtonIrf.IsChecked == false & radioButtonVrf.IsChecked == false) { MessageBox.Show("Verifique que no existan datos vacios"); return; }

                        else if (radioButtonIrf.IsChecked == true) { Sesion.SetValue("condicionVuelo", idCondicionVuelo); }
                        else if (radioButtonVrf.IsChecked == true) { Sesion.SetValue("condicionVuelo", idCondicionVuelo); }

                        ciudadOrigen = new Ciudad();
                        ciudadDestino = new Ciudad();
                        ciudadOrigen.IdCiudad = Convert.ToInt32(comboBoxOrigen.SelectedValue.ToString());
                        ciudadDestino.IdCiudad = Convert.ToInt32(comboBoxDestino.SelectedValue.ToString());
                        string origen = comboBoxOrigen.Text;
                        string destino = comboBoxDestino.Text;
                        double kmDistancia = new double();
                        kmDistancia = neVueloGetCiudad.getDintancia(ciudadOrigen, ciudadDestino);
                        Sesion.SetValue("kmDistancia", kmDistancia);
                        Ingrear_vuelo_avion next = new Ingrear_vuelo_avion();
                        this.Hide();
                        next.ShowDialog();
                         break;
                }
    

            }
            catch(Exception)
            {
                MessageBox.Show("Verifique que no existan datos vacios");
            }
        }

        private void radioButtonIrf_Checked(object sender, RoutedEventArgs e)
        {
            idCondicionVuelo = 1;
        }

        private void radioButtonVrf_Checked(object sender, RoutedEventArgs e)
        {
            idCondicionVuelo = 2;
        }
    }
}
