using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ReflectionEditDialog.Infrastructure;
using ReflectionEditDialog.Infrastructure.Commands;
using ReflectionEditDialog.Models;
using ReflectionEditDialog.ViewModels.Base;

namespace ReflectionEditDialog.ViewModels
{
    internal class EmployeeEditorViewModel : ViewModel
    {
        public event EventHandler<EventArgs<bool>> Complete;

        private readonly Dictionary<string, object> _Values = new();

        protected virtual bool SetValue(object value, [CallerMemberName] string Property = null)
        {
            if (_Values.TryGetValue(Property!, out var old_value) && Equals(value, old_value))
                return false;
            _Values[Property] = value;
            OnPropertyChanged(Property);
            return true;
        }

        protected virtual T GetValue<T>(T Default, [CallerMemberName] string Property = null)
        {
            if (_Values.TryGetValue(Property!, out var value))
                return (T)value;
            return Default;
        }

        private readonly Employee _Employee;
        public IEnumerable<Department> Departments { get; }

        public string Name { get => GetValue(_Employee.Name); set => SetValue(value); }
        public string LastName { get => GetValue(_Employee.LastName); set => SetValue(value); }
        public string Patronymic { get => GetValue(_Employee.Patronymic); set => SetValue(value); }
        public DateTime Birthday { get => GetValue(_Employee.Birthday); set => SetValue(value); }
        public Department Department { get => GetValue(_Employee.Department); set => SetValue(value); }

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
             Commit();
             Complete?.Invoke(this, true);
        }

        #endregion

        #region Command RejectCommand - Отбросить изменения

        /// <summary>Отбросить изменения</summary>
        private ICommand _RejectCommand;

        /// <summary>Отбросить изменения</summary>
        public ICommand RejectCommand => _RejectCommand
            ??= new LambdaCommand(OnRejectCommandExecuted, CanRejectCommandExecute);

        /// <summary>Проверка возможности выполнения - Отбросить изменения</summary>
        private bool CanRejectCommandExecute(object p) => _Values.Count > 0;

        /// <summary>Логика выполнения - Отбросить изменения</summary>
        private void OnRejectCommandExecuted(object p)
        {
            Reject();
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
            Reject();
            Complete?.Invoke(this, false);
        }

        #endregion

        public EmployeeEditorViewModel() : this(new Employee(), Enumerable.Empty<Department>()) { }

        public EmployeeEditorViewModel(Employee Employee, IEnumerable<Department> Departments)
        {
            _Employee = Employee;
            this.Departments = Departments;
        }

        public void Commit()
        {
            var type = _Employee.GetType();

            foreach (var (property_name, value) in _Values)
            {
                var property = type.GetProperty(property_name);
                if(property is null || !property.CanWrite) continue;

                property.SetValue(_Employee, value);
            }

            _Values.Clear();
        }

        public void Reject()
        {
            var properties = _Values.Keys.ToArray();
            _Values.Clear();

            foreach (var property in properties)
                OnPropertyChanged(property);
        }
    }
}
