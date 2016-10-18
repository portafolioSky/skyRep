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
    /// Lógica de interacción para HabilitarPiloto.xaml
    /// </summary>
    public partial class HabilitarPiloto : Window
    {

        private NePiloto nePiloto = new NePiloto();
        private DataSet ds = new DataSet();
        private Usuario piloto= new Usuario();
        public HabilitarPiloto()
        {
            InitializeComponent();

            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxNombre.Text;

            ds = nePiloto.getHabilitarPiloto(piloto);
            dataGridPilotos.ItemsSource = new DataView(ds.Tables["habilitarPiloto"]);
        }

        public void recargarLista()
        {


            ds = nePiloto.getHabilitarPiloto(piloto);
            dataGridPilotos.ItemsSource = new DataView(ds.Tables["habilitarPiloto"]);
        }



        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

  

        private void dataGridPilotos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as DataGrid).SelectedItem != null)
            {
                piloto = new Usuario();

                DataRowView row = (DataRowView)dataGridPilotos.SelectedItems[0];

                piloto.Rut = row["Rut"].ToString();
                piloto.Nombre = row["Nombre"].ToString();
                if(row["Tipo de licencia"]!=null) piloto.Licencia.TipoLicencia.NombreLicencia = row["Tipo de licencia"].ToString();
                if (row["Venc Med Aeroespacial"].ToString() != "") piloto.FechaMeAeroespacial = DateTime.Parse(row["Venc Med Aeroespacial"].ToString());
                if (row["Venc licencia"].ToString() != "") piloto.Licencia.FechaExpiracion = DateTime.Parse(row["Venc licencia"].ToString());
                if (row["Emis licencia"].ToString() != "") piloto.Licencia.FechaEmision = DateTime.Parse(row["Emis licencia"].ToString());
                Form_Habilitar_Piloto next = new Form_Habilitar_Piloto(this, piloto);
                next.ShowDialog();

            }
        }

        private void textBoxRut_TextChanged(object sender, TextChangedEventArgs e)
        {
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxNombre.Text;

            ds = nePiloto.getHabilitarPiloto(piloto);
            dataGridPilotos.ItemsSource = new DataView(ds.Tables["habilitarPiloto"]);
        }

        private void textBoxNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = textBoxNombre.Text;

            ds = nePiloto.getHabilitarPiloto(piloto);
            dataGridPilotos.ItemsSource = new DataView(ds.Tables["habilitarPiloto"]);
        }
    }
}
