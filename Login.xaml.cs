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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Verificar las credenciales de usuario
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (IsLoginValid(username, password))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Aquí puedes abrir la nueva ventana o realizar otras acciones después del inicio de sesión exitoso
                Menu menu = new Menu();
                this.Close();
                menu.ShowDialog();

                
            }
            else
            {
                // Mostrar un mensaje de error si las credenciales son incorrectas
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
                ErrorMessageTextBlock.Text = "Usuario o contraseña incorrectos";
            }
        }

        private bool IsLoginValid(string username, string password)
        {
            // Aquí puedes implementar tu propia lógica de autenticación, como consultar una base de datos, etc.
            // Este es solo un ejemplo simulado
            return username == "usuario" && password == "contraseña";
        }
    }
}
