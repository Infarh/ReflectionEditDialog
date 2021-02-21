using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReflectionEditDialog.Data.Context;
using ReflectionEditDialog.Data.Entityes;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal class DepartmentsRepository : DbRepository<Departament>
    {
        public override IQueryable<Departament> Items => Set.Include(e => e.Employees);

        public DepartmentsRepository(EmployeesDB db) : base(db) { }
    }
}
