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

        #region Command LoadDataCommand - Загрузка данных

        /// <summary>Загрузка данных</summary>
        private ICommand _LoadDataCommand;

        /// <summary>Загрузка данных</summary>
        public ICommand LoadDataCommand => _LoadDataCommand ??= new LambdaCommand(OnLoadDataCommandExecuted);

        /// <summary>Логика выполнения - Загрузка данных</summary>
        private void OnLoadDataCommandExecuted(object p)
        {
            Departments = new ObservableCollection<Department>(_EmployeesManager.Departments);
        }

        #endregion

        public MainWindowViewModel(IEmployeesManager Employees) => _EmployeesManager = Employees;
    }
}
