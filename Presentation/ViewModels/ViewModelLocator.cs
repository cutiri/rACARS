using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rACARS.Presentation.ViewModels
{
    class ViewModelLocator
    {
        private static LoginViewModel _loginViewModel;

        public static LoginViewModel MyProperty {
            get { if (_loginViewModel == null) _loginViewModel = new LoginViewModel(); return _loginViewModel; }
            private set { _loginViewModel = value; } }
    }
}
