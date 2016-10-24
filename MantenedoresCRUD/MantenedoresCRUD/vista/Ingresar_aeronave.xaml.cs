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
using MantenedoresCRUD.dao;
using MantenedoresCRUD.dataBase;
using MantenedoresCRUD.negocio;
using System.Data;

namespace MantenedoresCRUD.vista
{
    /// <summary>
    /// Interaction logic for Ingresar_aeronave.xaml
    /// </summary>
    public partial class Ingresar_aeronave : Window
    {
        private DataSet ds;
        private NeAeronave neAeronave;
        public Ingresar_aeronave()
        {
            InitializeComponent();
            //llenar el combobox
            ds = new DataSet();
            neAeronave = new NeAeronave();
            ds = neAeronave.getTipoAeronave();
            comboBoxTipo.DisplayMemberPath = "NOMBRE_TIPO";
            comboBoxTipo.SelectedValuePath = "ID_TIPO_AERONAVE";
            comboBoxTipo.ItemsSource = ds.Tables["listaTipoAeronave"].DefaultView;
            comboBoxTipo.SelectedIndex = comboBoxTipo.Items.Count - 1;
        }

        private void buttonSiguiente_Click(object sender, RoutedEventArgs e)
        {
            List<String> errores = new List<string>();
            //validar datos
            if (textBoxMatricula.Text == "")
            {
                errores.Add("La matricula es un dato obligatorio");
            }
            if (textBoxMarca.Text == "")
            {
                errores.Add("La marca es un dato obligatiorio");
            }
            if (textBoxModelo.Text == "")
            {
                errores.Add("El modelo es un dato obligatiorio");
            }
            int comparacion = DateTime.Compare(DateTime.Now, (DateTime)DatePickerFechaFabricacion.SelectedDate);
            if (comparacion < 0)
            {
                errores.Add("fecha de fabricacion tiene que ser anterior a la actual");
            }
            double dou;
            if (textBoxHorasVuelo.Text == "" && Double.TryParse(textBoxHorasVuelo.Text, out dou) == false)
            {
                errores.Add("El formato de las horas de vuelo no es el correcto");
            }
            comparacion = DateTime.Compare(DateTime.Now, (DateTime)datePickerCertificado.SelectedDate);
            if (comparacion < 0)
            {
                errores.Add("fecha de certificado tiene que ser anterior a la actual");
            }
            comparacion = DateTime.Compare((DateTime)datePickerCertificado.SelectedDate, (DateTime)datePickerVencimiento.SelectedDate);
            if (comparacion > 0)
            {
                errores.Add("fecha de vencimiento tiene que ser posterior a fecha de certificado");
            }

            if (errores.Count != 0)
            {
                string mensaje = "tiene los siguientes errores: ";
                foreach (string me in errores)
                {
                    mensaje = mensaje + "\n"+me;
                }
                MessageBox.Show(mensaje);
                return;
                
            }

            Aeronave aeronve = new Aeronave();
            //Seleccionar tipo de aeronave
            aeronve.TipoAeronave.IdTipo = int.Parse(comboBoxTipo.SelectedValue.ToString());
            //tomar matricula
            aeronve.Matricula = textBoxMatricula.Text;
            //tomar marca
            aeronve.Marca = textBoxMarca.Text;
            //tomar modelo
            aeronve.Modelo = textBoxModelo.Text;
            //fecha fabricacion
            aeronve.FechaFabricacion = (DateTime)DatePickerFechaFabricacion.SelectedDate;
            //horas de vuelo
            aeronve.HorasVuelo = double.Parse(textBoxHorasVuelo.Text);
            //fecha emision certificado DGAC
            aeronve.CertificadoDgac = (DateTime)datePickerCertificado.SelectedDate;
            //fecha vencimiento DGAC
            aeronve.VencimientoDgac = (DateTime)datePickerVencimiento.SelectedDate;
            //dejar aeronave en sesion
            Sesion.SetValue("aeronave",aeronve);
            //ingresar aeronave
            neAeronave = new NeAeronave();
            neAeronave.insertAeronave(aeronve);
            //revizar si se ingresó
            int res = neAeronave.aeronaveExiste(aeronve);

            if (res != 1)
            {
                MessageBox.Show("Error durante el ingreso");
            }
            else
            {
                Ingresar_aeronave_componentes componentes = new Ingresar_aeronave_componentes();
                componentes.ShowDialog();
            }
            this.Close();
            /**MessageBox.Show("tipo: " + aeronve.TipoAeronave.IdTipo +
                            "\nmatricula: " + aeronve.Matricula +
                            "\nmarca" + aeronve.Marca +
                            "\nmodelo" + aeronve.Modelo +
                            "\nFecha de fabricacion" + aeronve.FechaFabricacion.Date +
                            "\nHoras de vuelo" + aeronve.HorasVuelo +
                            "\nFecha certificado DGAC" + aeronve.CertificadoDgac +
                            "\nFecha vencimiento certificado DGAC" + aeronve.VencimientoDgac);**/
           
        }
    }
}
