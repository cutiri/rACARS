using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rACARS.Presentation.Extensions
{
    class RelayCommand : ICommand
    {

        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public virtual bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public virtual void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
