﻿using MantenedoresCRUD.modelo;
using MantenedoresCRUD.negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para InsertMantenimientoAeronave.xaml
    /// </summary>
    public partial class InsertMantenimientoAeronave : Window
    {
        private string matricula;
        private MantenimientoAeronave mantNave;
        private NeMantenimientoAeronave neMantenimientoAeronave = new NeMantenimientoAeronave();
        private DataSet ds;
        private NeUsuario neUsuario;
        


        public InsertMantenimientoAeronave()
        {
            
            InitializeComponent();
            fechaInspeccion.SelectedDate = DateTime.Now.Date;
            matricula = Sesion.GetValue<string>("Matricula");
            textBoxMatricula.Text = matricula;
            neUsuario = new NeUsuario();
            ds = new DataSet();
            ds = neUsuario.getOperadores();
            comboBoxEncargado.DisplayMemberPath = "NOMBRE";
            comboBoxEncargado.SelectedValuePath = "RUT";
            comboBoxEncargado.ItemsSource = ds.Tables["operadores"].DefaultView;
            
            
            
        }

        private void buttonIngresarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            
          
            mantNave = new MantenimientoAeronave();
            neMantenimientoAeronave = new NeMantenimientoAeronave();
            DateTime fechaSelect = new DateTime();
            fechaSelect = fechaInspeccion.SelectedDate.Value;
            mantNave.Matricula = matricula;
            mantNave.Ispecccion = fechaSelect;
            mantNave.Estado = textBoxEstado.Text;
            if (comboBoxEncargado.Text == "Seleccione Operador")
            {
                MessageBox.Show("Seleccione un un operador");
            }
            else
            {
                mantNave.RutUsuario = comboBoxEncargado.SelectedValue.ToString();
                MessageBox.Show("Mantenimiento Ingresado");
                neMantenimientoAeronave.insertMantenimientoAeronave(mantNave);
                this.Close();
            }
           
            //if (mantNave.Ispecccion < DateTime.Now)
            //  {
            //    MessageBox.Show("Seleccione una fecha mayor a la actual");
            //  }
            //else
            //  {
               
              //}         
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
