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

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para VerLicencia.xaml
    /// </summary>
    public partial class VerLicencia : Window
    {
        public VerLicencia(Usuario piloto)
        {
            InitializeComponent();
            labelRut.Content = piloto.Rut;
            labelNombre.Content = piloto.Nombre;
            labelTipo.Content = piloto.Licencia.TipoLicencia.NombreLicencia;
            labelExpira.Content = piloto.Licencia.FechaExpiracion.ToString("dd'/'MM'/'yyyy");
            labeEmision.Content = piloto.Licencia.FechaEmision.ToString("dd'/'MM'/'yyyy");

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
