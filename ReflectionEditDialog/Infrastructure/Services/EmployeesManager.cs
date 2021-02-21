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
        private readonly IRepository<Departament> _Departments;

        public IEnumerable<Departament> Departments => _Departments.Items;

        public IEnumerable<Employee> Employees => _Employees.Items;

        public EmployeesManager(IRepository<Employee> Employees, IRepository<Departament> Departments)
        {
            _Employees = Employees;
            _Departments = Departments;
        }

        public Employee AddEmployee(string Name, string LastName, string Patronymic, DateTime Birthday, string Departament)
        {
            if (_Departments.Items.FirstOrDefault(e => e.Name == Departament) is not { } departament)
                _Departments.Add(departament = new Departament {Name = Departament});

            var employee = new Employee
            {
                Name = Name,
                LastName = LastName,
                Patronymic = Patronymic,
                Birthday = Birthday,
                Departament = departament
            };

            _Employees.Add(employee);

            return employee;
        }

        public Employee ChangeDepartament(Employee employee, string Departament)
        {
            if (_Departments.Items.FirstOrDefault(e => e.Name == Departament) is not { } departament)
                _Departments.Add(departament = new Departament { Name = Departament });

            employee.Departament = departament;

            _Employees.Update(employee);

            return employee;
        }
    }
}
