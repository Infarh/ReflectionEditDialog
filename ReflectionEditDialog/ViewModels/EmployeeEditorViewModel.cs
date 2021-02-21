using System.Collections.Generic;
using System.Linq;

using ReflectionEditDialog.Models;
using ReflectionEditDialog.ViewModels.Base;

namespace ReflectionEditDialog.ViewModels
{
    internal class EmployeeEditorViewModel : ViewModel
    {
        private readonly Employee _Employee;
        private readonly IEnumerable<Department> _Departments;

        public EmployeeEditorViewModel() : this(new Employee(), Enumerable.Empty<Department>()) { }

        public EmployeeEditorViewModel(Employee Employee, IEnumerable<Department> Departments)
        {
            _Employee = Employee;
            _Departments = Departments;
        }
    }
}
