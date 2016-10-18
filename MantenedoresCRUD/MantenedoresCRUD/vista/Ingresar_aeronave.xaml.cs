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

        private void buttonSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Aeronave aeronve = new Aeronave();
            //Seleccionar tipo de aeronave
            if ((bool)radioButtonTipoAvion.IsChecked)
            {
                aeronve.TipoAeronave.NombreTipo="Avion";
            }
            if ((bool)radioButtonTipoHelicoptero.IsChecked)
            {
                aeronve.TipoAeronave.NombreTipo = "Helicoptero";
            }
            //tomar matricula
            aeronve.Matricula = textBoxMatricula.Text;
            //tomar marca
            aeronve.Marca = textBoxMarca.Text;
            //tomar modelo
            aeronve.Modelo = textBoxModelo.Text;
            //fecha fabricacion
            aeronve.FechaFabricacion = (DateTime)DatePickerFechaFabricacion.SelectedDate;
            //horas de vuelo
            aeronve.HorasVuelo = int.Parse(textBoxHorasVuelo.Text);
            //fecha emision certificado DGAC
            aeronve.CertificadoDgac = (DateTime)datePickerCertificado.SelectedDate;
            //fecha vencimiento DGAC
            aeronve.VencimientoDgac = (DateTime)datePickerVencimiento.SelectedDate;
            //dejar aeronave en sesion
            Sesion.SetValue("aeronave",aeronve);

            /*MessageBox.Show("tipo: " + aeronve.TipoAeronave +
                            "\nmatricula: " + aeronve.Matricula +
                            "\nmarca" + aeronve.Marca +
                            "\nmodelo" + aeronve.Modelo +
                            "\nFecha de fabricacion" + aeronve.FechaFabricacion.Date +
                            "\nHoras de vuelo" + aeronve.HorasVuelo +
                            "\nFecha certificado DGAC" + aeronve.CertificadoDgac +
                            "\nFecha vencimiento certificado DGAC" + aeronve.VencimientoDgac);*/
           
        }
    }
}
