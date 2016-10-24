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
        private Componente componente = new Componente();
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
            if ((sender as System.Windows.Controls.DataGrid).SelectedItem != null)
            {
                DataRowView data = null;
                dsMant = new DataSet();
                data = (DataRowView)dataGridComp.SelectedItems[0];
                string id = data["ID"].ToString();
                int idComp = int.Parse(id);
                Sesion.SetValue("idComp", idComp);
                componente.IdComponente = idComp;
                dsMant = neMantComp.getMantenimientosComp(componente);
                dataGridMantComp.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
                buttonIngresarMantComp.IsEnabled = true;
                buttonBorrarMantComp.IsEnabled = false;
                buttonModificarMantComp.IsEnabled = false;
            }
        }

        private void buttonIngresarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            InsertMantenimientoComponente insert = new InsertMantenimientoComponente();
            insert.ShowDialog();
            dsMant = neMantComp.getMantenimientosComp(componente);
            dataGridMantComp.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
        }

        private void buttonModificarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            DataRowView data = null;
            dsMant = new DataSet();
            MantenimientoComponente mantComp = new MantenimientoComponente();
            NeMantenimientoComponente neMantenimientoComponente = new NeMantenimientoComponente();
            data = (DataRowView)dataGridMantComp.SelectedItems[0];
            string id = data["Id"].ToString();
            int idMantComp = int.Parse(id);
            Sesion.SetValue("idMantComp", idMantComp);
            ModificarMantenimientoComponente modificar = new ModificarMantenimientoComponente();
            modificar.ShowDialog();
            dsMant = neMantenimientoComponente.getMantenimientosComp(componente);
            dataGridMantComp.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
            buttonBorrarMantComp.IsEnabled = false;
            buttonModificarMantComp.IsEnabled = false;
        }

        private void buttonBorrarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            DataRowView data = null;
            dsMant = new DataSet();
            MantenimientoComponente mantComp = new MantenimientoComponente();
            NeMantenimientoComponente neMantenimientoComponente = new NeMantenimientoComponente();
            data = (DataRowView)dataGridMantComp.SelectedItems[0];
            string id = data["Id"].ToString();
            int idMant = int.Parse(id);
            mantComp.IdMantenimiento = idMant;
            neMantenimientoComponente.delMantenimientoComp(mantComp);
            System.Windows.MessageBox.Show("Mantenimiento Eliminado");
            dsMant = neMantenimientoComponente.getMantenimientosComp(componente);
            dataGridMantComp.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
            buttonBorrarMantComp.IsEnabled = false;
            buttonModificarMantComp.IsEnabled = false;
        }
        private void dataGridMantComp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonBorrarMantComp.IsEnabled = true;
            buttonModificarMantComp.IsEnabled = true;
        }
        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
