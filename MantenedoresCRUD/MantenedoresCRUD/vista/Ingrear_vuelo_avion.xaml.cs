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
        private Aeronave aeronave;
        private DataSet ds;
        public Ingrear_vuelo_avion()
        {
            InitializeComponent();
            neAeronave = new NeAeronave();
            ds = new DataSet();
            ds = neAeronave.getTipoAeronave();
            comboBoxTipoAeronave.DisplayMemberPath = "NOMBRE_TIPO";
            comboBoxTipoAeronave.SelectedValuePath = "NOMBRE_TIPO";
            comboBoxTipoAeronave.ItemsSource = ds.Tables["listaTipoAeronave"].DefaultView;

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
            listViewAeronave.DisplayMemberPath = "Matricula";
            listViewAeronave.SelectedValuePath = "MATRICULA";
            listViewAeronave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
            dataGrid.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
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
            dataGrid.SelectedValuePath = "Matricula";
            labelPrueba.Content = dataGrid.SelectedValue;
        }

    }
}
