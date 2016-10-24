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
using System.Data;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Interaction logic for Ingresar_aeronave_componentes.xaml
    /// </summary>
    public partial class Ingresar_aeronave_componentes : Window
    {
        private NeComponente neComponente;
        private DataSet ds;
        public Ingresar_aeronave_componentes()
        {
            InitializeComponent();
        }

        private void buttonAgregarComponente_Click(object sender, RoutedEventArgs e)
        {

            Ingresar_aeronave_componentes_nuevo nuevo = new Ingresar_aeronave_componentes_nuevo(this);
            nuevo.ShowDialog();
        }

        public void actualizar()
        {
            //llenar datagrid con componentes
            Aeronave aeronave = new Aeronave();
            aeronave.Matricula = Sesion.GetValue<Aeronave>("aeronave").Matricula;
            //Aeronave aeronave = Sesion.GetValue<Aeronave>("aeronave");
            neComponente = new NeComponente();
            ds = neComponente.getComponentes(aeronave);
            dataGridComponentes.ItemsSource = new DataView(ds.Tables["listaComponentes"]);
        }

        private void dataGridComponentes_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            //llenar datagrid con componentes
            Aeronave aeronave = new Aeronave();
            aeronave.Matricula = Sesion.GetValue<Aeronave>("aeronave").Matricula;
            //Aeronave aeronave = Sesion.GetValue<Aeronave>("aeronave");
            neComponente = new NeComponente();
            ds = neComponente.getComponentes(aeronave);
            dataGridComponentes.ItemsSource = null;
            dataGridComponentes.ItemsSource = new DataView(ds.Tables["listaComponentes"]);
        }

        private void buttonListo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show("Aeronave ingresada correctamente");
        }
    }
}
