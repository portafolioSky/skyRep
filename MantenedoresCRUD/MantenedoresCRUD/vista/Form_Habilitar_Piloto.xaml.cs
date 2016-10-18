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
    /// Lógica de interacción para Form_Habilitar_Piloto.xaml
    /// </summary>
    public partial class Form_Habilitar_Piloto : Window
    {
        private Usuario piloto = new Usuario();
        private NePiloto nePiloto = new NePiloto();
        private DataSet ds = new DataSet();
        HabilitarPiloto habilitarP = new HabilitarPiloto();
        public Form_Habilitar_Piloto(HabilitarPiloto habilitarPiloto, Usuario usuario)
        {
            InitializeComponent();

            piloto = usuario;
            habilitarP = habilitarPiloto;

            labelRut.Content = piloto.Rut;
            labelNombre.Content = piloto.Nombre;


            nePiloto = new NePiloto();
            ds = new DataSet();
            ds = nePiloto.getTipoPilotoAll();
            comboBoxipoLicencia.DisplayMemberPath = "NOMBRE";
            comboBoxipoLicencia.SelectedValuePath = "ID_TIPO_LICENCIA";
            comboBoxipoLicencia.ItemsSource = ds.Tables["piloto_tipoAll"].DefaultView;
            Console.Write("!!"+ usuario.Licencia.FechaExpiracion);
            if(piloto.Licencia.TipoLicencia.NombreLicencia !=null) comboBoxipoLicencia.Text = piloto.Licencia.TipoLicencia.NombreLicencia;
            if (usuario.Licencia.FechaEmision.ToString("dd'/'MM'/'yyyy") != "01/01/0001") fechaEmisionLicencia.Text = piloto.Licencia.FechaEmision.ToString();
            if (usuario.Licencia.FechaExpiracion.ToString("dd'/'MM'/'yyyy") != "01/01/0001") fechaVencimientoLicencia.Text = piloto.Licencia.FechaExpiracion.ToString();
            if (piloto.FechaMeAeroespacial.ToString("dd'/'MM'/'yyyy") != "01/01/0001") fechaVencMedicina.Text = piloto.FechaMeAeroespacial.ToString();

        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void emiLicencia_SelectedDateChanged(object sender, EventArgs e)
        {

            DateTime now = DateTime.Today;


            if(fechaEmisionLicencia.SelectedDate.Value <= now)
                imageLicenciaEmi.Source = new BitmapImage(new Uri(@"Resources/Correcto.png", UriKind.Relative));
            else imageLicenciaEmi.Source = null;

        }

        private void venLicencia_SelectedDateChanged(object sender, EventArgs e)
        {

            DateTime now = DateTime.Today;


            if (fechaVencimientoLicencia.SelectedDate.Value > now)
            {

                TimeSpan ts =  fechaVencimientoLicencia.SelectedDate.Value - fechaEmisionLicencia.SelectedDate.Value;

                if (ts.Days >= 365)
                {
                    imageLicenciaVen.Source = new BitmapImage(new Uri(@"Resources/Correcto.png", UriKind.Relative));
                }

                else {
                    MessageBox.Show("Vencimiento debe tener una vigencia min de un año");
                    imageLicenciaVen.Source = null;
                     }
            }

        }

        private void venMedicina_SelectedDateChanged(object sender, EventArgs e)
        {

            DateTime now = DateTime.Today;


            if (fechaVencMedicina.SelectedDate.Value > now)
                imageMEdicinaVEn.Source = new BitmapImage(new Uri(@"Resources/Correcto.png", UriKind.Relative));
            else imageMEdicinaVEn.Source = null;


        }

        private void buttonAceptar_Click(object sender, RoutedEventArgs e)
        {
            piloto.Licencia.TipoLicencia.IdTipoLIcencia = Convert.ToInt16(comboBoxipoLicencia.SelectedValue.ToString());
            piloto.Licencia.FechaEmision = fechaEmisionLicencia.SelectedDate.Value;
            piloto.Licencia.FechaExpiracion = fechaVencimientoLicencia.SelectedDate.Value;
            piloto.Licencia.Estado1 = 't';
            piloto.FechaMeAeroespacial = fechaVencMedicina.SelectedDate.Value;
            nePiloto.updatePiloto(piloto);
            habilitarP.recargarLista();
            this.Close();
        }
    }
}
