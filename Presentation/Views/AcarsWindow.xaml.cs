using rACARS.Model.PhpVmsAPI;
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
    /// Interaction logic for AcarsWindow.xaml
    /// </summary>
    public partial class AcarsWindow : Window
    {
        public User user { get; set; }
        public AcarsWindow()
        {
            InitializeComponent();
        }
        public AcarsWindow(User user) : this ()
        {
            this.user = user;
            ((AcarsViewModel)this.FindResource("acars")).User = user;
        }
    }
}
