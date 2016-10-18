using MantenedoresCRUD.modelo;
using MantenedoresCRUD.negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MantenedoresCRUD.vista;
using System.Windows.Navigation;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para Mantenimientos.xaml
    /// </summary>
    public partial class Mantenimientos : Window
    {

        private NeAeronave neAeronave;
        private NeMantenimientoAeronave neMantenimiento;
        private Aeronave aeronave = new Aeronave();
        private DataSet ds;
        private DataSet dsMant;
        
     
        public Mantenimientos()
        {
       
            InitializeComponent();
            neAeronave = new NeAeronave();
            neMantenimiento = new NeMantenimientoAeronave();
            dsMant = new DataSet();
            ds = new DataSet();
            ds = neAeronave.getTipoAeronave();
            comboBoxTipoAeronave.DisplayMemberPath = "NOMBRE_TIPO";
            comboBoxTipoAeronave.SelectedValuePath = "NOMBRE_TIPO";
            comboBoxTipoAeronave.ItemsSource = ds.Tables["listaTipoAeronave"].DefaultView;
        }

        private void comboBoxTipoAeronave_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ds = new DataSet();
            aeronave = new Aeronave();
            string matricula = textBoxMatricula.Text;
            string tipo = comboBoxTipoAeronave.SelectedValue.ToString();
            aeronave.Matricula = matricula;
            aeronave.TipoAeronave.NombreTipo = tipo;
            ds = neAeronave.getAeronave(aeronave);
            dataGridListaNave.ItemsSource = null;
            dataGridMant.ItemsSource = null;
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
            buttonBuscar.IsEnabled = true;  
        }

        private void buttonBuscar_Click(object sender, RoutedEventArgs e)
        {
            dsMant = new DataSet();
            aeronave = new Aeronave();
            string matricula = textBoxMatricula.Text;
            aeronave.Matricula = matricula;
            dsMant = neMantenimiento.getMantenimientos(aeronave);
            ds = neAeronave.getAeronave(aeronave);
            dataGridListaNave.ItemsSource = new DataView(ds.Tables["listaAeronaves"]);
            dataGridMant.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
            groupBoxMant.Header = "Mantenimientos " + matricula;
        }

        private void dataGridListaNave_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if ((sender as System.Windows.Controls.DataGrid).SelectedItem != null)
            {
                DataRowView data = null;
                dsMant = new DataSet();
                data = (DataRowView)dataGridListaNave.SelectedItems[0];
                string matricula = data["Matricula"].ToString();
                aeronave.Matricula = matricula;
                dsMant = neMantenimiento.getMantenimientos(aeronave);
                dataGridMant.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
                groupBoxMant.Header = "Mantenimientos de Aeronave " + matricula.ToUpper();
                groupBoxControlMantenimientos.Header = "Control de Mantenimientos Aeronave " + matricula.ToUpper();
                groupBoxComponentes.Header = "Componentes Aeronave " + matricula.ToUpper();
                Sesion.SetValue("Matricula", matricula);
                if (matricula != "")
                {
                    buttonIngresarMantenimiento.IsEnabled = true;
                    buttonMantComponentes.IsEnabled=true;
                }
            }
        }


        private void buttonMantComponentes_Click(object sender, RoutedEventArgs e)
        {
            MantenimientoComp mantComp = new MantenimientoComp();
            mantComp.ShowDialog(); 
        }

        private void dataGridMant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonBorrarMantenimiento.IsEnabled = true;  
            buttonModificarMantenimiento.IsEnabled = true;
        }

        private void buttonIngresarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            InsertMantenimientoAeronave insert = new InsertMantenimientoAeronave();
            insert.ShowDialog();
        }

        private void buttonBorrarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            DataRowView data = null;
            dsMant = new DataSet();
            MantenimientoAeronave mantNave = new MantenimientoAeronave();
            NeMantenimientoAeronave neMantenimientoAeronave =  new NeMantenimientoAeronave();
            data = (DataRowView)dataGridMant.SelectedItems[0];
            string id = data["Id"].ToString();
            int idMant = int.Parse(id);
            mantNave.IdMantenimiento = idMant;
            neMantenimientoAeronave.delMantenimiento(mantNave);
            System.Windows.MessageBox.Show("Mantenimiento Eliminado");
            dsMant = neMantenimiento.getMantenimientos(aeronave);
            dataGridMant.ItemsSource = new DataView(dsMant.Tables["listaMantenimientos"]);
            buttonBorrarMantenimiento.IsEnabled = false;
            buttonModificarMantenimiento.IsEnabled = false;
        }

        private void buttonModificarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            ModificarMantenimientoAeronave modificar = new ModificarMantenimientoAeronave();
            modificar.ShowDialog();
        }
    }
}
