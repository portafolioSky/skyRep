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

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para Modulo_Operador.xaml
    /// </summary>
    public partial class Modulo_Operador : Window
    {
        private Usuario usuario = new Usuario();
        public Modulo_Operador(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            labelSaludo.Content = "HOLA " + usuario.NombreCompleto().ToUpper();
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CHECK
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void buttonMininizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void buttonIngresarVuelo_Click(object sender, RoutedEventArgs e)
        {
            Ingresar_vuelo ingresarVuelo = new Ingresar_vuelo();
            ingresarVuelo.ShowDialog();

        }
    }
}
