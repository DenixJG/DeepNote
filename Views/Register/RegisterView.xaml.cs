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

namespace DeepNote.Views.Register
{
    /// <summary>
    /// Lógica de interacción para RegisterView.xaml
    /// </summary>
    public partial class RegisterView : Window
    {
        public Window parent { get; set; }
        public RegisterView()
        {
            InitializeComponent();
        }

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
    }
}
