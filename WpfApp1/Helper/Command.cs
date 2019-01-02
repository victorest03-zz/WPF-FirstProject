namespace WpfApp1.Helper
{
    using System;
    using System.Windows.Input;

    public class Command : ICommand
    {
        public delegate void CommandOnExecute();
        public delegate bool CommandOnCanExecute();

        private readonly CommandOnExecute _execute;
        private readonly CommandOnCanExecute _canExecute;

        public Command(CommandOnExecute onExecuteMethod, CommandOnCanExecute onCanExecuteMethod = null)
        {
            _execute = onExecuteMethod;
            _canExecute = onCanExecuteMethod;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke() ?? true;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }

        #endregion
    }
}
