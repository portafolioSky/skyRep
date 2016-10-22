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
using System.Globalization;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Lógica de interacción para Modulo_Administrador.xaml
    /// </summary>
    public partial class Modulo_Administrador : Window
    {
        private Usuario usuario;
        private Usuario usuarioM;
        private NePerfil nePerfil = new NePerfil();
        private NeUsuario neUsuario = new NeUsuario();
        private DataSet ds = new DataSet();
        public Modulo_Administrador(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            labelSaludo.Content = "HOLA " + usuario.NombreCompleto().ToUpper();

            gridDetalles.Visibility = Visibility.Hidden;
            gridOpciones.Visibility = Visibility.Hidden;
            gridIngresar.Visibility = Visibility.Hidden;
            gridEliminar.Visibility = Visibility.Hidden;
            gridModificar.Visibility = Visibility.Hidden;


            ds = new DataSet();
            ds = nePerfil.getPerfil();
            comboBoxRol.DisplayMemberPath = "NOMBRE_ROL";
            comboBoxRol.SelectedValuePath = "NOMBRE_ROL";
            comboBoxRol.ItemsSource = ds.Tables["rolSelect"].DefaultView;

            comboBoxRolModificar.DisplayMemberPath = "NOMBRE_ROL";
            comboBoxRolModificar.SelectedValuePath = "ID_ROL";
            comboBoxRolModificar.ItemsSource = ds.Tables["rolSelect"].DefaultView;

            comboBoxIngresarRol.DisplayMemberPath = "NOMBRE_ROL";
            comboBoxIngresarRol.SelectedValuePath = "ID_ROL";
            comboBoxIngresarRol.ItemsSource = ds.Tables["rolSelect"].DefaultView;
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void buttonLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            buttonDetalle.Visibility = Visibility.Hidden;
            buttonDetalle.IsEnabled = false;
            buttonActualizar.Visibility = Visibility.Hidden;
            gridModificar.Visibility = Visibility.Hidden;
            usuario.Rut = textBoxRut.Text;
            usuario.RolUsuario.Nombre = comboBoxRol.Text;

            ds = neUsuario.getUsuario(usuario);
            dataGridUsuario.ItemsSource = new DataView(ds.Tables["usuarioLista"]);
        }

        private void buttonIngresarUsuario_Click(object sender, RoutedEventArgs e)
        {
            gridIngresar.Visibility = Visibility.Visible;
            gridDetalles.Visibility = Visibility.Hidden;
            gridModificar.Visibility = Visibility.Hidden;
            gridOpciones.Visibility = Visibility.Hidden;
        }

        private void buttoonCerrarForm_Click(object sender, RoutedEventArgs e)
        {
            dataGridUsuario.ItemsSource = null;
            gridIngresar.Visibility = Visibility.Hidden;
            gridOpciones.Visibility = Visibility.Hidden;
            textBoxIngresarRut.Text = "";
            textBoxIngresarNombre.Text = "";
            textBoxIngresarApPaterno.Text = "";
            textBoxIngresarApMaterno.Text = "";
            textBoxIngresarCorreo.Text = "";
            textBoxIngresarUsuario.Text = "";
            passwordBoxIngresar.Password = "";
            passwordBoxIngresar2.Password = "";
            comboBoxIngresarRol.Text = "";


        }

        private void buttonVerUsuario_Click(object sender, RoutedEventArgs e)
        {
            gridIngresar.Visibility = Visibility.Hidden;
            gridOpciones.Visibility = Visibility.Visible;
            usuario.Rut = textBoxRut.Text;
            usuario.RolUsuario.Nombre = comboBoxRol.Text;

            ds = neUsuario.getUsuario(usuario);
            dataGridUsuario.ItemsSource = new DataView(ds.Tables["usuarioLista"]);
            textBoxIngresarRut.Text = "";
            textBoxIngresarNombre.Text = "";
            textBoxIngresarApPaterno.Text = "";
            textBoxIngresarApMaterno.Text = "";
            textBoxIngresarCorreo.Text = "";
            textBoxIngresarUsuario.Text = "";
            passwordBoxIngresar.Password = "";
            passwordBoxIngresar2.Password = "";
            comboBoxIngresarRol.Text = "";

        }

        private void dataGridUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridOpciones.Visibility = Visibility.Visible;
            buttonDetalle.IsEnabled = true;


        }

        private void buttonDetalle_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                DataRowView row = (DataRowView)dataGridUsuario.SelectedItems[0];
                labelRut.Content = row["Rut"].ToString();
                labelNombre.Content = row["Nombre"].ToString();
                labelApPaterno.Content = row["Apellido Paterno"].ToString();
                labelAmaterno.Content = row["Apellido Materno"].ToString();
                labelUsuario.Content = row["Nombre de Usuario"].ToString();
                labelCorreo.Content = row["E-Mail"].ToString();
                labelRol.Content = row["Rol del Usuario"].ToString();

                usuario = new Usuario(row["Rut"].ToString(), row["Nombre"].ToString(), row["Apellido Paterno"].ToString(), 
                row["Apellido Materno"].ToString(), row["Nombre de Usuario"].ToString(), row["E-Mail"].ToString(), 
                row["Rol del Usuario"].ToString());

                gridDetalles.Visibility = Visibility.Visible;

            }
            catch (Exception)
            {
                MessageBox.Show("Sin Selección");
            }

        }

        private void buttonCerrarDetalle_Click(object sender, RoutedEventArgs e)
        {
            gridModificar.Visibility = Visibility.Hidden;
            gridDetalles.Visibility = Visibility.Hidden;

        }

        private void buttonActualizar_Click(object sender, RoutedEventArgs e)
        {
            gridModificar.Visibility = Visibility.Visible;

            textBoxNombre.Text = labelNombre.Content.ToString();
            textBoxApellidoP.Text = labelApPaterno.Content.ToString();
            textBoxApellidoM.Text = labelAmaterno.Content.ToString();
            textBoxUser.Text = labelUsuario.Content.ToString();
            textBoxCorreo.Text = labelCorreo.Content.ToString();
            comboBoxRolModificar.Text = labelRol.Content.ToString();

        }

        private void comboBoxRol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridDetalles.Visibility = Visibility.Hidden;
            gridModificar.Visibility = Visibility.Hidden;
            gridIngresar.Visibility = Visibility.Hidden;

            usuario.Rut = textBoxRut.Text;
            usuario.RolUsuario.Nombre = comboBoxRol.SelectedValue.ToString();

            ds = neUsuario.getUsuario(usuario);
            dataGridUsuario.ItemsSource = new DataView(ds.Tables["usuarioLista"]);
        }

        private void buttonAceptar_Click(object sender, RoutedEventArgs e)
        {
            string d = comboBoxRolModificar.Text;

            RolUsuario rol = new RolUsuario();
            rol.Id_rol = Convert.ToInt16(comboBoxRolModificar.SelectedValue.ToString());
            rol.Nombre = comboBoxRolModificar.Text;
            usuarioM = new Usuario(usuario.Rut, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxNombre.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxApellidoP.Text), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxApellidoM.Text), 
                 (textBoxUser.Text).ToLower(), (textBoxCorreo.Text).ToLower(), rol);

            if (usuario.ToString().Equals(usuarioM.ToString()))
            {
                MessageBox.Show("No hay ninguna modificación");
            }
            else {
                int resp = neUsuario.modificarUsuario(usuarioM);

                switch (resp)
                {
                    case -1:
                        MessageBox.Show("No se a podido modificar la información");
                        break;
                    case -2:
                        MessageBox.Show("No se permiten datos vacios");
                        break;
                    case 0:
                        MessageBox.Show("Usuario modificado");
                        gridDetalles.Visibility = Visibility.Hidden;
                        gridModificar.Visibility = Visibility.Hidden;
                        ds = neUsuario.getUsuario(usuario);
                        dataGridUsuario.ItemsSource = new DataView(ds.Tables["usuarioLista"]);
                        break;
                }
            }

        }

        private void buttonPass_Click(object sender, RoutedEventArgs e)
        {
            Cambio_pass cambiopass = new Cambio_pass(usuario);
            cambiopass.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, RoutedEventArgs e)
        {
            labelEliminar.Content = string.Format("Desea desactivar al usuario {0}?",usuario.User);
            gridEliminar.Visibility = Visibility.Visible;
        }

        private void buttonEliminarCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridEliminar.Visibility = Visibility.Hidden;
        }

        private void buttonEliminarAceptar_Click(object sender, RoutedEventArgs e)
        {
            int resp = neUsuario.desactivarUsuario(usuario);

            switch (resp)
            {
                case -1:
                    MessageBox.Show("Usuario ya se encuentra desactivo");
                    gridEliminar.Visibility = Visibility.Hidden;
                    break;
                case -2:
                    MessageBox.Show("No cuenta con privilegios para desactivar a este tipo de usuario");
                    gridEliminar.Visibility = Visibility.Hidden;
                    break;
                case 0:
                    gridEliminar.Visibility = Visibility.Hidden;
                    ds = neUsuario.getUsuario(usuario);
                    dataGridUsuario.ItemsSource = new DataView(ds.Tables["usuarioLista"]);
                    break;
            }
        }

        private void buttoonIngresarUsuario_Click(object sender, RoutedEventArgs e)
        {

            try {
                Usuario usuarioIngresar = new Usuario();
                usuario.Rut = textBoxIngresarRut.Text;
                usuario.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxIngresarNombre.Text);
                usuario.ApPaterno = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxIngresarApPaterno.Text);
                usuario.ApMaterno = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBoxIngresarApMaterno.Text);
                usuario.Correo = (textBoxIngresarCorreo.Text).ToLower();
                usuario.User = (textBoxIngresarNombre.Text).ToLower();
                usuario.RolUsuario.Id_rol = Convert.ToInt16(comboBoxIngresarRol.SelectedValue.ToString());
                usuario.RolUsuario.Nombre = comboBoxIngresarRol.Text;
                usuario.Password = passwordBoxIngresar.Password;
                string pass2 = passwordBoxIngresar2.Password;

                int resp = neUsuario.ingresarUsuario(usuario, pass2);

                switch (resp)
                {
                    case -1:
                        MessageBox.Show("El rut ingresado ya se encuentra ingresado");
                        break;
                    case -2:
                        MessageBox.Show("Complete todos los datos solicitados");
                        break;
                    case -3:
                        MessageBox.Show("Las credenciales proporcionadas no coinciden");
                        break;
                    case -4:
                        MessageBox.Show("Rut invalido");
                        break;
                    case 0:
                        MessageBox.Show("Usuario ingresado con exito");
                        gridIngresar.Visibility = Visibility.Hidden;
                        gridEliminar.Visibility = Visibility.Hidden;
                        ds = neUsuario.getUsuario(usuario);
                        dataGridUsuario.ItemsSource = new DataView(ds.Tables["usuarioLista"]);
                        textBoxIngresarRut.Text = "";
                        textBoxIngresarNombre.Text = "";
                        textBoxIngresarApPaterno.Text = "";
                        textBoxIngresarApMaterno.Text = "";
                        textBoxIngresarCorreo.Text = "";
                        textBoxIngresarUsuario.Text = "";
                        passwordBoxIngresar.Password = "";
                        passwordBoxIngresar2.Password = "";
                        comboBoxIngresarRol.Text = "";
                        break;
                }
            }
            catch (Exception) { }
        }

    }
}
