using DeepNote.Views.Login;
using DeepNote.Views.Register;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeepNote
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenLoginView(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show(); // Mostrar Login
            this.Close(); // Cerrar padre
        }

        private void OpenRegisterView(object sender, RoutedEventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show();
            this.Close();
        }
    }
}
