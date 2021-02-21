using System;
using System.Windows;
using ReflectionEditDialog.Infrastructure.Commands.Base;

namespace ReflectionEditDialog.Infrastructure.Commands
{
    internal class CloseWindowCommand : Command
    {
        protected override bool CanExecute(object p) => p is Window || App.CurrentWindow != null;

        protected override void Execute(object p) => (p as Window ?? App.CurrentWindow)?.Close();
    }
}
