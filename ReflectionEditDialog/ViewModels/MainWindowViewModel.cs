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

        private ICommand _LoadDataCommand;

        public ICommand LoadDataCommand => _LoadDataCommand
            ??= new LambdaCommand(OnLoadDataCommandExecuted, CanLoadDataCommandExecute);

        private bool CanLoadDataCommandExecute(object p) => true;

        private void OnLoadDataCommandExecuted(object p)
        {
            Departments = new ObservableCollection<Department>(TestData.Departments);
        }

        public MainWindowViewModel(/* Сервис управления сотрудниками */)
        {
            
        }
    }
}
