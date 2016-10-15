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
    /// Lógica de interacción para Ingresar_Vuelo_Pilotos.xaml
    /// </summary>
    public partial class Ingresar_Vuelo_Pilotos : Window
    {
        private Aeronave aeronave;
        private NePiloto nePiloto;
        private Usuario piloto;
        private DataSet ds;
        private Ingrear_vuelo_avion windowsVueloAvion;
        public Ingresar_Vuelo_Pilotos(Ingrear_vuelo_avion w)
        {

            InitializeComponent();
            windowsVueloAvion = w;

            nePiloto = new NePiloto();
            ds = new DataSet();
            ds = nePiloto.getTipoPiloto();
            comboBoxTipoPiloto.DisplayMemberPath = "NOMBRE";
            comboBoxTipoPiloto.SelectedValuePath = "NOMBRE";
            comboBoxTipoPiloto.ItemsSource = ds.Tables["piloto_tipo"].DefaultView;


            aeronave = new Aeronave();
            aeronave = Sesion.GetValue<Aeronave>("aeronave");
            labelNave.Content = string.Format("{0} ({1})", aeronave.Marca, aeronave.TipoAeronave.NombreTipo);   
            labelDistancia.Content = Sesion.GetValue<double>("kmDistancia")+" Km";
            labelFechaPartida.Content = string.Format("{0} ({1} Hrs)", Sesion.GetValue<DateTime>("fechaPartida").ToString("dd'/'MM'/'yyyy"), Sesion.GetValue<string>("showHoraPartida"));
            labelFechaLlegada.Content = string.Format("{0} ({1} Hrs)", Sesion.GetValue<DateTime>("fechaLlegada").ToString("dd'/'MM'/'yyyy"), Sesion.GetValue<string>("showHoraLlegada"));
            labelOrigenDestino.Content = string.Format("{0}/{1}", Sesion.GetValue<string>("origen"), Sesion.GetValue<string>("destino"));
            labelTipoVuelo.Content = Sesion.GetValue<string>("NombreCondicionVuelo");

            buttonFinalizar.IsEnabled = false;
            buttonVerLicencia.IsEnabled = false;
            comboBoxPuesto.IsEnabled = false;
            buttonAceptar.IsEnabled = false;

            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.Text;
            ds = nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ChangeText(object sender, RoutedEventArgs e)
        {
            buttonVerLicencia.IsEnabled = true;
            comboBoxPuesto.IsEnabled = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            windowsVueloAvion.ShowDialog();
        }

        private void comboBoxTipoPiloto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonVerLicencia.IsEnabled = false;
            comboBoxPuesto.IsEnabled = false;

            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.SelectedValue.ToString();
            ds=nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);
        }

        private void textBoxRut_TextChanged(object sender, TextChangedEventArgs e)
        {
            buttonVerLicencia.IsEnabled = false;
            comboBoxPuesto.IsEnabled = false;
            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.Text;
            ds = nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);
        }

        private void textBoxPiloto_TextChanged(object sender, TextChangedEventArgs e)
        {
            buttonVerLicencia.IsEnabled = false;
            comboBoxPuesto.IsEnabled = false;
            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.Text;
            ds = nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);
        }

        private void buttonVerLicencia_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dgListaPilotdos.SelectedItems[0];
            piloto.Rut = row["Rut"].ToString();
            piloto.Nombre = row["Nombre"].ToString();
            piloto.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
            piloto.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
            piloto.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());
            VerLicencia verLicencia = new VerLicencia(piloto);
            verLicencia.ShowDialog();
        }
    }
}
