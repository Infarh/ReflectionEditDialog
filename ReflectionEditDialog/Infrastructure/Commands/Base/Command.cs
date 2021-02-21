using System;
using System.Windows.Input;

namespace ReflectionEditDialog.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        bool ICommand.CanExecute(object parameter) { throw new NotImplementedException(); }

        void ICommand.Execute(object parameter)
        {
            if(((ICommand)this).CanExecute(parameter))
                Execute(parameter);
        }

        protected virtual bool CanExecute(object p) => true;

        protected abstract void Execute(object p);
    }
}
