using System;
using System.Collections.Generic;
using System.Linq;

using ReflectionEditDialog.Data.Entityes;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class EmployeesManager : IEmployeesManager
    {
        private readonly IRepository<Employee> _Employees;
        private readonly IRepository<Department> _Departments;

        public IEnumerable<Department> Departments => _Departments.Items;

        public IEnumerable<Employee> Employees => _Employees.Items;

        public EmployeesManager(IRepository<Employee> Employees, IRepository<Department> Departments)
        {
            _Employees = Employees;
            _Departments = Departments;
        }

        public Employee AddEmployee(string Name, string LastName, string Patronymic, DateTime Birthday, string Departament)
        {
            var employee = new Employee
            {
                Name = Name,
                LastName = LastName,
                Patronymic = Patronymic,
                Birthday = Birthday,
                Department = AddDepartment(Departament)
            };

            _Employees.Add(employee);

            return employee;
        }

        public Employee ChangeDepartment(Employee employee, string Department)
        {
            employee.Department = AddDepartment(Department);
            return _Employees.Update(employee);
        }

        public Department AddDepartment(string Name) =>
            _Departments.Items.FirstOrDefault(d => d.Name == Name) is { } departament
                ? departament
                : _Departments.Add(new Department { Name = Name });
    }
}
