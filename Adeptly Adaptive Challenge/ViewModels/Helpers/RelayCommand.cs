namespace Adeptly_Adaptive_Challenge.ViewModels.Helpers
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;
        private EventHandler _canExecuteChanged;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            Contract.Requires(execute != null);
            Contract.Ensures(null != _execute);

            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return (_canExecute == null) ? true : _canExecute.Invoke(parameter);
        }

        public virtual void Execute(object parameter)
        {
            Contract.Assert(null != _execute);
            _execute?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                _canExecuteChanged += value;
            }

            remove
            {
                _canExecuteChanged -= value;
            }
        }

        public void EmitCanExecuteChanged()
        {
            _canExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
