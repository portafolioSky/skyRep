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
        private Usuario pilotoselec;
        private Usuario copilotoselec;
        private Usuario piloto;
        private DataSet ds;
        private Ingrear_vuelo_avion windowsVueloAvion;
        Seleccion_Tripulacion selecTripu = new Seleccion_Tripulacion();
        Tripulacion tripulacion,ppil,ccop;
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
            radioCopiloto.IsEnabled = false;
            radioPiloto.IsEnabled = false;

            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.Text;
            ds = nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);

        }

        public Ingresar_Vuelo_Pilotos()
        {

            InitializeComponent();

        }

        public void IngresarTripulacion(Tripulacion p)
        {

            InitializeComponent();
            tripulacion = new Tripulacion();
            tripulacion.RutPiloto = p.RutPiloto;
            tripulacion.Nombre = p.Nombre;
            tripulacion.PuestoVuelo = p.PuestoVuelo;
            if (p.PuestoVuelo == "Piloto")
            {
                pilotoselec = new Usuario();
                DataRowView row = (DataRowView)dgListaPilotdos.SelectedItems[0];
                pilotoselec.Rut = row["Rut"].ToString();
                pilotoselec.Nombre = row["Nombre"].ToString();
                pilotoselec.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
                pilotoselec.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
                pilotoselec.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());

                LabePiloto.Content = pilotoselec.Nombre;
                radioPiloto.IsEnabled = true;
            }



            else if (p.PuestoVuelo == "Copiloto")
            {
                copilotoselec = new Usuario();
                DataRowView row = (DataRowView)dgListaPilotdos.SelectedItems[0];
                copilotoselec.Rut = row["Rut"].ToString();
                copilotoselec.Nombre = row["Nombre"].ToString();
                copilotoselec.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
                copilotoselec.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
                copilotoselec.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());
                LabelCopi.Content = copilotoselec.Nombre;
                radioCopiloto.IsEnabled = true;
            }
                

        }

        public void tripulacionOk(Tripulacion pil, Tripulacion cop)
        {

            InitializeComponent();
            dgListaPilotdos.IsEnabled = false;

            ppil = new Tripulacion();
            ccop = new Tripulacion();
            

            if (pilotoselec == null)
            {

                pilotoselec = new Usuario();
                DataRowView row = (DataRowView)dgListaPilotdos.SelectedItems[0];
                pilotoselec.Rut = row["Rut"].ToString();
                pilotoselec.Nombre = row["Nombre"].ToString();
                pilotoselec.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
                pilotoselec.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
                pilotoselec.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());
            }

            if (copilotoselec == null)
            {

                copilotoselec = new Usuario();
                DataRowView row = (DataRowView)dgListaPilotdos.SelectedItems[0];
                copilotoselec.Rut = row["Rut"].ToString();
                copilotoselec.Nombre = row["Nombre"].ToString();
                copilotoselec.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
                copilotoselec.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
                copilotoselec.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());
            }

            if(pilotoselec.Rut != pil.RutPiloto)
            {
                piloto = pilotoselec;
                pilotoselec = copilotoselec;
                copilotoselec = piloto;
                LabePiloto.Content = pilotoselec.Nombre;
                radioPiloto.IsEnabled = true;
            }

            else if (copilotoselec.Rut != cop.RutPiloto)
            {
                piloto = copilotoselec;
                copilotoselec = pilotoselec;
                pilotoselec = piloto;
                
            }

            ppil = pil;
            ccop = cop;

            ppil.TipoLicencia = pilotoselec.Licencia.TipoLicencia.NombreLicencia;
            ccop.TipoLicencia = copilotoselec.Licencia.TipoLicencia.NombreLicencia;
            ppil.PuestoVuelo = "Piloto";
            ccop.PuestoVuelo = "Copiloto";
            LabePiloto.Content = pilotoselec.Nombre;
            radioPiloto.IsEnabled = true;
            LabelCopi.Content = copilotoselec.Nombre;
            radioCopiloto.IsEnabled = true;
            buttonFinalizar.IsEnabled = true;
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

            DataRowView row = (DataRowView)dgListaPilotdos.SelectedItems[0];
            piloto.Rut = row["Rut"].ToString();
            piloto.Nombre = row["Nombre"].ToString();
            piloto.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
            piloto.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
            piloto.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());
            if (tripulacion == null)
            {
                selecTripu = new Seleccion_Tripulacion(piloto, this);
                selecTripu.ShowDialog();
            }
            else if (piloto.Nombre != tripulacion.Nombre)
            {
                selecTripu = new Seleccion_Tripulacion(piloto, tripulacion, this);
                selecTripu.ShowDialog();
            }
            else
                MessageBox.Show("Piloto ya seleccionado");  

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            windowsVueloAvion.ShowDialog();
        }

        private void comboBoxTipoPiloto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            radioPiloto.IsEnabled = false;
            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.SelectedValue.ToString();
            ds=nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);
        }

        private void textBoxRut_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgListaPilotdos.SelectedIndex = -1;
            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.Text;
            ds = nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);
        }

        private void textBoxPiloto_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxPiloto.Text;
            piloto.Licencia.TipoLicencia.NombreLicencia = comboBoxTipoPiloto.Text;
            ds = nePiloto.listarPiloto(piloto);
            dgListaPilotdos.ItemsSource = new DataView(ds.Tables["listaPiloto"]);
        }

        private void buttonVerLicencia_Click(object sender, RoutedEventArgs e)
        {

            if (radioCopiloto.IsChecked == false && radioPiloto.IsChecked == false)
            {
                VerLicencia verLicencia = new VerLicencia(piloto);
                verLicencia.ShowDialog();
            }
            if (radioCopiloto.IsChecked == true)
            {
                VerLicencia verLicencia = new VerLicencia(copilotoselec);
                verLicencia.ShowDialog();
            }
            if (radioPiloto.IsChecked == true)
            {
                VerLicencia verLicencia = new VerLicencia(pilotoselec);
                verLicencia.ShowDialog();
            }


        }


        private void dgListaPilotdos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if ((sender as DataGrid).SelectedItem != null)
            {

                DataRowView row = (DataRowView)dgListaPilotdos.SelectedItems[0];
                piloto.Rut = row["Rut"].ToString();
                piloto.Nombre = row["Nombre"].ToString();
                piloto.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
                piloto.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
                piloto.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());

                buttonVerLicencia.IsEnabled = true;
                if (radioCopiloto.IsChecked == true || radioPiloto.IsChecked == true)
                {
                    radioCopiloto.IsChecked = false;
                    radioPiloto.IsChecked = false;
                }
            }
           
        }

        private void buttonFinalizar_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
            Vuelo_Resumen  resumen = new Vuelo_Resumen(ppil, ccop);
            resumen.ShowDialog();

        }
    }
}
