using DeepNote.Controllers;
using DeepNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeepNote.Views.Home
{
    /// <summary>
    /// Lógica de interacción para HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {

        public Window parent { get; set; }
        public UserController UserController { get; set; }
        public NoteController NoteController { get; set; }
        public List<string> Prioridades { get; set; }

        public HomeView()
        {
            InitializeComponent();
            ShowTimeInLabel();
            // GetLoginUser();
            NoteController = new NoteController();
            Prioridades = new List<string> { "Bajo", "Normal", "Alto" };
            this.DataContext = this;
        }

        public HomeView(Window parent, UserController userController)
        {
            this.parent = parent;
            this.UserController = userController;
            ShowTimeInLabel();
            NoteController = new NoteController();
            Prioridades = new List<string> { "Bajo", "Normal", "Alto" };
            this.DataContext = this;
        }

        /// <summary>
        /// Metodo que escribe la fecha en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusTimeElapsed(Object sender, ElapsedEventArgs e)
        {
            App.Current.Dispatcher.Invoke(delegate
            {
                lblDateInfo.Content = DateTime.Now.ToString("G");
            });
        }

        /// <summary>
        /// Evento personal que se activa cada segundo
        /// </summary>
        private void ShowTimeInLabel()
        {
            Timer statusTime = new Timer();
            statusTime.Interval = 1000;
            statusTime.Elapsed += new ElapsedEventHandler(StatusTimeElapsed);
            statusTime.Enabled = true;
        }

        // Obtiene el usuario que esta logeado
        public void GetLoginUser()
        {
            lblUsernameInfo.Content = UserController.user.Username;
        }

        private void TitleGotFocus(object sender, RoutedEventArgs e)
        {
            if (NoteTitle.Text.Equals("Title"))
            {
                NoteTitle.Text = "";
            }
        }

        private void BodyGotFocus(object sender, RoutedEventArgs e)
        {
            if (NoteBody.Text.Equals("Descripción"))
            {
                NoteBody.Text = "";
            }
        }

        private void TitleLostFocus(object sender, RoutedEventArgs e)
        {
            if (NoteTitle.Text.Length < 1)
            {
                NoteTitle.Text = "Title";
            }
        }

        private void BodyLostFocus(object sender, RoutedEventArgs e)
        {
            if (NoteBody.Text.Length < 1)
            {
                NoteBody.Text = "Descripción";
            }
        }
    }
}
