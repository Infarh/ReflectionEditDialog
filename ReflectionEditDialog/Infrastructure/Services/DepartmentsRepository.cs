using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReflectionEditDialog.Data.Context;
using ReflectionEditDialog.Data.Entityes;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class DepartmentsRepository : DbRepository<Department>
    {
        public override IQueryable<Department> Items => Set.Include(e => e.Employees);

        public DepartmentsRepository(IDbContextFactory<EmployeesDB> db) : base(db) { }
    }
}
