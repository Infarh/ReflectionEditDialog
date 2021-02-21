using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using ReflectionEditDialog.Data.Entityes;

namespace ReflectionEditDialog.Data.Context
{
    // Add-Migration Initial -o Data\Migrations -v
    public class EmployeesDB : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public EmployeesDB(DbContextOptions<EmployeesDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            var deps = Enumerable.Range(1, 10)
               .Select(i => new Department { Id = i, Name = $"Отдел {i}" })
               .ToArray();

            model.Entity<Department>().HasIndex(d => d.Name);
            model.Entity<Department>()
               .HasMany(d => d.Employees)
               .WithOne(e => e.Department)
               .OnDelete(DeleteBehavior.Cascade);
            model.Entity<Department>().HasData(deps);

            var rnd = new Random();
            var empls = Enumerable.Range(1, 100)
               .Select(i => new Employee
               {
                   Id = i,
                   Name = $"Имя {i}",
                   LastName = $"Фамилия {i}",
                   Patronymic = $"Отчество {i}",
                   Birthday = DateTime.Now.AddYears(-rnd.Next(18, 35)),
                   DepartmentId = deps[rnd.Next(0, deps.Length)].Id,
               })
               .ToArray();

            model.Entity<Employee>().HasIndex(empl => new { empl.Name, empl.LastName, empl.Patronymic, empl.Birthday });
            model.Entity<Employee>().HasData(empls);

        }
    }
}
