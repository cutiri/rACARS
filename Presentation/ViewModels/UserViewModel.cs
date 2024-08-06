using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using rACARS.Model.PhpVmsAPI;
using rACARS.Presentation.Extensions;

namespace rACARS.Presentation.ViewModels
{
    class UserViewModel : ViewModelBase
    {
        public ICommand ChangeNameCommand { get; }
        private User user = new User();

        public UserViewModel()
        {
            ChangeNameCommand = new RelayCommand(i => { user.DoSomething(); NotifyAllPropertiesHaveChanged(); }, i => true);
        }

        public string Name {
            get { return user.name; }
            set {
                user.name = value;
                NotifyPropertyChanged();
            }
        }
    }
}
