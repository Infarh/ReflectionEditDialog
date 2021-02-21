using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ReflectionEditDialog.Data.Entityes;
using ReflectionEditDialog.Infrastructure.Commands;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;
using ReflectionEditDialog.ViewModels.Base;

namespace ReflectionEditDialog.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private readonly IEmployeesManager _EmployeesManager;
        private readonly IUserDialog _UserDialog;

        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Заголовок окна";

        /// <summary>Заголовок окна</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion

        #region Departaments : ObservableCollection<Departament> - Отделы

        /// <summary>Отделы</summary>
        private ObservableCollection<Department> _Departments;

        /// <summary>Отделы</summary>
        public ObservableCollection<Department> Departments { get => _Departments; set => Set(ref _Departments, value); }

        #endregion

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

        #region Command LoadDataCommand - Загрузка данных

        /// <summary>Загрузка данных</summary>
        private ICommand _LoadDataCommand;

        /// <summary>Загрузка данных</summary>
        public ICommand LoadDataCommand => _LoadDataCommand ??= new LambdaCommand(OnLoadDataCommandExecuted);

        /// <summary>Логика выполнения - Загрузка данных</summary>
        private void OnLoadDataCommandExecuted(object p)
        {
            Departments = new ObservableCollection<Department>(_EmployeesManager.Departments.Items);
        }

        #endregion

        #region Command EditEmployeeCommand - Редактировать сотрудника

        /// <summary>Редактировать сотрудника</summary>
        private ICommand _EditEmployeeCommand;

        /// <summary>Редактировать сотрудника</summary>
        public ICommand EditEmployeeCommand => _EditEmployeeCommand
            ??= new LambdaCommand(OnEditEmployeeCommandExecuted, _ => SelectedDepartment != null);

        /// <summary>Логика выполнения - Редактировать сотрудника</summary>
        private void OnEditEmployeeCommandExecuted(object p)
        {
            var employee = p as Employee ?? new Employee();

            if (!_UserDialog.Edit(employee)) return;
            if (p is null)
            {
                _EmployeesManager.Employees.Add(employee);
            }
            else
            {
                _EmployeesManager.Employees.Update(employee);
            }
        }

        #endregion

        #region Command DeleteEmployeeCommand - Удалить сотрудника

        /// <summary>Удалить сотрудника</summary>
        private ICommand _DeleteEmployeeCommand;

        /// <summary>Удалить сотрудника</summary>
        public ICommand DeleteEmployeeCommand => _DeleteEmployeeCommand
            ??= new LambdaCommand(p => _EmployeesManager.Remove((Employee)p), p => p is Employee);

        #endregion

        public MainWindowViewModel(IEmployeesManager Employees, IUserDialog UserDialog)
        {
            _EmployeesManager = Employees;
            _UserDialog = UserDialog;
        }
    }
}
