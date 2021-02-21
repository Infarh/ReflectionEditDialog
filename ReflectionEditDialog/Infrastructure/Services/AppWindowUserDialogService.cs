using System.Collections.Generic;
using System.Windows;
using ReflectionEditDialog.Data;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;
using ReflectionEditDialog.Models;
using ReflectionEditDialog.ViewModels;
using ReflectionEditDialog.Views.Windows;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class AppWindowUserDialogService : IUserDialog
    {
        private IEnumerable<Department> _Departments;

        public AppWindowUserDialogService(/* Репозиторий отделов */)
        {
            _Departments = TestData.Departments;
        }

        public bool Edit(Employee model)
        {
            var view_model = new EmployeeEditorViewModel(model, _Departments);
            var view = new EmployeeEditorWindow
            {
                DataContext = view_model,
                Owner = App.CurrentWindow,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            view_model.Complete += (_, e) =>
            {
                view.DialogResult = e.Arg;
                view.Close();
            };

            return view.ShowDialog() ?? false;
        }
    }
}
