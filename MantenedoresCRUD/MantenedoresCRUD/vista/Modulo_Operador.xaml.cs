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
using MantenedoresCRUD.modelo;
using MantenedoresCRUD.negocio;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para Modulo_Operador.xaml
    /// </summary>
    public partial class Modulo_Operador : Window
    {
        private Usuario usuario = new Usuario();
        private NeAeronave neAeronave;
        private DataSet ds;
        private Aeronave aeronave;
        private NePiloto nePiloto;
        public Modulo_Operador(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            labelSaludo.Content = "HOLA " + usuario.NombreCompleto().ToUpper();
            nePiloto = new NePiloto();
            neAeronave = new NeAeronave();
            ds = new DataSet();
            //llenar el combobox
            ds = neAeronave.getTipoAeronave();
            comboBox.DisplayMemberPath = "NOMBRE_TIPO";
            comboBox.SelectedValuePath = "NOMBRE_TIPO";
            comboBox.ItemsSource = ds.Tables["listaTipoAeronave"].DefaultView;
            comboBox.SelectedIndex = comboBox.Items.Count - 1;
            //llenar combobox piloto
            ds = new DataSet();
            ds = nePiloto.listarTipoPiloto();
            comboBoxTipoAeronavePiloto.DisplayMemberPath = "NOMBRE";
            comboBoxTipoAeronavePiloto.SelectedValuePath = "NOMBRE";
            comboBoxTipoAeronavePiloto.ItemsSource = ds.Tables["listaTipoPiloto"].DefaultView;
            comboBoxTipoAeronavePiloto.SelectedIndex = comboBoxTipoAeronavePiloto.Items.Count - 1;
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            aeronave = new Aeronave();
            string matricula = textBoxMatricula.Text;
            string tipo = comboBox.SelectedValue.ToString();
            aeronave.Matricula = matricula;
            aeronave.TipoAeronave.NombreTipo = tipo;
            ds = neAeronave.getAeronave(aeronave);
            dataGrid_nave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
        }

        private void btnBuscarAvion_Click(object sender, RoutedEventArgs e)
        {
            aeronave = new Aeronave();
            string matricula = textBoxMatricula.Text;
            string tipo = comboBox.SelectedValue.ToString();
            aeronave.Matricula = matricula;
            aeronave.TipoAeronave.NombreTipo = tipo;
            ds = neAeronave.getAeronave(aeronave);
            dataGrid_nave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
        }

        private void comboBoxTipoAeronavePiloto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string rut = textBoxRutPiloto.Text;
            string tipo = comboBoxTipoAeronavePiloto.SelectedValue.ToString();

            ds = nePiloto.listarTodosPilotos(tipo,rut);
            dataGrid_nave.ItemsSource = new DataView(ds.Tables["listaPilotos"]);
        }

        private void btnBuscarPiloto_Click(object sender, RoutedEventArgs e)
        {
            string rut = textBoxRutPiloto.Text;
            string tipo = comboBoxTipoAeronavePiloto.SelectedValue.ToString();

            ds = nePiloto.listarTodosPilotos(tipo, rut);
            dataGrid_nave.ItemsSource = new DataView(ds.Tables["listaPilotos"]);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void buttonMininizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void buttonIngresarVuelo_Click(object sender, RoutedEventArgs e)
        {
            Ingresar_vuelo ingresarVuelo = new Ingresar_vuelo();
            ingresarVuelo.ShowDialog();

        }

        private void btnPilotos_Click(object sender, RoutedEventArgs e)
        {
            //dejar fuera los controles de buscar avion
            dejarFueraControlesAvion();
            //dejar fuera los controles de buscar vuelo
            //dejar dentro los controles de buscar piloto
            dejarDentroControlesPiloto();
            //llenar datos
            string rut = "";
            string tipo = "";

            ds = nePiloto.listarTodosPilotos(tipo, rut);
            dataGrid_nave.ItemsSource = new DataView(ds.Tables["listaPilotos"]);

        }

        private void btnAeronaves_Click(object sender, RoutedEventArgs e)
        {
            //dejar fuera controles de buscar piloto
            dejarFueraControlesPiloto();
            //dejar fuera controles de buscar vuelo
            //dejar dentro controles de buscar avion
            dejarDentroControlesAvion();
            //lenar datos
            aeronave = new Aeronave();
            string matricula = "";
            string tipo = "";
            aeronave.Matricula = matricula;
            aeronave.TipoAeronave.NombreTipo = tipo;
            ds = neAeronave.getAeronave(aeronave);
            dataGrid_nave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
        }


        private void dejarFueraControlesPiloto()
        {
            comboBoxTipoAeronavePiloto.Margin = new Thickness(1029, 35.667, -149, 0);
            labelRutPiloto.Margin = new Thickness(1029, 63.667, -129, 0);
            textBoxRutPiloto.Margin = new Thickness(1029, 94.667, -149, 0);
            btnBuscarPiloto.Margin = new Thickness(1185, 63.667, -256, 0);
        }

        private void dejarDentroControlesPiloto()
        {
            comboBoxTipoAeronavePiloto.Margin = new Thickness(649, 39.667, 0, 0);
            labelRutPiloto.Margin = new Thickness(654, 61.667, 0, 0);
            textBoxRutPiloto.Margin = new Thickness(654, 94.667, 0, 0);
            btnBuscarPiloto.Margin = new Thickness(867, 63.667, 0, 0);
        }

        private void dejarFueraControlesAvion()
        {
            comboBox.Margin = new Thickness(1029, 35.667, -149, 0);
            textBoxMatricula.Margin = new Thickness(1029, 94.667, -149, 0);
            btnBuscarAvion.Margin = new Thickness(1185, 63.667, -256, 0);
        }

        private void dejarDentroControlesAvion()
        {
            comboBox.Margin = new Thickness(649, 39.667, 0, 0);
            textBoxMatricula.Margin = new Thickness(654, 94.667, 0, 0);
            btnBuscarAvion.Margin = new Thickness(867, 63.667, 0, 0);
        }

        private void buttonIngresarAeronave_Click(object sender, RoutedEventArgs e)
        {
            Ingresar_aeronave ingresar_aeronave = new Ingresar_aeronave();
            ingresar_aeronave.ShowDialog();
        }
    }
}
