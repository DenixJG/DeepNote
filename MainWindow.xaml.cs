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

        /// <summary>
        /// Muestra la ventana de <see cref="LoginView"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenLoginView(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show(); // Mostrar Login
            loginView.parent = this; // Indicamos el padre a la ventan LoginView
            this.Hide(); // Oculta la ventan padre, MainWindow
        }

        /// <summary>
        /// Muestra la ventana de <see cref="RegisterView"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenRegisterView(object sender, RoutedEventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show(); // Mostrar Registro
            registerView.parent = this; // Indicamos el padre a la ventan RegisterView
            this.Hide(); // Oculta la ventana padre, MainWindow
        }
    }
}
