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
using MantenedoresCRUD.vista;
using System.Data;
using MantenedoresCRUD.negocio;
using MantenedoresCRUD.modelo;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para MantenimientoComp.xaml
    /// </summary>
    public partial class MantenimientoComp : Window
    {
        private NeComponente neComponente;
        private Aeronave aeronave;
        private string matricula;
        private DataSet ds;
        private DataSet dsMant;
        private NeMantenimientoComponente neMantComp;
        public MantenimientoComp()
        {
            InitializeComponent();
            aeronave = new Aeronave();
            neComponente = new NeComponente();
            ds = new DataSet();
            neMantComp = new NeMantenimientoComponente();
            matricula = Sesion.GetValue<string>("Matricula");
            
            aeronave.Matricula = matricula;
            ds = neComponente.getComponentes(aeronave);
            dataGridComp.ItemsSource = new DataView(ds.Tables["listaComponentes"]);
        }

        private void dataGridComp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DataRowView data = null;
            dsMant = new DataSet();
            data = (DataRowView)dataGridComp.SelectedItems[0];
            string id = data["ID_COMPONENTE"].ToString();
            int idComp = int.Parse(id);

            Componente componente = new Componente(idComp);
            dsMant = neMantComp.getMantenimientosComp(componente);
            dataGridMantComp.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
            buttonIngresarMantComp.IsEnabled = true;
                
            
        }

        private void buttonIngresarMantenimiento_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonModificarMantenimiento_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonBorrarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            DataRowView data = null;
            dsMant = new DataSet();
            MantenimientoComponente mantComp = new MantenimientoComponente();
            NeMantenimientoComponente neMantenimientoComponente = new NeMantenimientoComponente();
            data = (DataRowView)dataGridComp.SelectedItems[0];
            string id = data["Id Componente"].ToString();
            int idMant = int.Parse(id);
            mantComp.IdMantenimiento = idMant;
            neMantenimientoComponente.delMantenimientoComp(mantComp);
            System.Windows.MessageBox.Show("Mantenimiento Eliminado");
            //dsMant = neMantenimientoComponente.getMantenimientosComp()
        }

        private void dataGridMantComp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonBorrarMantComp.IsEnabled = true;
            buttonModificarMantComp.IsEnabled = true;
        }
    }
}
