using System;
using System.Collections.Generic;
using System.Linq;

using ReflectionEditDialog.Data.Entityes;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class EmployeesManager : IEmployeesManager
    {
        public IRepository<Department> Departments { get; }

        public IRepository<Employee> Employees { get; }

        public EmployeesManager(IRepository<Employee> Employees, IRepository<Department> Departments)
        {
            this.Employees = Employees;
            this.Departments = Departments;
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

            Employees.Add(employee);

            return employee;
        }

        public Employee ChangeDepartment(Employee employee, string Department)
        {
            employee.Department = AddDepartment(Department);
            return Employees.Update(employee);
        }

        public Department AddDepartment(string Name) =>
            Departments.Items.FirstOrDefault(d => d.Name == Name) is { } departament
                ? departament
                : Departments.Add(new Department { Name = Name });

        public bool Remove(Employee employee) => employee is null
            ? throw new ArgumentNullException(nameof(employee))
            : Employees.Remove(employee.Id);
    }
}
