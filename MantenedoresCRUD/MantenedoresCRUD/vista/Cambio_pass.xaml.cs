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
    /// Lógica de interacción para Cambio_pass.xaml
    /// </summary>
    public partial class Cambio_pass : Window
    {
        Usuario user = new Usuario();
        public Cambio_pass(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string pass1 = passwordBox1.Password;
            string pass2 = passwordBox2.Password;
            NeUsuario neUsuario = new NeUsuario();
            int resp = neUsuario.cambioPass(user, pass1, pass2);
            switch (resp)
            {
                case -1:
                    MessageBox.Show("Imposible con datos vacios");
                    break;
                case -2:
                    MessageBox.Show("No coinciden las credenciales proporcionadas");
                    break;
                case -3:
                    MessageBox.Show("Error al cambiar la password del usuario " + user.User);
                    break;
                case 0:
                    MessageBox.Show("Exito al cambiar la password");
                    this.Close();
                    break;
            }
        }
    }
}
