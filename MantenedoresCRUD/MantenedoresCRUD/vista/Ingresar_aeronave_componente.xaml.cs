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
using System.Data;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Interaction logic for Ingresar_aeronave_componente.xaml
    /// </summary>
    public partial class Ingresar_aeronave_componente : Window
    {

        private int padre = -1;
        public Ingresar_aeronave_componente()
        {
            InitializeComponent();
            if (Sesion.GetValue<List<Componente>>("componentes") != null)
            {
                List<Componente> componentes = Sesion.GetValue<List<Componente>>("componentes");
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = componentes;
            }
            else
            {
                //no hay lista
            }
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonIngresar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = textBoxNombre.Text;
            DateTime? vencimiento = fechaVencimiento.SelectedDate;
            DateTime? fabricacion = FechaFabricacion.SelectedDate;

            int i = 1;
            if (int.TryParse(textBoxHorasVuelo.Text, out i) && int.TryParse(textBoxLimiteHoras.Text, out i))
            {
                float horasVuelo = float.Parse(textBoxHorasVuelo.Text);
                float limite = float.Parse(textBoxLimiteHoras.Text);
                int idPadre = 0;

                Componente componente = new Componente();
                componente.Nombre = nombre;
                componente.FechaVencimiento = (DateTime)vencimiento;
                componente.HorasVuelo = horasVuelo;
                componente.LimiteHorasVuelo = limite;
                componente.FechaFabricacion = (DateTime)fabricacion;
                componente.IdPadre = idPadre;
                List<Componente> componentes;

                if (Sesion.GetValue<List<Componente>>("componentes") != null)
                {
                    componentes = Sesion.GetValue<List<Componente>>("componentes");
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = componentes;
                }
                else
                {
                    componentes = new List<Componente>();
                }

                componentes.Add(componente);

                Sesion.SetValue("componentes", componentes);

                MessageBox.Show("Componente agregado");
                this.Close();

                //MessageBox.Show("Componente agregado");

                /*foreach (Componente value in componentes)
                {
                    MessageBox.Show("nombre: " + value.Nombre +
                            "\nvencimiento: " + value.FechaVencimiento +
                            "\nfabricacion: " + value.FechaFabricacion +
                            "\nhoras de vuelo: " + value.HorasVuelo +
                            "\nlimite de horas de vuelo" + value.LimiteHorasVuelo +
                            "\nid: padre" + idPadre);
                }*/

            }
            else
            {
                MessageBox.Show("Uno de los valores ingresados no es un numero");
            }
        }

        private void buttonSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            Componente row = (Componente)dataGrid.SelectedItems[0];
            List<Componente> componentes = Sesion.GetValue<List<Componente>>("componentes");
            int i = -1;
            foreach (Componente comp in componentes)
            {
                i++;
                if (comp.Equals(row))
                {
                    padre = i;
                }
            }

        }
    }
}
