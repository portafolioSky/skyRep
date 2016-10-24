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
    /// Lógica de interacción para ModificarMantenimientoComponente.xaml
    /// </summary>
    public partial class ModificarMantenimientoComponente : Window
    {
        private int idComp;
        private MantenimientoComponente mantComp = new MantenimientoComponente();
        private NeMantenimientoComponente neMantenimientoComponente = new NeMantenimientoComponente();
        private DataSet ds;
        private NeUsuario neUsuario;
        private int idMantComp;
        public ModificarMantenimientoComponente()
        {
            InitializeComponent();
            fechaInspeccion.SelectedDate = DateTime.Now.Date;
            idComp = Sesion.GetValue<int>("idComp");
            textBoxIdComponente.Text = idComp.ToString();
            neUsuario = new NeUsuario();
            ds = new DataSet();
            ds = neUsuario.getOperadores();
            comboBoxEncargado.DisplayMemberPath = "NOMBRE";
            comboBoxEncargado.SelectedValuePath = "RUT";
            comboBoxEncargado.ItemsSource = ds.Tables["operadores"].DefaultView;
            comboBoxEstado.Items.Add(new Item("PROGRAMADO", 1));
            comboBoxEstado.Items.Add(new Item("REALIZADO", 2));
        }
        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonModificarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            idMantComp = Sesion.GetValue<int>("idMantComp");
            neMantenimientoComponente = new NeMantenimientoComponente();
            DateTime fechaSelect = new DateTime();
            fechaSelect = fechaInspeccion.SelectedDate.Value;
            mantComp.IdMantenimiento = idMantComp;
            mantComp.IdComponente = idComp;
            mantComp.FechaInspeccion = fechaSelect;
            mantComp.Estado = comboBoxEstado.SelectedValue.ToString();
            if (comboBoxEncargado.Text == "Seleccione Operador")
            {
                MessageBox.Show("Seleccione un un operador");
            }
            else
            {
                mantComp.RutEncargado = comboBoxEncargado.SelectedValue.ToString();
                MessageBox.Show("Mantenimiento Modificado");
                neMantenimientoComponente.updateMantenimientoAeronave(mantComp);
                this.Close();
            }
        }
    }
}
