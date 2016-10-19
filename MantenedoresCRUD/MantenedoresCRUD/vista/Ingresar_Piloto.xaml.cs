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
using System.Globalization;

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

        private void buttonAceptar_Click(object sender, RoutedEventArgs e)
        {
            
            piloto = new Usuario();
            piloto.Rut = textBoxRut.Text;
            piloto.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxNombre.Text);
            piloto.ApPaterno = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxAPaterno.Text);
            piloto.ApMaterno = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxAMaterno.Text);
            piloto.Correo = textBoxCorreo.Text;
            piloto.User = textBoxUser.Text;
            piloto.Password = textBoxPassword.Text;
            piloto.FechaMeAeroespacial = Convert.ToDateTime(fechaVecnMedicina.SelectedDate.ToString());
            piloto.Licencia.FechaEmision = Convert.ToDateTime(fechaEmisionLicencia.SelectedDate.ToString());
            piloto.Licencia.FechaExpiracion = Convert.ToDateTime(fechaVenclicencia.SelectedDate.ToString());
            piloto.Licencia.TipoLicencia.IdTipoLIcencia = Convert.ToInt16(comboBoxTipoLicencia.SelectedValue.ToString());
            int n = nePiloto.ingresarPiloto(piloto);
        }

       
    }
}
