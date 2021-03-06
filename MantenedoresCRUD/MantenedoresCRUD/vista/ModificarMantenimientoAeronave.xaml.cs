﻿using MantenedoresCRUD.modelo;
using MantenedoresCRUD.negocio;
using System;
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
    /// Lógica de interacción para ModificarMantenimientoAeronave.xaml
    /// </summary>
    public partial class ModificarMantenimientoAeronave : Window
    {
        private string matricula;
        private MantenimientoAeronave mantNave = new MantenimientoAeronave();
        private NeMantenimientoAeronave neMantenimientoAeronave = new NeMantenimientoAeronave();
        private DataSet ds;
        private NeUsuario neUsuario;
        private int idMant = 0;
        public ModificarMantenimientoAeronave()
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
            comboBoxEstado.Items.Add(new Item("PROGRAMADO", 1));
            comboBoxEstado.Items.Add(new Item("REALIZADO", 2));
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonModificarMantenimiento_Click(object sender, RoutedEventArgs e)
        {
            idMant = Sesion.GetValue<int>("idMant");
            neMantenimientoAeronave = new NeMantenimientoAeronave();
            DateTime fechaSelect = new DateTime();
            fechaSelect = fechaInspeccion.SelectedDate.Value;
            mantNave.IdMantenimiento = idMant;
            mantNave.Matricula = matricula;
            mantNave.Ispecccion = fechaSelect;
            mantNave.Estado = comboBoxEstado.SelectedValue.ToString();
            if (comboBoxEncargado.Text == "Seleccione Operador")
            {
                MessageBox.Show("Seleccione un un operador");
            }
            else
            {
                mantNave.RutUsuario = comboBoxEncargado.SelectedValue.ToString();
                MessageBox.Show("Mantenimiento Modificado");
                neMantenimientoAeronave.updateMantenimientoAeronave(mantNave);
                this.Close();
            }
        }
    }
}
