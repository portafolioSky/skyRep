using MantenedoresCRUD.modelo;
using MantenedoresCRUD.negocio;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para InsertMantenimientoComponente.xaml
    /// </summary>
    public partial class InsertMantenimientoComponente : Window
    {
        private int idComp;
        private MantenimientoComponente mantComp = new MantenimientoComponente();
        private NeMantenimientoComponente neMantenimientoComponete = new NeMantenimientoComponente();
        private DataSet ds;
        private NeUsuario neUsuario;

        public InsertMantenimientoComponente()
        {
            InitializeComponent();
            fechaInspeccion.SelectedDate = DateTime.Now.Date;
            idComp = Sesion.GetValue<int>("idComp");
            textBoxIdComp.Text = idComp.ToString();
            neUsuario = new NeUsuario();
            ds = new DataSet();
            ds = neUsuario.getOperadores();
            comboBoxEncargado.DisplayMemberPath = "NOMBRE";
            comboBoxEncargado.SelectedValuePath = "RUT";
            comboBoxEncargado.ItemsSource = ds.Tables["operadores"].DefaultView;
        }

        private void buttonIngresarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            neMantenimientoComponete = new NeMantenimientoComponente();
            DateTime fechaSelect = new DateTime();
            fechaSelect = fechaInspeccion.SelectedDate.Value;
            mantComp.IdComponente = idComp;
            mantComp.FechaInspeccion = fechaSelect;
            mantComp.Estado = textBoxEstado.Text;
            if (comboBoxEncargado.Text == "Seleccione Operador")
            {
                MessageBox.Show("Seleccione un un operador");
            }
            else
            {

                mantComp.RutEncargado = comboBoxEncargado.SelectedValue.ToString();
                MessageBox.Show("Mantenimiento Ingresado");
                neMantenimientoComponete.insertMantenimientoComponente(mantComp);
                this.Close();
            }
        }
        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

