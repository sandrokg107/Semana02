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
    /// Lógica de interacción para Mantenimiento.xaml
    /// </summary>
    public partial class Mantenimiento : Window
    {

        public List<Conductor> Conductores { get; set; }
        public Mantenimiento()
        {
            InitializeComponent();

            Conductores = new List<Conductor>
            {
                new Conductor { Nombre = "Juan Pérez", Licencia = "123456", FechaExpedicion = DateTime.Now.AddDays(-100) },
                new Conductor { Nombre = "María López", Licencia = "789012", FechaExpedicion = DateTime.Now.AddDays(-200) },
                new Conductor { Nombre = "Pedro García", Licencia = "345678", FechaExpedicion = DateTime.Now.AddDays(-300) }
            };

            // Establecer la lista de conductores como contexto de datos de la ventana
            DataContext = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.ShowDialog();
        }

        public class Conductor
        {
            public string Nombre { get; set; }
            public string Licencia { get; set; }
            public DateTime FechaExpedicion { get; set; }
        }
    }
}
