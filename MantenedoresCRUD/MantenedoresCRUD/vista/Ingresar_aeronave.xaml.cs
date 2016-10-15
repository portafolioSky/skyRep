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

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Interaction logic for Ingresar_aeronave.xaml
    /// </summary>
    public partial class Ingresar_aeronave : Window
    {
        public Ingresar_aeronave()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            //tomar datos del check
            String tipo="no seleccionado";
            String matricula;
            String marca;
            DateTime certificado;
            DateTime vencimiento;
            if ((bool)radioButtonAvion.IsChecked)
            {
                tipo = "avion";
            }
            if ((bool)radioButtonHelicoptero.IsChecked)
            {
                tipo = "helicoptero";
            }

            //tomar los demás datos
            matricula = textBoxMatricula.Text;
            marca = textBoxMarca.Text;
            certificado=fechaCertificado.DisplayDate;
            vencimiento = fechaVencimiento.DisplayDate;

            //dejar datos en sesion
            Sesion.SetValue("tipo", tipo);
            Sesion.SetValue("matricula", matricula);
            Sesion.SetValue("marca", marca);
            Sesion.SetValue("certificado", certificado);
            Sesion.SetValue("vencimiento", vencimiento);

            String tipo2 = Sesion.GetValue<String>("tipo");

            MessageBox.Show(
                "tipo :"+tipo2+
                "\nmatricula: "+matricula+
                "\nMarca: "+marca+
                "\nCertificado: "+certificado.ToString()+
                "\nVencimiento: "+vencimiento.ToString());
        }
    }
}
