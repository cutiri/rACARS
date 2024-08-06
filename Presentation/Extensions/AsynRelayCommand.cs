using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rACARS.Presentation.Extensions
{
    public interface IAsyncCommand<T> : ICommand
    {
        Task ExecuteAsync(T parameter);
        bool CanExecute(T parameter);
    }

    public class AsyncRelayCommand<T> : IAsyncCommand<T>
    {
        public event EventHandler CanExecuteChanged;

        private bool _isExecuting;
        private readonly Func<T, Task> _execute;
        private readonly Func<T, bool> _canExecute;



        public AsyncRelayCommand(Func<T, Task> execute, Func<T, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(T parameter)
        {
            return !_isExecuting && (_canExecute?.Invoke(parameter) ?? true);
        }

        public async Task ExecuteAsync(T parameter)
        {
            if (CanExecute(parameter))
            {
                try
                {
                    _isExecuting = true;
                    await _execute(parameter);
                }
                finally
                {
                    _isExecuting = false;
                }
            }

            RaiseCanExecuteChanged();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #region Explicit implementations
        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute((T)parameter);
        }

        void ICommand.Execute(object parameter)
        {
            ExecuteAsync((T)parameter);
        }
        #endregion
    }

    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        bool CanExecute();
    }

    public class AsyncRelayCommand : IAsyncCommand
    {
        public event EventHandler CanExecuteChanged;

        private bool _isExecuting;
        private readonly Func<Task> _execute;
        private readonly Func<bool> _canExecute;
        //private readonly IErrorHandler _errorHandler;

        public AsyncRelayCommand(
            Func<Task> execute,
            Func<bool> canExecute = null
            //,IErrorHandler errorHandler = null
            )
        {
            _execute = execute;
            _canExecute = canExecute;
            //_errorHandler = errorHandler;
        }

        public AsyncRelayCommand(Func<Task> execute)
        {
            _execute = execute;
            _canExecute = CanExecute;
        }

        public bool CanExecute()
        {
            //return !_isExecuting && (_canExecute?.Invoke() ?? true);
            return !_isExecuting && (this == _canExecute.Target || (_canExecute?.Invoke() ?? true));
        }

        public async Task ExecuteAsync()
        {
            if (CanExecute())
            {
                //try
                {
                    _isExecuting = true;
                    await _execute();
                }/*catch(Exception e)
                {
                    throw e;
                }
                finally*/
                {
                    _isExecuting = false;
                }
            }

            RaiseCanExecuteChanged();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #region Explicit implementations
        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }

        void ICommand.Execute(object parameter)
        {
            ExecuteAsync();//.FireAndForgetSafeAsync(_errorHandler);
        }
        #endregion
    }

}
