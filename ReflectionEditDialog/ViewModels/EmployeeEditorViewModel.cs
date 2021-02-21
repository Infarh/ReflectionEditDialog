using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ReflectionEditDialog.Infrastructure.Commands;
using ReflectionEditDialog.Models;
using ReflectionEditDialog.ViewModels.Base;

namespace ReflectionEditDialog.ViewModels
{
    internal class EmployeeEditorViewModel : ViewModel
    {
        private readonly Employee _Employee;
        private IEnumerable<Department> Departments { get; }

        public string Name { get => _Employee.Name; set { } }
        public string LastName { get => _Employee.LastName; set { } }
        public string Patronymic { get => _Employee.Patronymic; set { } }
        public DateTime Birthday { get => _Employee.Birthday; set { } }
        public Department Department { get => _Employee.Department; set { } }

        #region Command CommitCommand - Принять изменения

        /// <summary>Принять изменения</summary>
        private ICommand _CommitCommand;

        /// <summary>Принять изменения</summary>
        public ICommand CommitCommand => _CommitCommand
            ??= new LambdaCommand(OnCommitCommandExecuted, CanCommitCommandExecute);

        /// <summary>Проверка возможности выполнения - Принять изменения</summary>
        private bool CanCommitCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Принять изменения</summary>
        private void OnCommitCommandExecuted(object p)
        {
            
        }

        #endregion

        #region Command RejectCommand - Отбросить изменения

        /// <summary>Отбросить изменения</summary>
        private ICommand _RejectCommand;

        /// <summary>Отбросить изменения</summary>
        public ICommand RejectCommand => _RejectCommand
            ??= new LambdaCommand(OnRejectCommandExecuted, CanRejectCommandExecute);

        /// <summary>Проверка возможности выполнения - Отбросить изменения</summary>
        private bool CanRejectCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Отбросить изменения</summary>
        private void OnRejectCommandExecuted(object p)
        {

        }

        #endregion

        #region Command CancelCommand - Отменить изменения

        /// <summary>Отменить изменения</summary>
        private ICommand _CancelCommand;

        /// <summary>Отменить изменения</summary>
        public ICommand CancelCommand => _CancelCommand
            ??= new LambdaCommand(OnCancelCommandExecuted, CanCancelCommandExecute);

        /// <summary>Проверка возможности выполнения - Отменить изменения</summary>
        private bool CanCancelCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Отменить изменения</summary>
        private void OnCancelCommandExecuted(object p)
        {

        }

        #endregion

        public EmployeeEditorViewModel() : this(new Employee(), Enumerable.Empty<Department>()) { }

        public EmployeeEditorViewModel(Employee Employee, IEnumerable<Department> Departments)
        {
            _Employee = Employee;
            this.Departments = Departments;
        }
    }
}
