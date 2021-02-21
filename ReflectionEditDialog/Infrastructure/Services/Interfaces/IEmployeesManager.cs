using System;
using System.Collections.Generic;
using ReflectionEditDialog.Data.Entityes;

namespace ReflectionEditDialog.Infrastructure.Services.Interfaces
{
    internal interface IEmployeesManager
    {
        IEnumerable<Department> Departments { get; }
        IEnumerable<Employee> Employees { get; }
        Employee AddEmployee(string Name, string LastName, string Patronymic, DateTime Birthday, string Departament);
        Employee ChangeDepartment(Employee employee, string Department);
        Department AddDepartment(string Name);
        bool Remove(Employee employee);
    }
}
