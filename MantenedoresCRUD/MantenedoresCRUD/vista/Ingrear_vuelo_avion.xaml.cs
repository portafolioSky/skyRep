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
    /// Lógica de interacción para Ingrear_vuelo_avion.xaml
    /// </summary>
    public partial class Ingrear_vuelo_avion : Window
    {
        private NeAeronave neAeronave;
        private NeVuelo neVuelo;
        private Aeronave aeronave;
        private DataSet ds;
        private Ingresar_vuelo windowsVuelo = new Ingresar_vuelo();
        public Ingrear_vuelo_avion(Ingresar_vuelo w)
        {
            InitializeComponent();
            neAeronave = new NeAeronave();
            ds = new DataSet();
            ds = neAeronave.getTipoAeronave();
            comboBoxTipoAeronave.DisplayMemberPath = "NOMBRE_TIPO";
            comboBoxTipoAeronave.SelectedValuePath = "NOMBRE_TIPO";
            comboBoxTipoAeronave.ItemsSource = ds.Tables["listaTipoAeronave"].DefaultView;
            dataGridListaNave.SelectedValuePath = "Matricula";
            windowsVuelo = w;
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonBuscar_Click(object sender, RoutedEventArgs e)
        {
            aeronave = new Aeronave();
            string matricula = textBoxMatricula.Text;
            string tipo = comboBoxTipoAeronave.Text;
            aeronave.Matricula = matricula;
            aeronave.TipoAeronave.NombreTipo = tipo;
            ds = neAeronave.getAeronave(aeronave);
            dataGridListaNave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
        }

        private void textBoxMatricula_TextChanged(object sender, TextChangedEventArgs e)
        {
            aeronave = new Aeronave();
            string matricula = textBoxMatricula.Text;
            string tipo = comboBoxTipoAeronave.Text;
            aeronave.Matricula = matricula;
            aeronave.TipoAeronave.NombreTipo = tipo;
            ds = neAeronave.getAeronave(aeronave);
            dataGridListaNave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
        }

        private void comboBoxTipoAeronave_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            aeronave = new Aeronave();
            string matricula = textBoxMatricula.Text;
            string tipo = comboBoxTipoAeronave.SelectedValue.ToString();
            aeronave.Matricula = matricula;
            aeronave.TipoAeronave.NombreTipo = tipo;
            ds = neAeronave.getAeronave(aeronave);
            dataGridListaNave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
            
        }

        private void ChangeText(object sender, RoutedEventArgs e)
        {
            aeronave = new Aeronave();
           
            DataRowView row = (DataRowView)dataGridListaNave.SelectedItems[0];

            aeronave.Matricula= row["Matricula"].ToString();
            aeronave.Marca = row["Marca"].ToString();
            aeronave.TipoAeronave.NombreTipo = row["Tipo de aeronave"].ToString();
            aeronave.VencimientoDgac = Convert.ToDateTime(row["Venc certificado DGAC"].ToString());
            aeronave.Kmh = row["Velocidad Max"].ToString();
            Sesion.SetValue("aeronave", aeronave);
            neVuelo = new NeVuelo();
            string hora = neVuelo.calcularHorasVuelo(aeronave,Sesion.GetValue<double>("kmDistancia"));
            string horatotal = neVuelo.calcularHoraLLegada();
            Sesion.SetValue("showHoraLlegada", horatotal);
            Ingresar_Vuelo_Pilotos next = new Ingresar_Vuelo_Pilotos(this);
            this.Hide();
            next.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            windowsVuelo.ShowDialog();
        }
    }
}
