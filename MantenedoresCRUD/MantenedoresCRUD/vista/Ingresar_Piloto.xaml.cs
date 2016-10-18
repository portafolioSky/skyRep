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
using MantenedoresCRUD.negocio;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para Ingresar_Piloto.xaml
    /// </summary>
    public partial class Ingresar_Piloto : Window
    {

        private Usuario piloto;
        private NePiloto nePiloto = new NePiloto();
        private DataSet ds = new DataSet();

        public Ingresar_Piloto()
        {
            InitializeComponent();

            nePiloto = new NePiloto();
            ds = new DataSet();
            ds = nePiloto.getTipoPilotoAll();
            comboBoxTipoLicencia.DisplayMemberPath = "NOMBRE";
            comboBoxTipoLicencia.SelectedValuePath = "ID_TIPO_LICENCIA";
            comboBoxTipoLicencia.ItemsSource = ds.Tables["piloto_tipoAll"].DefaultView;
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
