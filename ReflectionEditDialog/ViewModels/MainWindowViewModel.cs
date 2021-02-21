using System.Collections.ObjectModel;
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

        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Заголовок окна";

        /// <summary>Заголовок окна</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion

        #region Employees : ObservableCollection<Employee> - Сотрудники

        /// <summary>Сотрудники</summary>
        private ObservableCollection<Employee> _Employees;

        /// <summary>Сотрудники</summary>
        public ObservableCollection<Employee> Employees { get => _Employees; set => Set(ref _Employees, value); }

        #endregion

        #region Departaments : ObservableCollection<Departament> - Отделы

        /// <summary>Отделы</summary>
        private ObservableCollection<Department> _Departments;

        /// <summary>Отделы</summary>
        public ObservableCollection<Department> Departaments { get => _Departments; set => Set(ref _Departments, value); }

        #endregion

        #region Command LoadDataCommand - Загрузка данных

        /// <summary>Загрузка данных</summary>
        private ICommand _LoadDataCommand;

        /// <summary>Загрузка данных</summary>
        public ICommand LoadDataCommand => _LoadDataCommand ??= new LambdaCommand(OnLoadDataCommandExecuted);

        /// <summary>Логика выполнения - Загрузка данных</summary>
        private void OnLoadDataCommandExecuted(object p)
        {
            Employees = new ObservableCollection<Employee>(_EmployeesManager.Employees);
        }

        #endregion

        public MainWindowViewModel(IEmployeesManager Employees) => _EmployeesManager = Employees;
    }
}
