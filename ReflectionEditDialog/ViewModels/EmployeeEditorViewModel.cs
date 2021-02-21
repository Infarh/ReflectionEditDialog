using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using ReflectionEditDialog.Data.Entityes;
using ReflectionEditDialog.Infrastructure;
using ReflectionEditDialog.Infrastructure.Commands;
using ReflectionEditDialog.ViewModels.Base;

namespace ReflectionEditDialog.ViewModels
{
    internal class EmployeeEditorViewModel : ViewModel
    {
        private readonly Dictionary<string, object> _Values = new();

        private bool SetValue(object value, [CallerMemberName] string Property = null)
        {
            if (_Values.TryGetValue(Property!, out var old_value) && Equals(value, old_value)) return false;
            _Values[Property] = value;
            OnPropertyChanged(Property);
            return true;
        }

        private T GetValue<T>(T Default, [CallerMemberName] string Property = null) => _Values.TryGetValue(Property!, out var value) ? (T)value : Default;

        private readonly Employee _Employee;

        public string Name { get => GetValue(_Employee.Name); set => SetValue(value); }
        public string LastName { get => GetValue(_Employee.LastName); set => SetValue(value); }
        public string Patronymic { get => GetValue(_Employee.Patronymic); set => SetValue(value); }
        public DateTime Birthday { get => GetValue(_Employee.Birthday); set => SetValue(value); }

        public Department Department { get => GetValue(_Employee.Department); set => SetValue(value); }

        public IEnumerable<Department> Departments { get; }

        #region Command CloseDialogCommand - Закрыть диалог

        public event EventHandler<EventArgs<bool>> DialogClosed;

        /// <summary>Закрыть диалог</summary>
        private ICommand _CloseDialogCommand;

        /// <summary>Закрыть диалог</summary>
        public ICommand CloseDialogCommand => _CloseDialogCommand
            ??= new LambdaCommand(OnCloseDialogCommandExecuted, CanCloseDialogCommandExecute);

        /// <summary>Проверка возможности выполнения - Закрыть диалог</summary>
        private static bool CanCloseDialogCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Закрыть диалог</summary>
        private void OnCloseDialogCommandExecuted(object p)
        {
            var result = p is not null && Convert.ToBoolean(p);
            if (result) Commit();
            DialogClosed?.Invoke(this, result);
        }

        #endregion

        #region Command RejectCommand - Отменить изменения

        /// <summary>Отменить изменения</summary>
        private ICommand _RejectCommand;

        /// <summary>Отменить изменения</summary>
        public ICommand RejectCommand => _RejectCommand
            ??= new LambdaCommand(OnRejectCommandExecuted, CanRejectCommandExecute);

        /// <summary>Проверка возможности выполнения - Отменить изменения</summary>
        private bool CanRejectCommandExecute(object p) => _Values.Count > 0;

        /// <summary>Логика выполнения - Отменить изменения</summary>
        private void OnRejectCommandExecuted(object p) => Reject();

        #endregion

        public EmployeeEditorViewModel() : this(new Employee(), Enumerable.Empty<Department>()) { }
        public EmployeeEditorViewModel(Employee Employee, IEnumerable<Department> Departments)
        {
            this.Departments = Departments;
            _Employee = Employee;
        }

        private void Commit()
        {
            var type = _Employee.GetType();
            foreach (var (property_name, value) in _Values)
            {
                var property = type.GetProperty(property_name);
                if (property is not { CanWrite: true }) continue;
                property.SetValue(_Employee, value);
            }
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
