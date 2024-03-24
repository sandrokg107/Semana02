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

namespace Semana2B
{
    /// <summary>
    /// Lógica de interacción para Reportes.xaml
    /// </summary>
    public partial class Reportes : Window
    {
        private List<Salida> _salidas;

        public Reportes()
        {
            InitializeComponent();
            // Cargar datos de prueba
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            _salidas = new List<Salida>
            {
                new Salida { Fecha = DateTime.Now, Peso = 100, TipoAuto = "Auto1", NombreTransportista = "Transportista1", PesoIngreso = 50, PesoSalida = 100, FechaYHora = DateTime.Now },
                new Salida { Fecha = DateTime.Now.AddDays(-1), Peso = 200, TipoAuto = "Auto2", NombreTransportista = "Transportista2", PesoIngreso = 150, PesoSalida = 200, FechaYHora = DateTime.Now.AddDays(-1) },
                new Salida { Fecha = DateTime.Now.AddDays(-2), Peso = 300, TipoAuto = "Auto3", NombreTransportista = "Transportista3", PesoIngreso = 250, PesoSalida = 300, FechaYHora = DateTime.Now.AddDays(-2) }
            };

            // Asignar la lista de salidas al DataGrid
            SalidasDataGrid.ItemsSource = _salidas;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtener las fechas seleccionadas en los DatePickers
            DateTime fechaInicio = startDatePicker.SelectedDate ?? DateTime.MinValue;
            DateTime fechaFin = endDatePicker.SelectedDate ?? DateTime.MaxValue;

            // Filtrar las salidas basadas en las fechas seleccionadas
            var salidasFiltradas = _salidas.Where(salida => salida.Fecha >= fechaInicio && salida.Fecha <= fechaFin).ToList();

            // Asignar las salidas filtradas al DataGrid
            SalidasDataGrid.ItemsSource = salidasFiltradas;
        }

        private void VolverButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.ShowDialog();
        }

        public class Salida
        {
            public DateTime Fecha { get; set; }
            public int Peso { get; set; }
            public string TipoAuto { get; set; }
            public string NombreTransportista { get; set; }
            public int PesoIngreso { get; set; }
            public int PesoSalida { get; set; }
            public DateTime FechaYHora { get; set; }
        }
    }
}

