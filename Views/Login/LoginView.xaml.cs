using DeepNote.Controllers;
using DeepNote.Models;
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
using System.Windows.Shapes;

namespace DeepNote.Views.Login
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public Window parent { get; set; }
        public UserController userController;

        public LoginView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close current window and show the parent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseWindowOnEscape(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                MessageBoxResult dialog = MessageBox.Show("Deseas salir ?", "Salir", MessageBoxButton.YesNo);
                if (dialog == MessageBoxResult.Yes)
                {
                    parent.Show();
                    this.Close();
                }
                else if (dialog == MessageBoxResult.No)
                {
                    // User select NO
                }

            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            OpenRegisterView();
        }

        /// <summary>
        /// Muestra la ventana de <see cref="RegisterView"/>.
        /// </summary>        
        private void OpenRegisterView()
        {
            RegisterView registerView = new RegisterView();
            registerView.Show(); // Mostrar Registro
            registerView.parent = this; // Indicamos el padre a la ventan RegisterView
            this.Hide(); // Oculta la ventana padre, MainWindow
        }
    }
}
