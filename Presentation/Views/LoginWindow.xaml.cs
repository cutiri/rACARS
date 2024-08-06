using rACARS.Presentation.ViewModels;
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

namespace rACARS.Presentation.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            ((LoginViewModel)this.FindResource("login")).OnConnectedSuccesfully += LoadMainWindow;

        }

        private void BtAccept_Click(object sender, RoutedEventArgs e)
        {
        }

        private void LoadMainWindow()
        {
            this.Hide();
            var a = (LoginViewModel)this.FindResource("login");
            AcarsWindow window = new AcarsWindow(((LoginViewModel)this.FindResource("login")).User);
            window.ShowDialog();
            this.Close();
        }
    }
}
