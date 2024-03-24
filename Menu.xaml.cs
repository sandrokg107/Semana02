﻿using System;
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

namespace Semana2B
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OperacionesButton_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            this.Close();
            operaciones.ShowDialog();
        }

        private void MantenimientosButton_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            this.Close();
            mantenimiento.ShowDialog();
        }

        private void ReportesButton_Click(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Close();
            reportes.ShowDialog();
        }
    }
}
