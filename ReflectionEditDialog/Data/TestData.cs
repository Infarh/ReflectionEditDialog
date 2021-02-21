using System;
using System.Collections.Generic;
using System.Linq;
using ReflectionEditDialog.Models;

namespace ReflectionEditDialog.Data
{
    static class TestData
    {
        static TestData()
        {
            Departments = Enumerable.Range(1, 10)
               .Select(i => new Department
                {
                    Id = i,
                    Name = $"Отдел {i}"
                })
               .ToList();

            var rnd = new Random();

            Employees = Enumerable.Range(1, 100)
               .Select(i =>
                {
                    var employee = new Employee
                    {
                        Id = i,
                        Name = $"Имя {i}",
                        LastName = $"Фамилия {i}",
                        Patronymic = $"Отчество {i}",
                        Birthday = DateTime.Now.Date.AddYears(-rnd.Next(18, 51)),
                        Department = Departments[rnd.Next(0, Departments.Count)]
                    };
                    employee.Department.Employees.Add(employee);
                    return employee;
                })
               .ToList();
        }

        public static List<Department> Departments { get; }

        public static List<Employee> Employees { get; }
    }
}
