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
    /// Interaction logic for Ingresar_aeronave_componentes_nuevo.xaml
    /// </summary>
    public partial class Ingresar_aeronave_componentes_nuevo : Window
    {
        private NeComponente neComponente;
        private DataSet ds;
        int padre = 0;
        Ingresar_aeronave_componentes comp = new Ingresar_aeronave_componentes();
        public Ingresar_aeronave_componentes_nuevo(Ingresar_aeronave_componentes ne)
        {
            InitializeComponent();
            comp = ne;
            //llenar datagrid con componentes
            Aeronave aeronave = new Aeronave();
            aeronave.Matricula = Sesion.GetValue<Aeronave>("aeronave").Matricula;
            //Aeronave aeronave = Sesion.GetValue<Aeronave>("aeronave");
            neComponente = new NeComponente();
            ds = neComponente.getComponentes(aeronave);
            dataGridComponentePadre.ItemsSource = new DataView(ds.Tables["listaComponentes"]);
        }

        private void buttonAgregar_Click(object sender, RoutedEventArgs e)
        {
            Componente componente = new Componente();
            //datos del usuario
            componente.Nombre=textBoxNombre.Text;
            componente.HorasVuelo = float.Parse(textBoxHorasVuelo.Text);
            componente.LimiteHorasVuelo = float.Parse(textBoxLimiteHoras.Text);
            componente.FechaVencimiento = (DateTime)datePickerFechaVencimiento.SelectedDate;
            //datos automaticos
            componente.MatriculaAeronave = Sesion.GetValue<Aeronave>("aeronave").Matricula;
            componente.Estado = "NO OPERATIVO";
            componente.IdPadre = padre;

            //obtener ultimo id
            neComponente = new NeComponente();
            int ultimo = neComponente.ultimoID();
            ultimo = ultimo + 1;
            componente.IdComponente = ultimo;
            //correr procedimiento de ingreso
            int resultado = neComponente.IngresarComponente(componente);
            if (resultado == 1)
            {
                MessageBox.Show("Componente ingresado");
            }
            else
            {
                MessageBox.Show("NO se ingreso el componente");
            }
            this.Close();
            comp.actualizar();


            /*MessageBox.Show(
                "id: " + componente.IdComponente+
                "\nnombre: " + componente.Nombre +
                "\nHoras de vuelo: " + componente.HorasVuelo +
                "\nLimite de horas: " + componente.LimiteHorasVuelo +
                "\nFecha de vencimiento: " + componente.FechaVencimiento +
                "\nMatricula: " + componente.MatriculaAeronave +
                "\nEstado: " + componente.Estado+
                "\nId padre: "+componente.IdPadre
                );*/
        }

        private void buttonSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dataGridComponentePadre.SelectedItems[0];
            padre = int.Parse(row["Id Componente"].ToString());
            MessageBox.Show(padre.ToString());
        }
    }
}
