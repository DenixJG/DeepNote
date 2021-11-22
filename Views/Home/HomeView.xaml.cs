using DeepNote.Controllers;
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

        public HomeView()
        {
            InitializeComponent();
            ShowTimeInLabel();
            // GetLoginUser();
        }

        public HomeView(Window parent, UserController userController)
        {
            this.parent = parent;
            this.UserController = userController;
            ShowTimeInLabel();
            // GetLoginUser();
        }

        private void StatusTimeElapsed(Object sender, ElapsedEventArgs e)
        {
            App.Current.Dispatcher.Invoke(delegate
            {
                lblDateInfo.Content = DateTime.Now.ToString("G");
            });
        }

        private void ShowTimeInLabel()
        {
            Timer statusTime = new Timer();
            statusTime.Interval = 1000;
            statusTime.Elapsed += new ElapsedEventHandler(StatusTimeElapsed);
            statusTime.Enabled = true;
        }

        public void GetLoginUser()
        {
            lblUsernameInfo.Content = UserController.user.Username;
        }        

    }
}
