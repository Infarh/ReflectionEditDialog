using ReflectionEditDialog.Data.Entityes;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;
using ReflectionEditDialog.ViewModels;
using ReflectionEditDialog.Views.Windows;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class AppWindowUserDialog : IUserDialog
    {
        private readonly IRepository<Department> _Departments;

        public AppWindowUserDialog(IRepository<Department> Departments) { _Departments = Departments; }

        public bool Edit(Employee model)
        {
            var view_model = new EmployeeEditorViewModel(model, _Departments.Items);
            var view = new EmployeeEditorWindow { DataContext = view_model };
            view_model.DialogClosed += (_, e) =>
            {
                view.DialogResult = e.Arg;
                view.Close();
            };

            return view.ShowDialog() ?? false;
        }
    }
}
