using System.Collections.ObjectModel;
using System.Windows.Input;
using ReflectionEditDialog.Data;
using ReflectionEditDialog.Infrastructure.Commands;
using ReflectionEditDialog.Models;
using ReflectionEditDialog.ViewModels.Base;

namespace ReflectionEditDialog.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Заголовок окна";

        /// <summary>Заголовок окна</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion


        private ObservableCollection<Department> _Departments;

        public ObservableCollection<Department> Departments { get => _Departments; set => Set(ref _Departments, value); }

        #region SelectedDepartment : Department - Выбранный отдел

        /// <summary>Выбранный отдел</summary>
        private Department _SelectedDepartment;

        /// <summary>Выбранный отдел</summary>
        public Department SelectedDepartment { get => _SelectedDepartment; set => Set(ref _SelectedDepartment, value); }

        #endregion

        #region SelectedEmployee : Employee - Выбранный сотрудник

        /// <summary>Выбранный сотрудник</summary>
        private Employee _SelectedEmployee;

        /// <summary>Выбранный сотрудник</summary>
        public Employee SelectedEmployee { get => _SelectedEmployee; set => Set(ref _SelectedEmployee, value); }

        #endregion


        #region LoadDataCommand

        private ICommand _LoadDataCommand;

        public ICommand LoadDataCommand => _LoadDataCommand
            ??= new LambdaCommand(OnLoadDataCommandExecuted, CanLoadDataCommandExecute);

        private bool CanLoadDataCommandExecute(object p) => true;

        private void OnLoadDataCommandExecuted(object p)
        {
            Departments = new ObservableCollection<Department>(TestData.Departments);
        } 

        #endregion

        #region Command CreateEmployeeCommand - Создание нового сотрудника

        /// <summary>Создание нового сотрудника</summary>
        private ICommand _CreateEmployeeCommand;

        /// <summary>Создание нового сотрудника</summary>
        public ICommand CreateEmployeeCommand => _CreateEmployeeCommand
            ??= new LambdaCommand(OnCreateEmployeeCommandExecuted, CanCreateEmployeeCommandExecute);

        /// <summary>Проверка возможности выполнения - Создание нового сотрудника</summary>
        private bool CanCreateEmployeeCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Создание нового сотрудника</summary>
        private void OnCreateEmployeeCommandExecuted(object p)
        {
            
        }

        #endregion

        #region Command EditEmployeeCommand - Редактирование сотрудника

        /// <summary>Редактирование сотрудника</summary>
        private ICommand _EditEmployeeCommand;

        /// <summary>Редактирование сотрудника</summary>
        public ICommand EditEmployeeCommand => _EditEmployeeCommand
            ??= new LambdaCommand(OnEditEmployeeCommandExecuted, CanEditEmployeeCommandExecute);

        /// <summary>Проверка возможности выполнения - Редактирование сотрудника</summary>
        private bool CanEditEmployeeCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Редактирование сотрудника</summary>
        private void OnEditEmployeeCommandExecuted(object p)
        {
            
        }

        #endregion

        #region Command RemoveEmployeeCommand - Удаление сотрудника

        /// <summary>Удаление сотрудника</summary>
        private ICommand _RemoveEmployeeCommand;

        /// <summary>Удаление сотрудника</summary>
        public ICommand RemoveEmployeeCommand => _RemoveEmployeeCommand
            ??= new LambdaCommand(OnRemoveEmployeeCommandExecuted, CanRemoveEmployeeCommandExecute);

        /// <summary>Проверка возможности выполнения - Удаление сотрудника</summary>
        private bool CanRemoveEmployeeCommandExecute(object p) =>
            p is Employee employee 
            && SelectedDepartment != null 
            && SelectedDepartment.Employees.Contains(employee);

        /// <summary>Логика выполнения - Удаление сотрудника</summary>
        private void OnRemoveEmployeeCommandExecuted(object p)
        {
            var dep = SelectedDepartment;
            dep.Employees.Remove((Employee) p);
            SelectedDepartment = null;
            SelectedDepartment = dep;
        }

        #endregion

        public MainWindowViewModel(/* Сервис управления сотрудниками */)
        {
            
        }
    }
}
